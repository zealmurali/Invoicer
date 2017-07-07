using System;
using System.Data;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class frmClientEdit : Form
    {
        public frmClientEdit()
        {
            InitializeComponent();
        }

        public frmClientEdit(string strClientID)
        {
            try
            {
                // TODO: Complete member initialization
                InitializeComponent();

                InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();
                DataTable dtClient = objClient.GetDataByID(Convert.ToInt32(strClientID));

                if (dtClient.Rows.Count > 0)
                {
                    txtClientID.Text = strClientID;
                    NameTextBox.Text = dtClient.Rows[0]["ClientName"].ToString();
                    AddressTextBox.Text = dtClient.Rows[0]["Address"].ToString();
                    CityTextBox.Text = dtClient.Rows[0]["City"].ToString();
                    StateTextBox.Text = dtClient.Rows[0]["State"].ToString();
                    ZipTextBox.Text = dtClient.Rows[0]["Zip"].ToString();
                    txtTINNo.Text = dtClient.Rows[0]["TINNO"].ToString();
                    txtVendorCode.Text = dtClient.Rows[0]["VendorCode"].ToString();

                    // txtRefNo.Text = dtClient.Rows[0]["OrderNo"].ToString();
                    txtDCNo.Text = dtClient.Rows[0]["DCNO"].ToString();
                    txtGSTIN.Text = dtClient.Rows[0]["GSTIN"].ToString();
                    txtStateCode.Text = dtClient.Rows[0]["StateCode"].ToString();
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
                throw excLocal;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpdateClient())
                {
                    this.Close();
                }
            }
            catch (Exception excLocal)
            {
                MessageBox.Show(excLocal.Message);
                throw excLocal;
            }
        }

        private bool UpdateClient()
        {
            try
            {
                InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();
                if (this.NameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter Customer Name");
                    NameTextBox.Focus();
                    return false;
                }
                else if (AddressTextBox.Text == "")
                {
                    MessageBox.Show("Please enter Customer Address");
                    AddressTextBox.Focus();
                    return false;
                }
                else if (CityTextBox.Text == "")
                {
                    MessageBox.Show("Please enter Customer City");
                    CityTextBox.Focus();
                    return false;
                }

                string ClientName = this.NameTextBox.Text != "" ? NameTextBox.Text : null;
                string Address = this.AddressTextBox.Text != "" ? AddressTextBox.Text : null;
                string City = this.CityTextBox.Text != "" ? CityTextBox.Text : null;
                string State = this.StateTextBox.Text != "" ? StateTextBox.Text : null;
                string Zip = this.ZipTextBox.Text != "" ? ZipTextBox.Text : null;
                string TINNO = this.txtTINNo.Text != "" ? txtTINNo.Text : null;

                //string OrderNo = this.txtRefNo.Text != "" ? txtRefNo.Text : null;
                string DCNO = this.txtDCNo.Text != "" ? txtDCNo.Text : null;
                string VendorCode = this.txtVendorCode.Text != "" ? txtVendorCode.Text : null;
                string GSTIN = this.txtGSTIN.Text != "" ? this.txtGSTIN.Text : null;
                string StateCode = this.txtStateCode.Text != "" ? this.txtStateCode.Text : null;
                if (txtClientID.Text == "")
                {
                    objClient.Insert(ClientName, Address, City, State, Zip, DCNO, VendorCode, TINNO, GSTIN, StateCode);
                }
                else
                {
                    objClient.UpdateClient(ClientName, Address, City, State, Zip, DCNO, VendorCode, TINNO, GSTIN, StateCode, Convert.ToInt32(txtClientID.Text.ToString()));
                }
                return true;
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
        }
    }
}