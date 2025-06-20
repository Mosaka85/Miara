﻿
using System.Drawing;
using System.Windows.Forms;

namespace Miara
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            this.lblNextSalesNumber = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lblSubtotalorder = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblrendered = new System.Windows.Forms.Label();
            this.txtrenderedamount = new System.Windows.Forms.TextBox();
            this.lblChange = new System.Windows.Forms.Label();
            this.btnCalculatechange = new System.Windows.Forms.Button();
            this.lbldiscountvalue = new System.Windows.Forms.Label();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblBusineess = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkEmail = new System.Windows.Forms.CheckBox();
            this.txtRecipientEmail = new System.Windows.Forms.TextBox();
            this.btnVoidLine = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnCupons = new System.Windows.Forms.Button();
            this.btnPriceCheck = new System.Windows.Forms.Button();
            this.btnOpenCashDrawer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReprint = new System.Windows.Forms.Button();
            this.lblCashBack = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripChangeBackColour = new System.Windows.Forms.ToolStripTextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkdiscount = new MaterialSkin.Controls.MaterialCheckbox();
            this.comboProductCategory = new MaterialSkin.Controls.MaterialComboBox();
            this.comboBoxProducts = new MaterialSkin.Controls.MaterialComboBox();
            this.combopaymentmentod = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.txtQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSaleDetails = new System.Windows.Forms.DataGridView();
            this.txtBarcodeLabel = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblScan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetails)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNextSalesNumber
            // 
            this.lblNextSalesNumber.AutoSize = true;
            this.lblNextSalesNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextSalesNumber.Location = new System.Drawing.Point(643, 128);
            this.lblNextSalesNumber.Name = "lblNextSalesNumber";
            this.lblNextSalesNumber.Size = new System.Drawing.Size(184, 28);
            this.lblNextSalesNumber.TabIndex = 1;
            this.lblNextSalesNumber.Text = "SALES ORDER NO:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(654, 535);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(212, 35);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.BackColor = System.Drawing.Color.Yellow;
            this.btnCompleteSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteSale.ForeColor = System.Drawing.Color.Black;
            this.btnCompleteSale.Location = new System.Drawing.Point(1171, 690);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(142, 87);
            this.btnCompleteSale.TabIndex = 8;
            this.btnCompleteSale.Text = "Complete Sale\r\n(F2)";
            this.btnCompleteSale.UseVisualStyleBackColor = false;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(656, 579);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(119, 24);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "VAT(15%) : ";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lblSubtotalorder
            // 
            this.lblSubtotalorder.AutoSize = true;
            this.lblSubtotalorder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalorder.Location = new System.Drawing.Point(656, 603);
            this.lblSubtotalorder.Name = "lblSubtotalorder";
            this.lblSubtotalorder.Size = new System.Drawing.Size(96, 24);
            this.lblSubtotalorder.TabIndex = 22;
            this.lblSubtotalorder.Text = "Subtotal:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(665, 913);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 83);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblrendered
            // 
            this.lblrendered.AutoSize = true;
            this.lblrendered.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrendered.Location = new System.Drawing.Point(8, 529);
            this.lblrendered.Name = "lblrendered";
            this.lblrendered.Size = new System.Drawing.Size(164, 21);
            this.lblrendered.TabIndex = 26;
            this.lblrendered.Text = "Amount Rendered :";
            // 
            // txtrenderedamount
            // 
            this.txtrenderedamount.Font = new System.Drawing.Font("Arial", 10.8F);
            this.txtrenderedamount.Location = new System.Drawing.Point(202, 526);
            this.txtrenderedamount.Name = "txtrenderedamount";
            this.txtrenderedamount.Size = new System.Drawing.Size(198, 28);
            this.txtrenderedamount.TabIndex = 27;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblChange.ForeColor = System.Drawing.Color.Red;
            this.lblChange.Location = new System.Drawing.Point(8, 558);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(130, 24);
            this.lblChange.TabIndex = 28;
            this.lblChange.Text = "Change due:";
            // 
            // btnCalculatechange
            // 
            this.btnCalculatechange.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalculatechange.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCalculatechange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculatechange.ForeColor = System.Drawing.Color.Black;
            this.btnCalculatechange.Location = new System.Drawing.Point(338, 579);
            this.btnCalculatechange.Name = "btnCalculatechange";
            this.btnCalculatechange.Size = new System.Drawing.Size(113, 69);
            this.btnCalculatechange.TabIndex = 29;
            this.btnCalculatechange.Text = "Change";
            this.btnCalculatechange.UseVisualStyleBackColor = false;
            this.btnCalculatechange.Click += new System.EventHandler(this.btnCalculatechange_Click);
            // 
            // lbldiscountvalue
            // 
            this.lbldiscountvalue.AutoSize = true;
            this.lbldiscountvalue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lbldiscountvalue.Location = new System.Drawing.Point(656, 627);
            this.lbldiscountvalue.Name = "lbldiscountvalue";
            this.lbldiscountvalue.Size = new System.Drawing.Size(166, 24);
            this.lbldiscountvalue.TabIndex = 31;
            this.lbldiscountvalue.Text = "Discount: R 0,00";
            // 
            // txtdiscount
            // 
            this.txtdiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiscount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(165, 389);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(76, 30);
            this.txtdiscount.TabIndex = 32;
            this.txtdiscount.Text = "0";
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(825, 76);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(123, 24);
            this.lblDateTime.TabIndex = 33;
            this.lblDateTime.Text = "DATE TIME:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblBusineess
            // 
            this.lblBusineess.AutoSize = true;
            this.lblBusineess.BackColor = System.Drawing.Color.Transparent;
            this.lblBusineess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBusineess.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusineess.ForeColor = System.Drawing.Color.White;
            this.lblBusineess.Location = new System.Drawing.Point(806, -17);
            this.lblBusineess.Name = "lblBusineess";
            this.lblBusineess.Size = new System.Drawing.Size(349, 84);
            this.lblBusineess.TabIndex = 34;
            this.lblBusineess.Text = "Point Of Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            // 
            // checkEmail
            // 
            this.checkEmail.AutoSize = true;
            this.checkEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEmail.Location = new System.Drawing.Point(662, 701);
            this.checkEmail.Name = "checkEmail";
            this.checkEmail.Size = new System.Drawing.Size(160, 28);
            this.checkEmail.TabIndex = 37;
            this.checkEmail.Text = "Email Receipt";
            this.checkEmail.UseVisualStyleBackColor = true;
            this.checkEmail.CheckedChanged += new System.EventHandler(this.checkEmail_CheckedChanged);
            // 
            // txtRecipientEmail
            // 
            this.txtRecipientEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecipientEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipientEmail.Location = new System.Drawing.Point(662, 747);
            this.txtRecipientEmail.Name = "txtRecipientEmail";
            this.txtRecipientEmail.Size = new System.Drawing.Size(443, 30);
            this.txtRecipientEmail.TabIndex = 38;
            // 
            // btnVoidLine
            // 
            this.btnVoidLine.BackColor = System.Drawing.Color.DeepPink;
            this.btnVoidLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoidLine.ForeColor = System.Drawing.Color.Black;
            this.btnVoidLine.Location = new System.Drawing.Point(1127, 803);
            this.btnVoidLine.Name = "btnVoidLine";
            this.btnVoidLine.Size = new System.Drawing.Size(186, 83);
            this.btnVoidLine.TabIndex = 39;
            this.btnVoidLine.Text = "Void Line";
            this.btnVoidLine.UseVisualStyleBackColor = false;
            this.btnVoidLine.Click += new System.EventHandler(this.btnVoidLine_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.Crimson;
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefund.ForeColor = System.Drawing.Color.Black;
            this.btnRefund.Location = new System.Drawing.Point(1407, 805);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(181, 79);
            this.btnRefund.TabIndex = 40;
            this.btnRefund.Text = "Refund";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnCupons
            // 
            this.btnCupons.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCupons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCupons.ForeColor = System.Drawing.Color.Black;
            this.btnCupons.Location = new System.Drawing.Point(894, 803);
            this.btnCupons.Name = "btnCupons";
            this.btnCupons.Size = new System.Drawing.Size(155, 87);
            this.btnCupons.TabIndex = 44;
            this.btnCupons.Text = "Apply Coupon/Voucher";
            this.btnCupons.UseVisualStyleBackColor = false;
            this.btnCupons.Click += new System.EventHandler(this.btnCupons_Click);
            // 
            // btnPriceCheck
            // 
            this.btnPriceCheck.BackColor = System.Drawing.Color.MediumPurple;
            this.btnPriceCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPriceCheck.ForeColor = System.Drawing.Color.Black;
            this.btnPriceCheck.Location = new System.Drawing.Point(1127, 910);
            this.btnPriceCheck.Name = "btnPriceCheck";
            this.btnPriceCheck.Size = new System.Drawing.Size(186, 82);
            this.btnPriceCheck.TabIndex = 45;
            this.btnPriceCheck.Text = "Price Check";
            this.btnPriceCheck.UseVisualStyleBackColor = false;
            // 
            // btnOpenCashDrawer
            // 
            this.btnOpenCashDrawer.BackColor = System.Drawing.Color.LightCoral;
            this.btnOpenCashDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenCashDrawer.ForeColor = System.Drawing.Color.Black;
            this.btnOpenCashDrawer.Location = new System.Drawing.Point(1407, 910);
            this.btnOpenCashDrawer.Name = "btnOpenCashDrawer";
            this.btnOpenCashDrawer.Size = new System.Drawing.Size(181, 82);
            this.btnOpenCashDrawer.TabIndex = 46;
            this.btnOpenCashDrawer.Text = "Open Cash Drawer";
            this.btnOpenCashDrawer.UseVisualStyleBackColor = false;
            this.btnOpenCashDrawer.Click += new System.EventHandler(this.btnOpenCashDrawer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSlateGray;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(660, 798);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 96);
            this.button2.TabIndex = 49;
            this.button2.Text = "CashBack";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReprint
            // 
            this.btnReprint.BackColor = System.Drawing.Color.BurlyWood;
            this.btnReprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReprint.ForeColor = System.Drawing.Color.Black;
            this.btnReprint.Location = new System.Drawing.Point(885, 916);
            this.btnReprint.Name = "btnReprint";
            this.btnReprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnReprint.Size = new System.Drawing.Size(164, 76);
            this.btnReprint.TabIndex = 54;
            this.btnReprint.Text = "Reprint Receipt";
            this.btnReprint.UseVisualStyleBackColor = false;
            this.btnReprint.Click += new System.EventHandler(this.btnReprint_Click);
            // 
            // lblCashBack
            // 
            this.lblCashBack.AutoSize = true;
            this.lblCashBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblCashBack.Location = new System.Drawing.Point(656, 661);
            this.lblCashBack.Name = "lblCashBack";
            this.lblCashBack.Size = new System.Drawing.Size(116, 24);
            this.lblCashBack.TabIndex = 55;
            this.lblCashBack.Text = "Cashback :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripChangeBackColour,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 57);
            this.contextMenuStrip1.Text = "BackColor";
            // 
            // toolStripChangeBackColour
            // 
            this.toolStripChangeBackColour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripChangeBackColour.Name = "toolStripChangeBackColour";
            this.toolStripChangeBackColour.Size = new System.Drawing.Size(100, 27);
            this.toolStripChangeBackColour.Text = "BackColor";
            this.toolStripChangeBackColour.ToolTipText = "Change BackColor";
            this.toolStripChangeBackColour.Click += new System.EventHandler(this.toolStripChangeBackColour_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // checkdiscount
            // 
            this.checkdiscount.AutoSize = true;
            this.checkdiscount.Depth = 0;
            this.checkdiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkdiscount.Location = new System.Drawing.Point(25, 389);
            this.checkdiscount.Margin = new System.Windows.Forms.Padding(0);
            this.checkdiscount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkdiscount.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkdiscount.Name = "checkdiscount";
            this.checkdiscount.ReadOnly = false;
            this.checkdiscount.Ripple = true;
            this.checkdiscount.Size = new System.Drawing.Size(98, 37);
            this.checkdiscount.TabIndex = 56;
            this.checkdiscount.Text = "Discount";
            this.checkdiscount.UseVisualStyleBackColor = true;
            // 
            // comboProductCategory
            // 
            this.comboProductCategory.AutoResize = false;
            this.comboProductCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboProductCategory.Depth = 0;
            this.comboProductCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboProductCategory.DropDownHeight = 174;
            this.comboProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProductCategory.DropDownWidth = 121;
            this.comboProductCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboProductCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboProductCategory.FormattingEnabled = true;
            this.comboProductCategory.Hint = "Select Product Category";
            this.comboProductCategory.IntegralHeight = false;
            this.comboProductCategory.ItemHeight = 43;
            this.comboProductCategory.Location = new System.Drawing.Point(7, 143);
            this.comboProductCategory.MaxDropDownItems = 4;
            this.comboProductCategory.MouseState = MaterialSkin.MouseState.OUT;
            this.comboProductCategory.Name = "comboProductCategory";
            this.comboProductCategory.Size = new System.Drawing.Size(431, 49);
            this.comboProductCategory.StartIndex = 0;
            this.comboProductCategory.TabIndex = 57;
            this.comboProductCategory.SelectedIndexChanged += new System.EventHandler(this.comboProductCategory_SelectedIndexChanged);
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.AutoResize = false;
            this.comboBoxProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxProducts.Depth = 0;
            this.comboBoxProducts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxProducts.DropDownHeight = 174;
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.DropDownWidth = 121;
            this.comboBoxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Hint = "Select Product";
            this.comboBoxProducts.IntegralHeight = false;
            this.comboBoxProducts.ItemHeight = 43;
            this.comboBoxProducts.Location = new System.Drawing.Point(12, 217);
            this.comboBoxProducts.MaxDropDownItems = 4;
            this.comboBoxProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(434, 49);
            this.comboBoxProducts.StartIndex = 0;
            this.comboBoxProducts.TabIndex = 58;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // combopaymentmentod
            // 
            this.combopaymentmentod.AutoResize = false;
            this.combopaymentmentod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.combopaymentmentod.Depth = 0;
            this.combopaymentmentod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combopaymentmentod.DropDownHeight = 174;
            this.combopaymentmentod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combopaymentmentod.DropDownWidth = 121;
            this.combopaymentmentod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.combopaymentmentod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combopaymentmentod.FormattingEnabled = true;
            this.combopaymentmentod.Hint = "Select Payment Method";
            this.combopaymentmentod.IntegralHeight = false;
            this.combopaymentmentod.ItemHeight = 43;
            this.combopaymentmentod.Location = new System.Drawing.Point(12, 445);
            this.combopaymentmentod.MaxDropDownItems = 4;
            this.combopaymentmentod.MouseState = MaterialSkin.MouseState.OUT;
            this.combopaymentmentod.Name = "combopaymentmentod";
            this.combopaymentmentod.Size = new System.Drawing.Size(443, 49);
            this.combopaymentmentod.StartIndex = 0;
            this.combopaymentmentod.TabIndex = 59;
            this.combopaymentmentod.SelectedIndexChanged += new System.EventHandler(this.combopaymentmentod_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnAddProduct.Depth = 0;
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProduct.HighEmphasis = true;
            this.btnAddProduct.Icon = null;
            this.btnAddProduct.Location = new System.Drawing.Point(325, 328);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddProduct.Size = new System.Drawing.Size(121, 36);
            this.btnAddProduct.TabIndex = 60;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddProduct.UseAccentColor = false;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AnimateReadOnly = false;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantity.Depth = 0;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.txtQuantity.Hint = "Quantity";
            this.txtQuantity.LeadingIcon = null;
            this.txtQuantity.Location = new System.Drawing.Point(22, 314);
            this.txtQuantity.MaxLength = 50;
            this.txtQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 50);
            this.txtQuantity.TabIndex = 61;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TrailingIcon = null;
            // 
            // dataGridViewSaleDetails
            // 
            this.dataGridViewSaleDetails.AllowUserToAddRows = false;
            this.dataGridViewSaleDetails.AllowUserToResizeRows = false;
            this.dataGridViewSaleDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleDetails.BackgroundColor = Color.White;
            this.dataGridViewSaleDetails.BorderStyle = BorderStyle.None;
            this.dataGridViewSaleDetails.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewSaleDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewSaleDetails.GridColor = Color.FromArgb(224, 224, 224);
            this.dataGridViewSaleDetails.Location = new Point(648, 159);
            this.dataGridViewSaleDetails.Name = "dataGridViewSaleDetails";
            this.dataGridViewSaleDetails.ReadOnly = true;
            this.dataGridViewSaleDetails.RowHeadersVisible = false;
            this.dataGridViewSaleDetails.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSaleDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleDetails.Size = new Size(965, 373);


            // Column Header Style
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.FromArgb(40, 116, 166),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Padding = new Padding(5),
                SelectionBackColor = Color.FromArgb(40, 116, 166),
                SelectionForeColor = Color.White,
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            this.dataGridViewSaleDetails.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dataGridViewSaleDetails.ColumnHeadersHeight = 40;
            this.dataGridViewSaleDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSaleDetails.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            // Default Cell Style
            DataGridViewCellStyle defaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Segoe UI", 10.8F, FontStyle.Regular),
                Padding = new Padding(5),
                SelectionBackColor = Color.FromArgb(229, 241, 251),
                SelectionForeColor = Color.FromArgb(64, 64, 64),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };
            this.dataGridViewSaleDetails.DefaultCellStyle = defaultCellStyle;

            // Alternating Row Style
            this.dataGridViewSaleDetails.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle()
            {
                BackColor = Color.FromArgb(250, 250, 250)
            };

            // Row Template
            this.dataGridViewSaleDetails.RowTemplate.Height = 35;
            this.dataGridViewSaleDetails.RowTemplate.DefaultCellStyle.Padding = new Padding(5);

            // Configure Columns
            this.ProductID.HeaderText = "PRODUCT ID";
            this.ProductID.MinimumWidth = 100;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;

            this.ProductName.HeaderText = "PRODUCT NAME";
            this.ProductName.MinimumWidth = 200;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;

            this.Quantity.HeaderText = "QTY";
            this.Quantity.MinimumWidth = 80;
            this.Quantity.Name = "Quantity";

            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 100;
            this.Price.Name = "Price";


            this.Subtotal.HeaderText = "SUBTOTAL";
            this.Subtotal.MinimumWidth = 120;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;

            this.dataGridViewSaleDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
    this.ProductID,
    this.ProductName,
    this.Quantity,
    this.Price,
    this.Subtotal});

            // Row Style
            this.dataGridViewSaleDetails.RowHeadersVisible = false;
            this.dataGridViewSaleDetails.RowTemplate.Height = 35;
            this.dataGridViewSaleDetails.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);

            // Grid Settings
            this.dataGridViewSaleDetails.Location = new System.Drawing.Point(648, 159);
            this.dataGridViewSaleDetails.Name = "dataGridViewSaleDetails";
            this.dataGridViewSaleDetails.ReadOnly = true;
            this.dataGridViewSaleDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSaleDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleDetails.Size = new System.Drawing.Size(965, 373);
            this.dataGridViewSaleDetails.TabIndex = 6;
            this.dataGridViewSaleDetails.EnableHeadersVisualStyles = false;
            // 
            // txtBarcodeLabel
            // 
            this.txtBarcodeLabel.AcceptsReturn = true;
            this.txtBarcodeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeLabel.Location = new System.Drawing.Point(95, 3);
            this.txtBarcodeLabel.Name = "txtBarcodeLabel";
            this.txtBarcodeLabel.Size = new System.Drawing.Size(331, 34);
            this.txtBarcodeLabel.TabIndex = 62;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox3);
            this.flowLayoutPanel1.Controls.Add(this.txtBarcodeLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 679);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(450, 50);
            this.flowLayoutPanel1.TabIndex = 63;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Miara.Properties.Resources.barcode_scan;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Miara.Properties.Resources.MIARA_POS;
            this.pictureBox2.Location = new System.Drawing.Point(0, 916);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScan.Location = new System.Drawing.Point(9, 661);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(89, 16);
            this.lblScan.TabIndex = 66;
            this.lblScan.Text = "Scan Barcode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportSales
            // 
            this.btnReportSales.BackColor = System.Drawing.Color.IndianRed;
            this.btnReportSales.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnReportSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSales.ForeColor = System.Drawing.Color.Black;
            this.btnReportSales.Location = new System.Drawing.Point(501, 908);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Size = new System.Drawing.Size(142, 86);
            this.btnReportSales.TabIndex = 68;
            this.btnReportSales.Text = "Report";
            this.btnReportSales.UseVisualStyleBackColor = false;
            this.btnReportSales.Click += new System.EventHandler(this.btnReportSales_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.lblBusineess);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblDateTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1871, 111);
            this.panel2.TabIndex = 69;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1793, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 39);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "X";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.panel1.Location = new System.Drawing.Point(0, 1039);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1871, 45);
            this.panel1.TabIndex = 70;
            // 
            // frmSales
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1871, 1084);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReportSales);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblScan);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.combopaymentmentod);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.comboProductCategory);
            this.Controls.Add(this.checkdiscount);
            this.Controls.Add(this.lblCashBack);
            this.Controls.Add(this.btnReprint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOpenCashDrawer);
            this.Controls.Add(this.btnPriceCheck);
            this.Controls.Add(this.btnCupons);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnVoidLine);
            this.Controls.Add(this.txtRecipientEmail);
            this.Controls.Add(this.checkEmail);
            this.Controls.Add(this.txtdiscount);
            this.Controls.Add(this.lbldiscountvalue);
            this.Controls.Add(this.btnCalculatechange);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.txtrenderedamount);
            this.Controls.Add(this.lblrendered);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSubtotalorder);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnCompleteSale);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dataGridViewSaleDetails);
            this.Controls.Add(this.lblNextSalesNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleDetails)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNextSalesNumber;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label lblSubtotalorder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblrendered;
        private System.Windows.Forms.TextBox txtrenderedamount;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Button btnCalculatechange;
        private System.Windows.Forms.Label lbldiscountvalue;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblBusineess;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkEmail;
        private System.Windows.Forms.TextBox txtRecipientEmail;
        private System.Windows.Forms.Button btnVoidLine;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnCupons;
        private System.Windows.Forms.Button btnPriceCheck;
        private System.Windows.Forms.Button btnOpenCashDrawer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReprint;
        private System.Windows.Forms.Label lblCashBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripChangeBackColour;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckbox checkdiscount;
        private MaterialSkin.Controls.MaterialComboBox comboProductCategory;
        private MaterialSkin.Controls.MaterialComboBox comboBoxProducts;
        private MaterialSkin.Controls.MaterialComboBox combopaymentmentod;
        private MaterialSkin.Controls.MaterialButton btnAddProduct;
        private MaterialSkin.Controls.MaterialTextBox txtQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridView dataGridViewSaleDetails;
        private System.Windows.Forms.TextBox txtBarcodeLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportSales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}