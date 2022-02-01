using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class frmInvoicer : Form
    {
        public string strClientName = "";
        private int intInvoiceID;

        public frmInvoicer()
        {
            InitializeComponent();
        }

        public frmInvoicer(int intInvoiceID)
        {
            // TODO: Complete member initialization
            this.intInvoiceID = intInvoiceID;
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int intTotalRowCount = 0;
                int intRowCount = 0;
                double TotalAmount = 0.0;
                double dblDiscount = 0.0;
                double TotalDiscountAmount = 0.0;
                double dblTaxAmount = 0.0;
                double dblTaxVAlue = 0.0;
                double dblTotalAmount = 0.0;
                double dblCGSTAmount = 0.0; double dblSGSTAmount = 0.0; double dblIGSTAmount = 0.0;
                intTotalRowCount = dgInvoicer.Rows.Count - 1;
                if (dgInvoicer.Rows.Count > 0)
                {
                    for (intRowCount = 0; intRowCount <= intTotalRowCount; intRowCount++)
                    {
                        if ((dgInvoicer.Rows[intRowCount].Cells[4].Value != null) && (dgInvoicer.Rows[intRowCount].Cells[5].Value != null))
                        {
                            if (!(string.IsNullOrEmpty(dgInvoicer.Rows[intRowCount].Cells[4].Value.ToString())) && !(string.IsNullOrEmpty(dgInvoicer.Rows[intRowCount].Cells[5].Value.ToString())))
                            {
                                TotalAmount = TotalAmount + ((Convert.ToDouble(dgInvoicer.Rows[intRowCount].Cells[4].Value)) * (Convert.ToDouble(dgInvoicer.Rows[intRowCount].Cells[5].Value)));
                            }
                        }
                    }
                    txtLineAmount.Text = TotalAmount.ToString();
                    if (!(string.IsNullOrEmpty(txtDiscount.Text.ToString())) && Convert.ToDouble(txtDiscount.Text.ToString()) > 0)
                    {
                        dblDiscount = TotalAmount * (Convert.ToDouble(txtDiscount.Text.ToString()) / 100);
                    }
                    TotalDiscountAmount = TotalAmount - dblDiscount;
                    txtTotalDiscount.Text = TotalDiscountAmount.ToString();

                    if (!(string.IsNullOrEmpty(txtCGST.Text.ToString())) && Convert.ToDouble(txtCGST.Text.ToString()) > 0)
                    {
                        dblTaxVAlue = Convert.ToDouble(txtCGST.Text.ToString()) / 100;
                        dblCGSTAmount = TotalDiscountAmount * dblTaxVAlue;
                    }

                    if (!(string.IsNullOrEmpty(txtSGST.Text.ToString())) && Convert.ToDouble(txtSGST.Text.ToString()) > 0)
                    {
                        dblTaxVAlue = Convert.ToDouble(txtSGST.Text.ToString()) / 100;
                        dblSGSTAmount = TotalDiscountAmount * dblTaxVAlue;
                    }

                    if (!(string.IsNullOrEmpty(txtIGST.Text.ToString())) && Convert.ToDouble(txtIGST.Text.ToString()) > 0)
                    {
                        dblTaxVAlue = Convert.ToDouble(txtIGST.Text.ToString()) / 100;
                        dblIGSTAmount = TotalDiscountAmount * dblTaxVAlue;
                    }
                    dblTaxAmount = dblCGSTAmount + dblSGSTAmount + dblIGSTAmount;
                    txtTaxAmount.Text = dblTaxAmount.ToString();

                    dblTotalAmount = TotalDiscountAmount + dblTaxAmount;
                    txtTotalAmount.Text = dblTotalAmount.ToString();
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        private void viewReportButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbClient.SelectedValue != null && cmbClient.SelectedIndex > 0)
                {
                    int intInvoiceID = UpdateInvoice();
                    if (intInvoiceID > 0)
                    {
                        if (txtInvoiceNo.Text != "")
                        {
                            string strClient = ((InvoicerDataSet.ClientRow)((DataRowView)cmbClient.SelectedItem).Row).ClientName;
                            if (ReportHelper.GeneratePDFReport(Convert.ToInt32(txtInvoiceID.Text), strClient))
                            {
                                //DisplayData(Convert.ToInt32(txtInvoiceNo.Text));
                                InitInvoiceForm();
                                MessageBox.Show(this, "Invoice has been generated successfully", "Invoicer");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select Customer Name");
                    cmbClient.Focus();
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        public int UpdateInvoice()
        {
            DateTime InvoiceDate = DateTime.Now;
            DateTime? OrderDate = null;
            DateTime? DCNoDate = null;
            int intInvoiceID = 0;
            int intInvoiceNo = 0;
            bool blnEditFlag = false;
            try
            {
                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();

                intInvoiceID = this.txtDiscount.Text != "" ? Convert.ToInt32(this.txtInvoiceID.Text) : 0;

                DataTable dtInvoice = objInvoice.GetDataByID(intInvoiceID);

                if (dtInvoice.Rows.Count > 0)
                {
                    blnEditFlag = true;
                }
                intInvoiceNo = Convert.ToInt32(this.txtInvoiceNo.Text);
                int intClientID = Convert.ToInt32(cmbClient.SelectedValue); //Convert.ToInt32(txtClientID.Text);
                if (this.dtInvoiceDate.Text != "")
                {
                    dtInvoiceDate.CustomFormat = "MM/dd/yyyy";
                    InvoiceDate = Convert.ToDateTime(dtInvoiceDate.Text);
                    dtInvoiceDate.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    dtInvoiceDate.Invalidate(false);
                }
                if (this.dtRefDate.Text != "")
                {
                    dtRefDate.CustomFormat = "MM/dd/yyyy";
                    OrderDate = Convert.ToDateTime(dtRefDate.Text);
                    dtRefDate.CustomFormat = "dd/MM/yyyy";
                }

                if (this.dtDCDate.Text != "")
                {
                    dtDCDate.CustomFormat = "MM/dd/yyyy";
                    DCNoDate = Convert.ToDateTime(dtDCDate.Text);
                    dtDCDate.CustomFormat = "dd/MM/yyyy";
                }
                double? Discount = this.txtDiscount.Text != "" ? Convert.ToDouble(txtDiscount.Text) : 0;
                double? CGST = this.txtCGST.Text != "" ? Convert.ToDouble(txtCGST.Text) : 0;
                double? SGST = this.txtSGST.Text != "" ? Convert.ToDouble(txtSGST.Text) : 0;
                double? IGST = this.txtIGST.Text != "" ? Convert.ToDouble(txtIGST.Text) : 0;
                decimal? LineAmount = this.txtLineAmount.Text != "" ? Convert.ToDecimal(txtLineAmount.Text) : 0;
                decimal? SubTotal = this.txtTotalDiscount.Text != "" ? Convert.ToDecimal(txtTotalDiscount.Text) : 0;

                decimal? TaxAmount = this.txtTaxAmount.Text != "" ? Convert.ToDecimal(txtTaxAmount.Text) : 0;

                decimal? TotalAmount = this.txtTotalAmount.Text != "" ? Convert.ToDecimal(txtTotalAmount.Text) : 0;

                string OrderNo = this.txtRefNo.Text != "" ? txtRefNo.Text : null;

                bool AddressFlag = this.radNewAddr.Checked ? true : false;
                
                string HSNCode = this.txtHSNCode.Text != "" ? this.txtHSNCode.Text : null;
                string GSTIN = this.txtGSTIN.Text != "" ? this.txtGSTIN.Text : null;
                string StateCode = this.txtStateCode.Text != "" ? this.txtStateCode.Text : null;
                string DCNo = this.txtDCNo.Text != "" ? this.txtDCNo.Text : null;

                InvoicerDataSetTableAdapters.LineItemTableAdapter objData = new InvoicerDataSetTableAdapters.LineItemTableAdapter();
                DataTable dtLineItem = null;
                if (blnEditFlag)
                {
                    objData.DeleteLineItem(intInvoiceID);
                }

                dtLineItem = (DataTable)((DataView)lineItemBindingSource.List).Table;

                if (!(dtLineItem.HasErrors))
                {
                    if (dtLineItem.Rows.Count > 0)
                    {
                        foreach (DataRow item in dtLineItem.Rows)
                        {
                            objData.Insert(intInvoiceID, Convert.ToInt32(item["SNo"]), item["Product"].ToString(), item["HSNCode"].ToString(), Convert.ToDecimal(item["UnitPrice"].ToString()), Convert.ToInt16(item["Quantity"].ToString()));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Invoice Item.");
                        return 0;
                    }
                }
                if (blnEditFlag)
                {
                    objInvoice.UpdateInvoice(intInvoiceNo,intClientID, InvoiceDate, Decimal.Parse(Discount.ToString()), Decimal.Parse(CGST.ToString()), Decimal.Parse(SGST.ToString()), Decimal.Parse(IGST.ToString()), 0,
                    LineAmount, SubTotal, TotalAmount, TaxAmount, AddressFlag, null, OrderNo, DCNoDate,
                    OrderDate, GSTIN, StateCode, DCNo, intInvoiceID);
                    return intInvoiceID;
                }
                else
                {
                    return objInvoice.Insert(intInvoiceNo,intClientID, InvoiceDate, Discount, CGST, SGST, IGST, 0,
                    LineAmount, SubTotal, TotalAmount, TaxAmount, AddressFlag, null, OrderNo, DCNoDate,
                    OrderDate, GSTIN, StateCode, DCNo);
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
                return 0;
            }
        }

        private void frmInvoicer_Load(object sender, EventArgs e)
        {
            
            try
            {
                InitInvoiceForm();
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        public void InitInvoiceForm()
        {
            try
            {
                // TODO: This line of code loads data into the 'invoicerDataSet.Client' table. You can move, or remove it, as needed.
                //this.clientTableAdapter.Fill(this.invoicerDataSet.Client);

                InvoicerDataSetTableAdapters.ClientTableAdapter objCustomer = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                this.clientBindingSource.DataSource = objCustomer.GetDataForCombo();

                //InvoicerDataSetTableAdapters.ProductsTableAdapter objProduct = new InvoicerDataSetTableAdapters.ProductsTableAdapter();

                //this.productBindingSource.DataSource = objProduct.GetData();

                if (intInvoiceID > 0)
                {
                    DisplayData(intInvoiceID);
                }
                else
                {
                    InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();
                    DataTable dtNextInvoiceData = objInvoice.GetNextInvoiceID();
                    if (dtNextInvoiceData != null)
                    {
                        txtInvoiceNo.Text = dtNextInvoiceData.Rows[0]["InvoiceNo"].ToString().PadLeft(3, '0');
                        txtInvoiceID.Text = dtNextInvoiceData.Rows[0]["InvoiceID"].ToString();
                        DisplayData(0);
                    }
                    else
                    {
                        txtInvoiceNo.Text = "001";
                        txtInvoiceID.Text = "1";
                    }
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        public void DisplayData(int intInvoiceID)
        {
            DataSet dsInvoicer = null;
            try
            {
                //InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();
                InvoicerDataSetTableAdapters.LineItemTableAdapter objLineItem = new InvoicerDataSetTableAdapters.LineItemTableAdapter();
                dsInvoicer = new DataSet();
                DataTable dtInvoice = objInvoice.GetDataByID(intInvoiceID);
                if (dtInvoice.Rows.Count > 0)
                {
                    foreach (DataRow drInvoice in dtInvoice.Rows)
                    {
                        //SELECT AddressFlag, CGST, ClientID, DCNoDate, Discount, Freight, GSTIN, IGST, InvoiceDate, 
                        //InvoiceID, InvoicePath, LineAmount, OrderDate, OrderNo, SGST, StateCode, 
                        //SubTotal, TaxAmount, TotalAmount FROM Invoice WHERE (InvoiceID = ?)
                        cmbClient.SelectedValue = drInvoice["ClientID"].ToString();
                        txtInvoiceID.Text = drInvoice["InvoiceID"].ToString();
                        txtInvoiceNo.Text = drInvoice["InvoiceNo"].ToString().PadLeft(3, '0');
                        dtInvoiceDate.Text = drInvoice["InvoiceDate"].ToString();
                        dtDCDate.Text = drInvoice["DCNoDate"].ToString();
                        dtRefDate.Text = drInvoice["OrderDate"].ToString();
                        txtRefNo.Text = drInvoice["OrderNo"].ToString();
                        txtCGST.Text = drInvoice["CGST"].ToString();
                        txtSGST.Text = drInvoice["SGST"].ToString();
                        txtIGST.Text = drInvoice["IGST"].ToString();
                        txtDiscount.Text = drInvoice["Discount"].ToString();
                        txtGSTIN.Text = drInvoice["GSTIN"].ToString();
                        txtStateCode.Text = drInvoice["StateCode"].ToString();
                        radOldAddr.Checked = drInvoice["AddressFlag"].ToString() == "True" ? false : true;
                        txtTaxAmount.Text = drInvoice["TaxAmount"].ToString();
                        txtLineAmount.Text = drInvoice["LineAmount"].ToString();
                        txtTotalDiscount.Text = drInvoice["SubTotal"].ToString();
                        txtTotalAmount.Text = drInvoice["TotalAmount"].ToString();

                        
                        DataTable dtLineItem = objLineItem.GetDataByID(intInvoiceID);
                        lineItemBindingSource.DataSource = dtLineItem.AsDataView();
                        if (dtLineItem.Rows.Count > 0)
                        {
                            txtHSNCode.Text = dtLineItem.Rows[0]["HSNCode"].ToString();
                        }
                        else
                        {
                            txtHSNCode.Text = ConfigurationManager.AppSettings["HSNCODE"].ToString();
                        }
                        dgInvoicer.DataSource = lineItemBindingSource;
                        dgInvoicer.Refresh();
                    }
                }
                else
                {
                    cmbClient.SelectedValue = 0;
                    //txtInvoiceNo.Text = drInvoice["InvoiceID"].ToString().PadLeft(3, '0');
                    dtInvoiceDate.Text = DateTime.Now.ToShortDateString();
                    dtDCDate.Text = DateTime.Now.ToShortDateString();
                    dtRefDate.Text = DateTime.Now.ToShortDateString();
                    txtRefNo.Text = "";
                    txtCGST.Text = "0";
                    txtSGST.Text = "0";
                    txtIGST.Text = "0";
                    txtDiscount.Text = "0";
                    txtGSTIN.Text = ConfigurationManager.AppSettings["GSTIN"].ToString();
                    txtStateCode.Text = ConfigurationManager.AppSettings["STATECODE"].ToString();
                    txtHSNCode.Text = ConfigurationManager.AppSettings["HSNCODE"].ToString();
                    radOldAddr.Checked = false;
                    txtTaxAmount.Text = "0";
                    txtLineAmount.Text = "0";
                    txtTotalDiscount.Text = "0";
                    txtTotalAmount.Text = "0";

                    //DataTable dtLineItem = objLineItem.GetDataByID(0);
                    lineItemBindingSource.DataSource = objLineItem.GetDataByID(0).AsDataView();
                    dgInvoicer.DataSource = lineItemBindingSource;
                    dgInvoicer.Refresh();
                    //this.invoicerDataSetBindingSource = objLineItem.GetDataByID(0);
                    //BindingSource DT = (BindingSource)lineItemBindingSource.DataSource;
                    //if (DT != null)
                    //    ((DataView)DT.List).Clear();
                    //this.lineItemBindingSource = this.invoicerDataSetBindingSource;
                    //this.lineItemBindingSource.DataMember = "LineItem";
                   
                    //dgInvoicer.Update();
                }
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
        }

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();
                if (cmbClient.SelectedValue != null && cmbClient.SelectedIndex > 0)
                {
                    DataTable dtClient = objClient.GetDataByID(Convert.ToInt32(cmbClient.SelectedValue));

                    if (dtClient.Rows.Count > 0)
                    {
                        AddressTextBox.Text = dtClient.Rows[0]["Address"].ToString();
                        CityTextBox.Text = dtClient.Rows[0]["City"].ToString();
                        StateTextBox.Text = dtClient.Rows[0]["State"].ToString();
                        ZipTextBox.Text = dtClient.Rows[0]["Zip"].ToString();
                        txtTINNo.Text = dtClient.Rows[0]["TINNO"].ToString();
                        txtVendorCode.Text = dtClient.Rows[0]["VendorCode"].ToString();
                        txtDCNo.Text = dtClient.Rows[0]["DCNO"].ToString();
                        txtCGSTIN.Text = dtClient.Rows[0]["GSTIN"].ToString();
                        txtCStateCode.Text = dtClient.Rows[0]["StateCode"].ToString();
                    }
                    else
                    {
                        AddressTextBox.Text = "";
                        CityTextBox.Text = "";
                        StateTextBox.Text = "";
                        ZipTextBox.Text = "";
                        txtTINNo.Text = "";
                        txtVendorCode.Text = "";
                        txtDCNo.Text = "";
                        txtCGSTIN.Text = "";
                        txtCStateCode.Text = "";
                    }
                }
                else
                {
                    AddressTextBox.Text = "";
                    CityTextBox.Text = "";
                    StateTextBox.Text = "";
                    ZipTextBox.Text = "";
                    txtTINNo.Text = "";
                    txtVendorCode.Text = "";
                    txtDCNo.Text = "";
                    txtCGSTIN.Text = "";
                    txtCStateCode.Text = "";
                }
            }

            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo.Text != "")
                {
                    if (ReportHelper.GeneratePDFReport(Convert.ToInt32(txtInvoiceID.Text), cmbClient.SelectedText.ToString()))
                    {
                        MessageBox.Show(this, "Invoice has been printed successfully", "Invoicer");
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                frmClientEdit objClientEdit = new frmClientEdit();
                objClientEdit.ShowDialog(this);

                string strClient = objClientEdit.NameTextBox.Text.ToString();
                if (strClient != "")
                {
                    InvoicerDataSetTableAdapters.ClientTableAdapter objCustomer = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                    this.clientBindingSource.DataSource = objCustomer.GetDataForCombo();

                    int intIndex = this.clientBindingSource.Find("ClientName", strClient);

                    cmbClient.SelectedIndex = intIndex;
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (cmbClient.SelectedValue != null && cmbClient.SelectedIndex > 0)
                {
                    frmClientEdit objClientEdit = new frmClientEdit(cmbClient.SelectedValue.ToString());
                    objClientEdit.ShowDialog(this);

                    string strClient = objClientEdit.NameTextBox.Text.ToString();
                    if (strClient != "")
                    {
                        InvoicerDataSetTableAdapters.ClientTableAdapter objCustomer = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                        this.clientBindingSource.DataSource = objCustomer.GetDataForCombo();

                        int intIndex = this.clientBindingSource.Find("ClientName", strClient);
                        cmbClient.SelectedIndex = 0;
                        cmbClient.SelectedIndex = intIndex;
                    }
                }
                else
                {
                    MessageBox.Show("Please select Customer");
                    cmbClient.Focus();
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
            }
        }

        private void invoiceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoiceList objInvList = new frmInvoiceList();
                objInvList.ShowDialog(this);
            }
            catch (Exception exclocal)
            {
                MessageBox.Show(exclocal.Message);
            }
        }

        private void clientListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmClient objClient = new frmClient();
                objClient.ShowDialog(this);
            }
            catch (Exception exclocal)
            {
                MessageBox.Show(exclocal.Message);
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtInvoiceNo.Text != "")
                {
                   // string strClient = ((InvoicerDataSet.ClientRow)((DataRowView)cmbClient.SelectedItem).Row).ClientName;
                    if (ReportHelper.GeneratePDFReport(Convert.ToInt32(txtInvoiceID.Text), cmbClient.SelectedText.ToString()))
                    {
                        MessageBox.Show(this, "Invoice has been printed successfully", "Invoicer");
                    }
                }
            }
            catch (Exception exclocal)
            {
                MessageBox.Show(exclocal.Message);
            }
        }

        private void mnuCreateNew_Click(object sender, EventArgs e)
        {
            try
            {
                intInvoiceID = 0;
                InitInvoiceForm();

            }
            catch (Exception exclocal)
            {
                MessageBox.Show(exclocal.Message);
            }
        }

        private void dgInvoicer_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //this.dgInvoicer.Rows[e.RowIndex].Cells[4].Value = "123";
        }
    }
}