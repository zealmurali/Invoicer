namespace Invoicer
{
    partial class frmInvoicer
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.txtHSNCode = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtStateCode = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtGSTIN = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIGST = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.radOldAddr = new System.Windows.Forms.RadioButton();
            this.radNewAddr = new System.Windows.Forms.RadioButton();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTaxAmount = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtLineAmount = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtTotalDiscount = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.dtRefDate = new System.Windows.Forms.DateTimePicker();
            this.Label7 = new System.Windows.Forms.Label();
            this.viewReportButton = new System.Windows.Forms.Button();
            this.txtRefNo = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCStateCode = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtCGSTIN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTINNo = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.dtDCDate = new System.Windows.Forms.DateTimePicker();
            this.dtInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtVendorCode = new System.Windows.Forms.TextBox();
            this.txtDCNo = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblDCNo = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgInvoicer = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoicerDataSet = new Invoicer.InvoicerDataSet();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lineItemTableAdapter = new Invoicer.InvoicerDataSetTableAdapters.LineItemTableAdapter();
            this.clientTableAdapter = new Invoicer.InvoicerDataSetTableAdapters.ClientTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInvoiceList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateNew = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsTableAdapter = new Invoicer.InvoicerDataSetTableAdapters.ProductsTableAdapter();
            this.Panel2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoicer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicerDataSet)).BeginInit();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.txtHSNCode);
            this.Panel2.Controls.Add(this.label21);
            this.Panel2.Controls.Add(this.txtStateCode);
            this.Panel2.Controls.Add(this.label20);
            this.Panel2.Controls.Add(this.txtGSTIN);
            this.Panel2.Controls.Add(this.label19);
            this.Panel2.Controls.Add(this.txtIGST);
            this.Panel2.Controls.Add(this.Label16);
            this.Panel2.Controls.Add(this.radOldAddr);
            this.Panel2.Controls.Add(this.radNewAddr);
            this.Panel2.Controls.Add(this.txtSGST);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.txtDiscount);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.txtTotalAmount);
            this.Panel2.Controls.Add(this.Label10);
            this.Panel2.Controls.Add(this.btnCalculate);
            this.Panel2.Controls.Add(this.txtTaxAmount);
            this.Panel2.Controls.Add(this.Label9);
            this.Panel2.Controls.Add(this.txtLineAmount);
            this.Panel2.Controls.Add(this.Label8);
            this.Panel2.Controls.Add(this.txtCGST);
            this.Panel2.Controls.Add(this.Label12);
            this.Panel2.Controls.Add(this.txtTotalDiscount);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.dtRefDate);
            this.Panel2.Controls.Add(this.Label7);
            this.Panel2.Controls.Add(this.viewReportButton);
            this.Panel2.Controls.Add(this.txtRefNo);
            this.Panel2.Controls.Add(this.Label2);
            this.Panel2.Controls.Add(this.GroupBox1);
            this.Panel2.Controls.Add(this.Label1);
            this.Panel2.Controls.Add(this.dgInvoicer);
            this.Panel2.Controls.Add(this.GroupBox2);
            this.Panel2.Location = new System.Drawing.Point(3, 3);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(875, 534);
            this.Panel2.TabIndex = 2;
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Location = new System.Drawing.Point(85, 455);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Size = new System.Drawing.Size(108, 20);
            this.txtHSNCode.TabIndex = 51;
            this.txtHSNCode.Text = "84511010";
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DimGray;
            this.label21.Location = new System.Drawing.Point(7, 458);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 13);
            this.label21.TabIndex = 52;
            this.label21.Text = "HSN Code:";
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(86, 431);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Size = new System.Drawing.Size(108, 20);
            this.txtStateCode.TabIndex = 49;
            this.txtStateCode.Text = "33";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(8, 434);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "State Code:";
            // 
            // txtGSTIN
            // 
            this.txtGSTIN.Location = new System.Drawing.Point(60, 407);
            this.txtGSTIN.Name = "txtGSTIN";
            this.txtGSTIN.Size = new System.Drawing.Size(134, 20);
            this.txtGSTIN.TabIndex = 47;
            this.txtGSTIN.Text = "33AJKPB8845K1ZY";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.DimGray;
            this.label19.Location = new System.Drawing.Point(8, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "GSTIN:";
            // 
            // txtIGST
            // 
            this.txtIGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGST.Location = new System.Drawing.Point(439, 476);
            this.txtIGST.Name = "txtIGST";
            this.txtIGST.Size = new System.Drawing.Size(141, 20);
            this.txtIGST.TabIndex = 8;
            this.txtIGST.Text = "0";
            this.txtIGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.DimGray;
            this.Label16.Location = new System.Drawing.Point(350, 479);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(84, 13);
            this.Label16.TabIndex = 46;
            this.Label16.Text = "IGST(%)";
            // 
            // radOldAddr
            // 
            this.radOldAddr.AutoSize = true;
            this.radOldAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOldAddr.ForeColor = System.Drawing.Color.DimGray;
            this.radOldAddr.Location = new System.Drawing.Point(461, 505);
            this.radOldAddr.Name = "radOldAddr";
            this.radOldAddr.Size = new System.Drawing.Size(93, 17);
            this.radOldAddr.TabIndex = 14;
            this.radOldAddr.Text = "Old Address";
            this.radOldAddr.UseVisualStyleBackColor = true;
            // 
            // radNewAddr
            // 
            this.radNewAddr.AutoSize = true;
            this.radNewAddr.Checked = true;
            this.radNewAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNewAddr.ForeColor = System.Drawing.Color.DimGray;
            this.radNewAddr.Location = new System.Drawing.Point(353, 505);
            this.radNewAddr.Name = "radNewAddr";
            this.radNewAddr.Size = new System.Drawing.Size(99, 17);
            this.radNewAddr.TabIndex = 13;
            this.radNewAddr.TabStop = true;
            this.radNewAddr.Text = "New Address";
            this.radNewAddr.UseVisualStyleBackColor = true;
            // 
            // txtSGST
            // 
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(439, 451);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(141, 20);
            this.txtSGST.TabIndex = 7;
            this.txtSGST.Text = "0";
            this.txtSGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.DimGray;
            this.Label15.Location = new System.Drawing.Point(351, 454);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(84, 13);
            this.Label15.TabIndex = 42;
            this.Label15.Text = "SGST (%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(439, 403);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(141, 20);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label13
            // 
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.DimGray;
            this.Label13.Location = new System.Drawing.Point(349, 406);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(84, 13);
            this.Label13.TabIndex = 40;
            this.Label13.Text = "Discount (%)";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(723, 473);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(141, 20);
            this.txtTotalAmount.TabIndex = 12;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.DimGray;
            this.Label10.Location = new System.Drawing.Point(602, 476);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(112, 13);
            this.Label10.TabIndex = 38;
            this.Label10.Text = "Total Amount";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(638, 499);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 24);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTaxAmount
            // 
            this.txtTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxAmount.Location = new System.Drawing.Point(723, 449);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(141, 20);
            this.txtTaxAmount.TabIndex = 11;
            this.txtTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.DimGray;
            this.Label9.Location = new System.Drawing.Point(602, 452);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(115, 13);
            this.Label9.TabIndex = 36;
            this.Label9.Text = "Tax Amount";
            // 
            // txtLineAmount
            // 
            this.txtLineAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineAmount.Location = new System.Drawing.Point(723, 403);
            this.txtLineAmount.Name = "txtLineAmount";
            this.txtLineAmount.ReadOnly = true;
            this.txtLineAmount.Size = new System.Drawing.Size(141, 20);
            this.txtLineAmount.TabIndex = 9;
            this.txtLineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label8
            // 
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.DimGray;
            this.Label8.Location = new System.Drawing.Point(602, 406);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(118, 13);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "Total Line Amount";
            // 
            // txtCGST
            // 
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(439, 427);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(141, 20);
            this.txtCGST.TabIndex = 6;
            this.txtCGST.Text = "0";
            this.txtCGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.DimGray;
            this.Label12.Location = new System.Drawing.Point(351, 430);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(84, 13);
            this.Label12.TabIndex = 31;
            this.Label12.Text = "CGST(%)";
            // 
            // txtTotalDiscount
            // 
            this.txtTotalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscount.Location = new System.Drawing.Point(723, 426);
            this.txtTotalDiscount.Name = "txtTotalDiscount";
            this.txtTotalDiscount.ReadOnly = true;
            this.txtTotalDiscount.Size = new System.Drawing.Size(141, 20);
            this.txtTotalDiscount.TabIndex = 10;
            this.txtTotalDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.DimGray;
            this.Label11.Location = new System.Drawing.Point(602, 429);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(87, 13);
            this.Label11.TabIndex = 29;
            this.Label11.Text = "Sub Total";
            // 
            // dtRefDate
            // 
            this.dtRefDate.CustomFormat = "dd/MM/yyyy";
            this.dtRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRefDate.Location = new System.Drawing.Point(724, 149);
            this.dtRefDate.Name = "dtRefDate";
            this.dtRefDate.Size = new System.Drawing.Size(134, 20);
            this.dtRefDate.TabIndex = 3;
            // 
            // Label7
            // 
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.DimGray;
            this.Label7.Location = new System.Drawing.Point(684, 152);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 14;
            this.Label7.Text = "Date";
            // 
            // viewReportButton
            // 
            this.viewReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewReportButton.Location = new System.Drawing.Point(754, 499);
            this.viewReportButton.Name = "viewReportButton";
            this.viewReportButton.Size = new System.Drawing.Size(110, 24);
            this.viewReportButton.TabIndex = 16;
            this.viewReportButton.Text = "Generate Invoice";
            this.viewReportButton.UseVisualStyleBackColor = true;
            this.viewReportButton.Click += new System.EventHandler(this.viewReportButton_Click_1);
            // 
            // txtRefNo
            // 
            this.txtRefNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Location = new System.Drawing.Point(130, 148);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Size = new System.Drawing.Size(544, 20);
            this.txtRefNo.TabIndex = 2;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(8, 151);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(116, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Ref/Your Order No";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtCStateCode);
            this.GroupBox1.Controls.Add(this.label18);
            this.GroupBox1.Controls.Add(this.txtCGSTIN);
            this.GroupBox1.Controls.Add(this.label17);
            this.GroupBox1.Controls.Add(this.txtTINNo);
            this.GroupBox1.Controls.Add(this.Label14);
            this.GroupBox1.Controls.Add(this.dtDCDate);
            this.GroupBox1.Controls.Add(this.dtInvoiceDate);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtVendorCode);
            this.GroupBox1.Controls.Add(this.txtDCNo);
            this.GroupBox1.Controls.Add(this.txtInvoiceNo);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.lblDCNo);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Location = new System.Drawing.Point(438, 5);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(428, 134);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // txtCStateCode
            // 
            this.txtCStateCode.Location = new System.Drawing.Point(345, 107);
            this.txtCStateCode.Name = "txtCStateCode";
            this.txtCStateCode.Size = new System.Drawing.Size(75, 20);
            this.txtCStateCode.TabIndex = 13;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.DimGray;
            this.label18.Location = new System.Drawing.Point(246, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "State Code:";
            // 
            // txtCGSTIN
            // 
            this.txtCGSTIN.Location = new System.Drawing.Point(103, 107);
            this.txtCGSTIN.Name = "txtCGSTIN";
            this.txtCGSTIN.Size = new System.Drawing.Size(134, 20);
            this.txtCGSTIN.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DimGray;
            this.label17.Location = new System.Drawing.Point(4, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "GSTIN:";
            // 
            // txtTINNo
            // 
            this.txtTINNo.Location = new System.Drawing.Point(103, 83);
            this.txtTINNo.Name = "txtTINNo";
            this.txtTINNo.Size = new System.Drawing.Size(316, 20);
            this.txtTINNo.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.DimGray;
            this.Label14.Location = new System.Drawing.Point(2, 86);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(101, 13);
            this.Label14.TabIndex = 10;
            this.Label14.Text = "TIN No. ";
            // 
            // dtDCDate
            // 
            this.dtDCDate.CustomFormat = "dd/MM/yyyy";
            this.dtDCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDCDate.Location = new System.Drawing.Point(285, 37);
            this.dtDCDate.Name = "dtDCDate";
            this.dtDCDate.Size = new System.Drawing.Size(134, 20);
            this.dtDCDate.TabIndex = 3;
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.CustomFormat = "dd/MM/yyyy";
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInvoiceDate.Location = new System.Drawing.Point(285, 13);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(134, 20);
            this.dtInvoiceDate.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.DimGray;
            this.Label6.Location = new System.Drawing.Point(243, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(52, 13);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Date";
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(243, 41);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(52, 13);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Date";
            // 
            // txtVendorCode
            // 
            this.txtVendorCode.Location = new System.Drawing.Point(103, 60);
            this.txtVendorCode.Name = "txtVendorCode";
            this.txtVendorCode.Size = new System.Drawing.Size(316, 20);
            this.txtVendorCode.TabIndex = 4;
            // 
            // txtDCNo
            // 
            this.txtDCNo.Location = new System.Drawing.Point(103, 36);
            this.txtDCNo.Name = "txtDCNo";
            this.txtDCNo.Size = new System.Drawing.Size(134, 20);
            this.txtDCNo.TabIndex = 2;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(103, 13);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(134, 20);
            this.txtInvoiceNo.TabIndex = 0;
            // 
            // Label4
            // 
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(2, 63);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(101, 13);
            this.Label4.TabIndex = 8;
            this.Label4.Text = "VENDOR CODE:";
            // 
            // lblDCNo
            // 
            this.lblDCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDCNo.ForeColor = System.Drawing.Color.DimGray;
            this.lblDCNo.Location = new System.Drawing.Point(4, 39);
            this.lblDCNo.Name = "lblDCNo";
            this.lblDCNo.Size = new System.Drawing.Size(90, 13);
            this.lblDCNo.TabIndex = 4;
            this.lblDCNo.Text = "D.C.No.";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(3, 16);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Invoice No.";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DimGray;
            this.Label1.Location = new System.Drawing.Point(9, 170);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(90, 18);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "Line items:";
            // 
            // dgInvoicer
            // 
            this.dgInvoicer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvoicer.AutoGenerateColumns = false;
            this.dgInvoicer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgInvoicer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoicer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {            
            this.invoiceIDDataGridViewTextBoxColumn,
            this.SNo,
            this.Product,
            this.Quantity,
            this.UnitPrice});
            this.dgInvoicer.DataSource = this.lineItemBindingSource;
            this.dgInvoicer.Location = new System.Drawing.Point(9, 190);
            this.dgInvoicer.Name = "dgInvoicer";
            this.dgInvoicer.Size = new System.Drawing.Size(857, 207);
            this.dgInvoicer.TabIndex = 4;
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.FillWeight = 1F;
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "InvoiceID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.FillWeight = 3F;
            this.SNo.HeaderText = "S.No";
            this.SNo.Name = "SNo";
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.FillWeight = 40F;
            this.Product.HeaderText = "PARTICULARS";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 7.614212F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.FillWeight = 7.614212F;
            this.UnitPrice.HeaderText = "Rate";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // lineItemBindingSource
            // 
            this.lineItemBindingSource.DataMember = "LineItem";
            this.lineItemBindingSource.DataSource = this.invoicerDataSetBindingSource;
            // 
            // invoicerDataSetBindingSource
            // 
            this.invoicerDataSetBindingSource.DataSource = this.invoicerDataSet;
            this.invoicerDataSetBindingSource.Position = 0;
            // 
            // invoicerDataSet
            // 
            this.invoicerDataSet.DataSetName = "InvoicerDataSet";
            this.invoicerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.linkLabel2);
            this.GroupBox2.Controls.Add(this.linkLabel1);
            this.GroupBox2.Controls.Add(this.cmbClient);
            this.GroupBox2.Controls.Add(this.CityTextBox);
            this.GroupBox2.Controls.Add(this.NameLabel);
            this.GroupBox2.Controls.Add(this.AddressTextBox);
            this.GroupBox2.Controls.Add(this.ZipLabel);
            this.GroupBox2.Controls.Add(this.AddressLabel);
            this.GroupBox2.Controls.Add(this.ZipTextBox);
            this.GroupBox2.Controls.Add(this.CityLabel);
            this.GroupBox2.Controls.Add(this.StateLabel);
            this.GroupBox2.Controls.Add(this.StateTextBox);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.GroupBox2.Location = new System.Drawing.Point(10, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(421, 136);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Bill To";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel2.Location = new System.Drawing.Point(384, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Edit";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.Location = new System.Drawing.Point(353, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // cmbClient
            // 
            this.cmbClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbClient.DataSource = this.clientBindingSource;
            this.cmbClient.DisplayMember = "ClientName";
            this.cmbClient.DropDownHeight = 120;
            this.cmbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.IntegralHeight = false;
            this.cmbClient.Location = new System.Drawing.Point(109, 17);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(241, 21);
            this.cmbClient.TabIndex = 1;
            this.cmbClient.ValueMember = "ClientID";
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.cmbClient_SelectedIndexChanged);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.invoicerDataSet;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityTextBox.Location = new System.Drawing.Point(107, 70);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.ReadOnly = true;
            this.CityTextBox.Size = new System.Drawing.Size(204, 20);
            this.CityTextBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(7, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(99, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Customer Name:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTextBox.Location = new System.Drawing.Point(107, 44);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.ReadOnly = true;
            this.AddressTextBox.Size = new System.Drawing.Size(303, 20);
            this.AddressTextBox.TabIndex = 4;
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipLabel.Location = new System.Drawing.Point(177, 100);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(29, 13);
            this.ZipLabel.TabIndex = 9;
            this.ZipLabel.Text = "Zip:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(7, 47);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(99, 13);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address:";
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZipTextBox.Location = new System.Drawing.Point(218, 96);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.ReadOnly = true;
            this.ZipTextBox.Size = new System.Drawing.Size(92, 20);
            this.ZipTextBox.TabIndex = 7;
            // 
            // CityLabel
            // 
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(7, 73);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(99, 13);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City:";
            // 
            // StateLabel
            // 
            this.StateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLabel.Location = new System.Drawing.Point(7, 99);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(99, 13);
            this.StateLabel.TabIndex = 7;
            this.StateLabel.Text = "State:";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateTextBox.Location = new System.Drawing.Point(107, 96);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.ReadOnly = true;
            this.StateTextBox.Size = new System.Drawing.Size(61, 20);
            this.StateTextBox.TabIndex = 6;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Products";
            this.productBindingSource.DataSource = this.invoicerDataSet;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(this.Panel2, 0, 0);
            this.TableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(-1, 25);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(881, 538);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // lineItemTableAdapter
            // 
            this.lineItemTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCreateNew,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInvoiceList,
            this.mnuClientList});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuInvoiceList
            // 
            this.mnuInvoiceList.Name = "mnuInvoiceList";
            this.mnuInvoiceList.Size = new System.Drawing.Size(133, 22);
            this.mnuInvoiceList.Text = "Invoice List";
            this.mnuInvoiceList.Click += new System.EventHandler(this.invoiceListToolStripMenuItem_Click);
            // 
            // mnuClientList
            // 
            this.mnuClientList.Name = "mnuClientList";
            this.mnuClientList.Size = new System.Drawing.Size(133, 22);
            this.mnuClientList.Text = "Client List";
            this.mnuClientList.Click += new System.EventHandler(this.clientListToolStripMenuItem_Click);
            // 
            // mnuCreateNew
            // 
            this.mnuCreateNew.Name = "mnuCreateNew";
            this.mnuCreateNew.Size = new System.Drawing.Size(80, 20);
            this.mnuCreateNew.Text = "Create New";
            this.mnuCreateNew.Click += new System.EventHandler(this.mnuCreateNew_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // frmInvoicer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(880, 563);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmInvoicer";
            this.Text = "Invoicer Generator";
            this.Load += new System.EventHandler(this.frmInvoicer_Load);
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoicer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicerDataSet)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.TextBox txtIGST;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.RadioButton radOldAddr;
        internal System.Windows.Forms.RadioButton radNewAddr;
        internal System.Windows.Forms.TextBox txtSGST;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtDiscount;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.TextBox txtTaxAmount;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtLineAmount;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox txtCGST;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtTotalDiscount;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.DateTimePicker dtRefDate;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button viewReportButton;
        internal System.Windows.Forms.TextBox txtRefNo;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox CityTextBox;
        internal System.Windows.Forms.Label NameLabel;
        internal System.Windows.Forms.TextBox AddressTextBox;
        internal System.Windows.Forms.Label ZipLabel;
        internal System.Windows.Forms.Label AddressLabel;
        internal System.Windows.Forms.TextBox ZipTextBox;
        internal System.Windows.Forms.Label CityLabel;
        internal System.Windows.Forms.Label StateLabel;
        internal System.Windows.Forms.TextBox StateTextBox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtTINNo;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.DateTimePicker dtDCDate;
        internal System.Windows.Forms.DateTimePicker dtInvoiceDate;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtVendorCode;
        internal System.Windows.Forms.TextBox txtDCNo;
        internal System.Windows.Forms.TextBox txtInvoiceNo;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblDCNo;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgInvoicer;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private InvoicerDataSet invoicerDataSet;
        private System.Windows.Forms.BindingSource invoicerDataSetBindingSource;
        private System.Windows.Forms.BindingSource lineItemBindingSource;
        private InvoicerDataSetTableAdapters.LineItemTableAdapter lineItemTableAdapter;
        private InvoicerDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuInvoiceList;
        private System.Windows.Forms.ToolStripMenuItem mnuClientList;
        private InvoicerDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        internal System.Windows.Forms.TextBox txtCStateCode;
        internal System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtCGSTIN;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtStateCode;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.TextBox txtGSTIN;
        internal System.Windows.Forms.Label label19;
        internal System.Windows.Forms.TextBox txtHSNCode;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
    }
}