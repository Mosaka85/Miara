﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Miara
{
    public partial class frmEmployeeDetails : Form
    {
        private static readonly string configFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config.xml");
        private string connectionString;
        private DataView employeeDataView;
        private DataTable employeeDataTable;

        public frmEmployeeDetails()
        {
            InitializeComponent();

        }

        private void LoadSQLConnectionInfo()
        {
            if (File.Exists(configFile))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(LoginInfo));
                    using (FileStream fileStream = new FileStream(configFile, FileMode.Open))
                    {
                        LoginInfo loginInfo = (LoginInfo)serializer.Deserialize(fileStream);
                        connectionString = $"Data Source={loginInfo.DataSource};Initial Catalog={loginInfo.SelectedDatabase};User ID={loginInfo.Username};Password={loginInfo.Password}";
                    }

                }


                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load connection information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Connection configuration file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeData()
        {
            string query = "SELECT EmployeeID, EmployeeFirstName, EmployeeSurname, Department, Role, Username, HireDate, Email, PHONE , IsActive FROM Employees";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    employeeDataTable = new DataTable();
                    adapter.Fill(employeeDataTable);

                    dataGridEmployeeList.DataSource = employeeDataTable;
                    employeeDataView = new DataView(employeeDataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveNewEmployee_Click(object sender, EventArgs e)
        {


            string query = @"
                INSERT INTO [POS_MOSAKA].[dbo].[Employees] (
                    [EmployeeFirstName],
                    [EmployeeSurname],
                    [Department],
                    [Role],
                    [Username],
                    [PasswordHash],
                    [HireDate],
                    [Email],
                    [IsActive],
                    [PHONE]
                )
                VALUES (
                    @EmployeeFirstName,
                    @EmployeeSurname,
                    @Department,
                    @Role,
                    @Username,
                    @PasswordHash,
                    @HireDate,
                    @Email,
                    @IsActive,
                    @PHONE
                );";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeFirstName", txtEmployeeName.Text);
                        command.Parameters.AddWithValue("@EmployeeSurname", txtEmployeeSurname.Text);
                        command.Parameters.AddWithValue("@Department", comboEmployeeDepartment.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Role", comboBoxRoles.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Username", txtUsername.Text);
                        command.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
                        command.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);
                        command.Parameters.AddWithValue("@PHONE", txtEmployeePhone.Text);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Employee registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEmployeeData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error registering employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                StringBuilder hashBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashBuilder.Append(b.ToString("x2"));
                }
                return hashBuilder.ToString();
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            txtEmployeeName.Clear();
            txtEmployeeSurname.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            chkIsActive.Checked = true;
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            LoadSQLConnectionInfo();
            LoadEmployeeData();
            LoadDepartments();
            comboBoxRoles.SelectedItem = -1;

            if (dataGridEmployeeList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridEmployeeList.SelectedRows[0];

                // Repopulate form fields
                txtEmployeeID.Text = selectedRow.Cells["EmployeeID"].Value.ToString();
                txtEmployeeName.Text = selectedRow.Cells["EmployeeFirstName"].Value.ToString();
                txtEmployeeSurname.Text = selectedRow.Cells["EmployeeSurname"].Value.ToString();
                comboEmployeeDepartment.SelectedItem = selectedRow.Cells["Department"].Value.ToString();
                comboBoxRoles.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtPassword.Text = ""; // Clear password field for security
                dtpHireDate.Value = Convert.ToDateTime(selectedRow.Cells["HireDate"].Value);
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
                txtEmployeePhone.Text = selectedRow.Cells["PHONE"].Value.ToString(); ;
            }
        }

        private void LoadDepartments()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DepartmentID, DepartmentName FROM [EmployeeDepartments] WHERE IsActive = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboEmployeeDepartment.DisplayMember = "DepartmentName"; // Display department names
                    comboEmployeeDepartment.ValueMember = "DepartmentID";     // Store department IDs
                    comboEmployeeDepartment.DataSource = dt;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler for department selection change
        private void comboEmployeeDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboEmployeeDepartment.SelectedValue != null)
            {
                string selectedDepartmentID = comboEmployeeDepartment.SelectedValue.ToString();
                LoadRoles(selectedDepartmentID);
            }
        }

        // Method to load roles into the ComboBox based on the selected department
        private void LoadRoles(string departmentID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT RoleName FROM EmployeeRoles WHERE DepartmentID = @DepartmentID AND IsActive = 1";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DepartmentID", departmentID);
                    SqlDataReader reader = command.ExecuteReader();

                    comboBoxRoles.Items.Clear();
                    while (reader.Read())
                    {
                        comboBoxRoles.Items.Add(reader["RoleName"].ToString());
                    }

                    reader.Close(); // Ensure the reader is closed
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridEmployeeList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridEmployeeList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridEmployeeList.SelectedRows[0];

                // Repopulate form fields
                txtEmployeeID.Text = selectedRow.Cells["EmployeeID"].Value.ToString();
                txtEmployeeName.Text = selectedRow.Cells["EmployeeFirstName"].Value.ToString();
                txtEmployeeSurname.Text = selectedRow.Cells["EmployeeSurname"].Value.ToString();
                comboEmployeeDepartment.SelectedItem = selectedRow.Cells["Department"].Value.ToString();
                comboBoxRoles.SelectedItem = selectedRow.Cells["Role"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["Username"].Value.ToString();
                txtPassword.Text = ""; // Clear password field for security
                dtpHireDate.Value = Convert.ToDateTime(selectedRow.Cells["HireDate"].Value);
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                chkIsActive.Checked = Convert.ToBoolean(selectedRow.Cells["IsActive"].Value);
                txtEmployeePhone.Text = selectedRow.Cells["PHONE"].Value.ToString();
            }
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            {
                // Validate EmployeeID
                if (string.IsNullOrEmpty(txtEmployeeID.Text))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate other fields (optional)
                if (string.IsNullOrEmpty(txtEmployeeName.Text) || string.IsNullOrEmpty(txtEmployeeSurname.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // SQL query to update the employee record
                string query = @"
        UPDATE [Employees]
        SET
            [EmployeeFirstName] = @EmployeeFirstName,
            [EmployeeSurname] = @EmployeeSurname,
            [Department] = @Department,
            [Role] = @Role,
            [Username] = @Username,
            [PasswordHash] = @PasswordHash,
            [HireDate] = @HireDate,
            [Email] = @Email,
            [IsActive] = @IsActive
        WHERE
            [EmployeeID] = @EmployeeID;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters with values from the form controls
                            command.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                            command.Parameters.AddWithValue("@EmployeeFirstName", txtEmployeeName.Text);
                            command.Parameters.AddWithValue("@EmployeeSurname", txtEmployeeSurname.Text);
                            command.Parameters.AddWithValue("@Department", comboEmployeeDepartment.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Role", comboBoxRoles.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Username", txtUsername.Text);
                            command.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text)); // Hash the password
                            command.Parameters.AddWithValue("@HireDate", dtpHireDate.Value);
                            command.Parameters.AddWithValue("@Email", txtEmail.Text);
                            command.Parameters.AddWithValue("@IsActive", chkIsActive.Checked);

                            // Execute the update query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employee updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadEmployeeData(); // Refresh the employee data grid or list
                            }
                            else
                            {
                                MessageBox.Show("No employee found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

}