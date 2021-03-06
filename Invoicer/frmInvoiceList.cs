﻿using System;
using System.Windows.Forms;
using System.Data;

namespace Invoicer
{
    public partial class frmInvoiceList : Form
    {
        public frmInvoiceList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitLoad();

                // TODO: This line of code loads data into the 'invoicerDataSet.Invoice' table. You can move, or remove it, as needed.
                // this.invoiceTableAdapter.Fill(new InvoicerDataSetTableAdapters.InvoiceTableAdapter().GetDataByInvoiceList(Convert.ToDateTime("01/01/2010"), Convert.ToDateTime("12/31/2013")));

                // TODO: This line of code loads data into the 'invoicerDataSet.Client' table. You can move, or remove it, as needed.
                //this.clientTableAdapter.Fill(this.invoicerDataSet.Client);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void InitLoad()
        {
            DateTime dtStartDate = DateTime.Now;
            DateTime? StartDate = null;
            DateTime? EndDate = null;
            try
            {
                dtStartDate = new DateTime(dtStartDate.Year, dtStartDate.Month, 1);

                dtFromDate.Text = dtStartDate.ToString();

                if (this.dtFromDate.Text != "")
                {
                    dtFromDate.CustomFormat = "MM/dd/yyyy";
                    StartDate = Convert.ToDateTime(dtFromDate.Text);
                    dtFromDate.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    MessageBox.Show("Please enter Start Date");
                }

                if (this.dtToDate.Text != "")
                {
                    dtToDate.CustomFormat = "MM/dd/yyyy";
                    EndDate = Convert.ToDateTime(dtToDate.Text);
                    dtToDate.CustomFormat = "dd/MM/yyyy";
                }
                else
                {
                    MessageBox.Show("Please enter End Date");
                }
                this.invoiceTableAdapter.FillByInvoiceList(this.invoicerDataSet.Invoice, StartDate, EndDate);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                InitLoad();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dtFromDate.Text != "")
                {
                    dtFromDate.CustomFormat = "MM/dd/yyyy";
                }
                else
                {
                    dtFromDate.Invalidate(false);
                }

                if (this.dtToDate.Text != "")
                {
                    dtToDate.CustomFormat = "MM/dd/yyyy";
                }
                else
                {
                    dtToDate.Invalidate(false);
                }

                this.invoiceTableAdapter.FillByInvoiceList(this.invoicerDataSet.Invoice, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtFromDate.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtToDate.Text, typeof(System.DateTime))))));

                dtFromDate.CustomFormat = "dd/MM/yyyy";
                dtToDate.CustomFormat = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmInvoicer objInvoicer = new frmInvoicer();
                objInvoicer.ShowDialog(this);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int intInvoiceID = 0;
            try
            {
                if (dgInvoice.SelectedRows.Count >= 1)
                {
                    intInvoiceID = Convert.ToInt32(dgInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString());
                    //this.Owner.ShowDialog(this);
                    //frmInvoicer objInvoicer = new frmInvoicer(intInvoiceNo);
                    //objInvoicer.ShowDialog(this);
                    //this.Owner.Close();                   
                    frmInvoicer myParent = (frmInvoicer)this.Owner;
                    myParent.DisplayData(intInvoiceID);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int intInvoiceID = 0;
            string strClient = null;
            try
            {
                if (dgInvoice.SelectedRows.Count >= 1 && dgInvoice.SelectedRows[0].Cells["InvoiceID"].Value != null)
                {
                    intInvoiceID = Convert.ToInt32(dgInvoice.SelectedRows[0].Cells["InvoiceID"].Value.ToString());
                    strClient = dgInvoice.SelectedRows[0].Cells["ClientName"].ToString();
                    ReportHelper.GeneratePDFReport(intInvoiceID, strClient);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                throw ex;
            }
        }
    }
}