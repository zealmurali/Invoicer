using System;
using System.Data;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class frmInvoicer : Form
    {
        public string strClientName = "";
        private int intInvoiceNo;

        public frmInvoicer()
        {
            InitializeComponent();
        }

        public frmInvoicer(int intInvoiceNo)
        {
            // TODO: Complete member initialization
            this.intInvoiceNo = intInvoiceNo;
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
                        if ((dgInvoicer.Rows[intRowCount].Cells[3].Value != null) && (dgInvoicer.Rows[intRowCount].Cells[4].Value != null))
                        {
                            if (!(string.IsNullOrEmpty(dgInvoicer.Rows[intRowCount].Cells[3].Value.ToString())) && !(string.IsNullOrEmpty(dgInvoicer.Rows[intRowCount].Cells[4].Value.ToString())))
                            {
                                TotalAmount = TotalAmount + ((Convert.ToDouble(dgInvoicer.Rows[intRowCount].Cells[3].Value)) * (Convert.ToDouble(dgInvoicer.Rows[intRowCount].Cells[4].Value)));
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
                throw excLocal;
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
                            if (ReportHelper.GeneratePDFReport(Convert.ToInt32(txtInvoiceNo.Text), cmbClient.SelectedText.ToString()))
                            {
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
                throw excLocal;
            }
        }

        public int UpdateInvoice()
        {
            DateTime InvoiceDate = DateTime.Now;
            DateTime? OrderDate = null;
            DateTime? DCNoDate = null;
            int intInvoiceID = 0;
            try
            {
                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();

                intInvoiceID = Convert.ToInt32(this.txtInvoiceNo.Text);

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
                    OrderDate = Convert.ToDateTime(dtRefDate.Text);
                }

                if (this.dtDCDate.Text != "")
                {
                    DCNoDate = Convert.ToDateTime(dtDCDate.Text);
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

                InvoicerDataSetTableAdapters.LineItemTableAdapter objData = new InvoicerDataSetTableAdapters.LineItemTableAdapter();

                DataTable dtLineItem = (DataTable)((DataView)lineItemBindingSource.List).Table;

                if (!(dtLineItem.HasErrors))
                {
                    if (dtLineItem.Rows.Count > 0)
                    {
                        foreach (DataRow item in dtLineItem.Rows)
                        {
                            objData.Insert(intInvoiceID, Convert.ToInt32(item["SNo"]), item["Product"].ToString(), HSNCode, Convert.ToDecimal(item["UnitPrice"].ToString()), Convert.ToInt16(item["Quantity"].ToString()));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter Invoice Item.");
                        return 0;
                    }
                }

                return objInvoice.Insert(intClientID, InvoiceDate, Discount, CGST, SGST, IGST, null, LineAmount, SubTotal, TaxAmount, TotalAmount, AddressFlag, null, OrderNo, DCNoDate, OrderDate, GSTIN, StateCode);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void frmInvoicer_Load(object sender, EventArgs e)
        {
            
            try
            {
                // TODO: This line of code loads data into the 'invoicerDataSet.Client' table. You can move, or remove it, as needed.
                //this.clientTableAdapter.Fill(this.invoicerDataSet.Client);

                InvoicerDataSetTableAdapters.ClientTableAdapter objCustomer = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                this.clientBindingSource.DataSource = objCustomer.GetDataForCombo();

                InvoicerDataSetTableAdapters.ProductsTableAdapter objProduct = new InvoicerDataSetTableAdapters.ProductsTableAdapter();

                this.productBindingSource.DataSource = objProduct.GetData();

                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();
                if (intInvoiceNo > 0)
                {
                    DisplayData(intInvoiceNo);
                }
                else
                {
                    txtInvoiceNo.Text = objInvoice.GetNextInvoiceID().ToString();
                }

                // TODO: This line of code loads data into the 'invoicerDataSet.LineItem' table. You can move, or remove it, as needed.
                //this.lineItemTableAdapter.Fill(this.invoicerDataSet.LineItem);
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
                throw excLocal;
            }
        }

        public void DisplayData(int intInvoiceNo)
        {
            DataSet dsInvoicer = null;
            try
            {
                InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();

                InvoicerDataSetTableAdapters.LineItemTableAdapter objLineItem = new InvoicerDataSetTableAdapters.LineItemTableAdapter();
                dsInvoicer = new DataSet();
                DataTable dtInvoice = objInvoice.GetDataByID(intInvoiceNo);
                foreach (DataRow drInvoice in dtInvoice.Rows)
                {
                    //SELECT AddressFlag, CGST, ClientID, DCNoDate, Discount, Freight, GSTIN, IGST, InvoiceDate, 
                    //InvoiceID, InvoicePath, LineAmount, OrderDate, OrderNo, SGST, StateCode, 
                    //SubTotal, TaxAmount, TotalAmount FROM Invoice WHERE (InvoiceID = ?)
                    cmbClient.SelectedValue = drInvoice["ClientID"].ToString();
                    txtInvoiceNo.Text = drInvoice["InvoiceID"].ToString();
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
                    radNewAddr.Checked = drInvoice["AddressFlag"].ToString()== "1" ? true : false;
                    txtTaxAmount.Text = drInvoice["TaxAmount"].ToString();
                    txtLineAmount.Text = drInvoice["LineAmount"].ToString();
                    txtTotalDiscount.Text = drInvoice["SubTotal"].ToString();
                    txtTotalAmount.Text = drInvoice["TotalAmount"].ToString();

                    DataTable dtLineItem = objLineItem.GetDataByID(intInvoiceNo);
                    dgInvoicer.DataSource = dtLineItem;
                    dgInvoicer.Refresh();
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
                throw excLocal;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.clientTableAdapter.FillBy(this.invoicerDataSet.Client);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
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
                throw excLocal;
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
                throw excLocal;
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
                throw exclocal;
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
                throw exclocal;
            }
        }
    }
}