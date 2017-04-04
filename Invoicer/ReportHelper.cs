using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Invoicer
{
    internal class ReportHelper
    {
        public static bool GeneratePDFReport(int intInvoiceid, string strClientName)
        {
            string strSourceRptPath;
            string strReportOutputPath;
            string strFileName = String.Empty;
            DataSet dsInvoicer = null;

            ReportDocument rptDoc = null;
            try
            {
                InvoicerDataSetTableAdapters.ClientTableAdapter objClient = new InvoicerDataSetTableAdapters.ClientTableAdapter();

                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();

                InvoicerDataSetTableAdapters.LineItemTableAdapter objLineItem = new InvoicerDataSetTableAdapters.LineItemTableAdapter();
                dsInvoicer = new DataSet();
                DataTable dtInvoice = objInvoice.GetDataByID(intInvoiceid);
                if (dtInvoice.Rows.Count > 0)
                {
                    strSourceRptPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase.ToString()).ToString() + @"\";

                    strSourceRptPath = strSourceRptPath.Replace(@"file:\", "");

                    //Create a new Report Document object
                    rptDoc = new ReportDocument();
                    rptDoc.Load(strSourceRptPath + "rptInvoiceDetails.rpt");

                    DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
                    Invoicer.Properties.Settings objsettings = new Properties.Settings();

                    //builder.ConnectionString = ConfigurationManager.ConnectionStrings["Invoicer.Properties.Settings.InvoicerConnectionString"].ConnectionString;
                    builder.ConnectionString = objsettings.InvoicerConnectionString.ToString();
                    string databasepath = builder["Data Source"] as string;

                    ////change path of the database
                    rptDoc.DataSourceConnections[0].SetConnection("", databasepath, false);

                    ////'' if password is given then give the password
                    ////'' if not give it will ask at runtime
                    rptDoc.DataSourceConnections[0].SetLogon("admin", "");

                    //SetReportLogon(rptDoc, "RXP", null);
                    rptDoc.SetParameterValue("InvoiceID", intInvoiceid);
                    // Stream objstream = rptDoc.ExportToStream(ExportFormatType.PortableDocFormat);
                    
                    dsInvoicer.Tables.Add(objClient.GetDataByID(Convert.ToInt32(dtInvoice.Rows[0]["ClientID"].ToString())));
                    dsInvoicer.Tables.Add(dtInvoice);
                    dsInvoicer.Tables.Add(objLineItem.GetDataByID(intInvoiceid));

                    rptDoc.SetDataSource(dsInvoicer);
                    //strReportOutputPath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase.ToString()).ToString() + @"\PDFReports\";//ConfigurationManager.AppSettings["ExportPDFPath"].ToString();
                    strReportOutputPath = System.IO.Path.GetDirectoryName(ConfigurationManager.AppSettings["InvoicePDFPath"].ToString()) + @"\" + strClientName;
                    strReportOutputPath = strReportOutputPath.Replace(@"file:\", "");

                    //strReportOutputPath = strReportOutputPath + @"\";
                    if (!Directory.Exists(strReportOutputPath))
                    {
                        Directory.CreateDirectory(strReportOutputPath);
                    }
                    strFileName = "Invoice_" + intInvoiceid + ".pdf";

                    if (UpdatePDFFiles(strReportOutputPath + strFileName, intInvoiceid))
                    {
                        FileInfo fileInfo = new FileInfo(strReportOutputPath + strFileName);
                        if (fileInfo.Exists)
                        {
                            File.Delete(strReportOutputPath + strFileName);
                        }
                    }

                    //rptDoc.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                    //rptDoc.PrintOptions.PaperSize = PaperSize.PaperA4;

                    //int intcount = rptDoc.Database.Tables.Count;

                    rptDoc.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, strReportOutputPath + strFileName);
                    rptDoc.PrintToPrinter(1, false, 0, 0);
                }

                return true;
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
            finally
            {
                dsInvoicer.Dispose();

                //Clear Report Document object
                rptDoc.Close();
                //rptDoc.Dispose();
                rptDoc = null;
            }
        }

        private static bool UpdatePDFFiles(string strPDFPath, int intInvoiceid)
        {
            try
            {
                InvoicerDataSetTableAdapters.InvoiceTableAdapter objInvoice = new InvoicerDataSetTableAdapters.InvoiceTableAdapter();
                objInvoice.UpdateInvoicePath(strPDFPath, intInvoiceid);
                return true;
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
        }

        /// <summary>
        /// Retrieves the primary key autonumber values from Access
        /// </summary>
        /// <remarks></remarks>
        public static void SetPrimaryKey(OleDbTransaction trans, OleDbRowUpdatedEventArgs e)
        {
            if (e.Status == UpdateStatus.Continue && e.StatementType == StatementType.Insert)
            {
                // If this is an INSERT operation...
                DataColumn[] pk = e.Row.Table.PrimaryKey;

                // and a primary key column exists...
                if (pk != null && pk.Length == 1)
                {
                    OleDbCommand cmdGetIdentity = new OleDbCommand("SELECT @@IDENTITY", trans.Connection, trans);

                    // Execute the post-update query to fetch new @@Identity
                    e.Row[pk[0]] = Convert.ToInt32(cmdGetIdentity.ExecuteScalar());
                    e.Row.AcceptChanges();
                }
            }
        }

        private bool ApplyLogon(ReportDocument rptDocParam, ConnectionInfo objConnInfo)
        {
            TableLogOnInfo objTblLogInfo;

            try
            {
                if (rptDocParam != null)
                {
                    // for each table apply connection info
                    foreach (CrystalDecisions.CrystalReports.Engine.Table tbl in rptDocParam.Database.Tables)
                    {
                        objTblLogInfo = tbl.LogOnInfo;
                        objTblLogInfo.ConnectionInfo = objConnInfo;
                        tbl.ApplyLogOnInfo(objTblLogInfo);

                        // check if logon was successful
                        // if TestConnectivity returns false, check
                        // logon credentials

                        if (tbl.TestConnectivity())
                        {
                            // drop fully qualified table location
                            if (tbl.Location.IndexOf(".") > 0)
                            {
                                tbl.Location =
                                    tbl.Location.Substring(tbl.Location.LastIndexOf(".")
                                    + 1);
                            }
                            else tbl.Location = tbl.Location;
                        }
                        else return (false);
                    }
                }
                return (true);
            }
            catch (Exception excLocal)
            {
                throw excLocal;
            }
            finally
            {
                objConnInfo = null;
                rptDocParam = null;
                objTblLogInfo = null;
            }
        }

        //bool SetReportLogon(ReportDocument rptDocument, string strMainRptProductName, string strSubRptProductName)
        //{
        //    ConnectionInfo ciMainRpt = new ConnectionInfo();
        //    ConnectionInfo ciSubRpt = new ConnectionInfo();
        //    Sections crSections;
        //    ReportObjects crReportObjects;
        //    SubreportObject crSubreportObject;
        //    ReportDocument crSubreportDocument;

        //    object[] objMainDBInfo;
        //    object[] objSubDBInfo;

        //    try
        //    {
        //        // Get DB Information
        //        clsSqlDBInfo objSQLDBInfo = new clsSqlDBInfo();
        //        objMainDBInfo = (object[])objSQLDBInfo.GetDatabaseInfo(strMainRptProductName);

        //        ciMainRpt.ServerName = objMainDBInfo[1].ToString();
        //        ciMainRpt.DatabaseName = objMainDBInfo[2].ToString();
        //        ciMainRpt.UserID = objMainDBInfo[4].ToString();
        //        ciMainRpt.Password = objMainDBInfo[5].ToString();

        //        if (strSubRptProductName != null)
        //        {
        //            objSubDBInfo = (object[])objSQLDBInfo.GetDatabaseInfo(strSubRptProductName);
        //            ciSubRpt.ServerName = objSubDBInfo[1].ToString();
        //            ciSubRpt.DatabaseName = objSubDBInfo[2].ToString();
        //            ciSubRpt.UserID = objSubDBInfo[4].ToString();
        //            ciSubRpt.Password = objSubDBInfo[5].ToString();
        //        }
        //        objSQLDBInfo = null;

        //        if (!ApplyLogon(rptDocument, ciMainRpt)) return (false);

        //        crSections = rptDocument.ReportDefinition.Sections;
        //        // loop through all the sections to find all the report objects
        //        foreach (CrystalDecisions.CrystalReports.Engine.Section crSection in crSections)
        //        {
        //            crReportObjects = crSection.ReportObjects;
        //            //loop through all the report objects in there to find all subreports
        //            foreach (ReportObject crReportObject in crReportObjects)
        //            {
        //                if (crReportObject.Kind == ReportObjectKind.SubreportObject)
        //                {
        //                    crSubreportObject = (SubreportObject)crReportObject;
        //                    //open the subreport object and logon as for the general report
        //                    crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName);
        //                    if (!ApplyLogon(crSubreportDocument, ciSubRpt)) return (false);
        //                    crSubreportObject = null;
        //                }
        //            }
        //        }
        //        return (true);
        //    }
        //    catch (Exception excLocal)
        //    {
        //        throw excLocal;
        //    }
        //    finally
        //    {
        //        ciMainRpt = null;
        //        ciSubRpt = null;
        //        objMainDBInfo = null;
        //        objSubDBInfo = null;
        //    }
        //}

        ////Insert pdf files to the Database
        //public bool UpdatePDFFiles(string strFileName, string strFilePath, int intInvoiceId, int intuser)
        //{
        //    mhaDataService.clsSqlHelper objSQLHelper = new mhaDataService.clsSqlHelper();
        //    //declare variables
        //    object[] objInputParamValues = null;
        //    object[] objReturn = null;
        //    object[] vntParamName = null;
        //    object[] vntInput = null;
        //    string strContentType = null;
        //    /***************************************************************************
        //                            UPDATE SP DETAILS
        //    ****************************************************************************
        //        SP Name	:	[ACSP_UPDATEINVOICEFILES]
        //        Params	:	@UPDATEFOR		VARCHAR(20),
        //                    @INVOICEID		INT,
        //                    @FILENAME		VARCHAR(100) = NULL,
        //                    @FILECONTENT	VARCHAR(100) = NULL,
        //                    @FILEDATA		VARBINARY(MAX) = NULL,
        //                    @ADDUSER		INT
        //    ****************************************************************************/
        //    try
        //    {
        //        //Initialize DBCall function

        //        //FileContent type whether this hast to be "appliaction/ms-excel","application/doc"
        //        strContentType = "application/pdf";
        //        //Convert files in to bytes stream
        //        FileStream fs = new FileStream(strFilePath, FileMode.Open, FileAccess.Read);
        //        BinaryReader br = new BinaryReader(fs);
        //        Byte[] bytesInvoice = br.ReadBytes((Int32)fs.Length);
        //        br.Close();
        //        fs.Close();

        //        //values from form
        //        vntParamName = new object[] { "@UPDATEFOR", "@INVOICEID", "@FILENAME", "@FILECONTENT", "@FILEDATA", "@ADDUSER", "@INVPDFPATH", "@FILEEXISTS" };

        //        objInputParamValues = new object[] { "INSERT", intInvoiceId, strFileName, strContentType, bytesInvoice, intuser ,null,null};

        //        vntInput = new object[] { "acsp_UpdateInvoiceFiles", vntParamName, null, objInputParamValues };
        //        //Execute query
        //        objReturn = (object[])objSQLHelper.ExecuteNonQuery("RXP", vntInput);

        //        return true;

        //    }
        //    catch (Exception exLocal)
        //    {
        //        //throw exception
        //        throw exLocal;
        //    }
        //    finally
        //    {
        //        //Clear objects
        //        objInputParamValues = null;
        //    }
        //}
    }
}