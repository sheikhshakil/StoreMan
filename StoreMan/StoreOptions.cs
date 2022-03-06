using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class StoreOptions : Form
    {
        private string storeId = null;
        private string reportTableName = null;
        public static StoreOptions options = null;

        public StoreOptions(string id)
        {
            InitializeComponent();

            handleInitialTasks(id);
        }
        private void StoreOptions_Load(object sender, EventArgs e)
        {
            if (Activator.checkActivation())
            {
                TabInventory inventory = new TabInventory(storeId);
                setupTab(inventory);
                inventoryBtn.Checked = true;
            }
        }

        private void handleInitialTasks(string id)
        {
            if (Activator.checkActivation())
            {
                //activated
                this.storeId = id;
                this.reportTableName = "salesReport_" + storeId;
                options = this;

                showStoreDetails();
                createInventoryTable();
                createReportTable();
                setupAdminAccess();
            }
            else
            {
                storeMenuBox.Enabled = false;

                Label label = new Label();
                label.Text = "Is it ethically right to steal and use the app this way without activating it?";
                label.Dock = DockStyle.Fill;
                label.AutoSize = false;
                label.ForeColor = Color.Red;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new Font("Segoe UI", 18, FontStyle.Bold);

                optionViewPanel.Controls.Add(label);
            }
        }

        public void showStoreDetails()
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                if (DbHelper.doesTableExist("stores"))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM stores WHERE storeId=@storeId;", connection);

                        cmd.Parameters.AddWithValue("storeId", this.storeId);

                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            storeMenuBox.Text = reader["storeName"].ToString();
                            desLabel.Text = reader["storeDes"].ToString();

                            break;
                        }
                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Couldn't read store details!");
                    }
                }
                else
                {
                    MessageBoxer.showErrorMsg("Store doesn't exist!");
                }
            }
        }

        private void createInventoryTable()
        {
            string tableName = "inventory_" + storeId;

            //create table if not exists
            if (!DbHelper.doesTableExist(tableName))
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();
                        string cmdText = "CREATE TABLE " + tableName + @" (pId INT NOT NULL PRIMARY KEY IDENTITY(1,1), photo IMAGE, pCode VARCHAR(50), pName VARCHAR(1000) NOT NULL, quantity FLOAT NOT NULL, bppu FLOAT NOT NULL, sppu FLOAT NOT NULL, dateAdded DATETIME DEFAULT(getdate()) NOT NULL)";
                        SqlCommand cmd = new SqlCommand(cmdText, connection);

                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Couldn't create inventory table!");
                    }
                }
            }
        }

        private void createReportTable()
        {
            string tableName = "salesReport_" + storeId;

            //create table
            if (!DbHelper.doesTableExist(tableName))
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();
                        string cmdText = "CREATE TABLE " + tableName + @" (saleId INT NOT NULL PRIMARY KEY IDENTITY(1,1), productsData VARCHAR(MAX) NOT NULL, typesCount INT NOT NULL, buyPriceTotal FLOAT NOT NULL, subTotal FLOAT NOT NULL, discount FLOAT, vat FLOAT, netTotal FLOAT NOT NULL, due FLOAT NOT NULL, custName VARCHAR(500), custPhone VARCHAR(20), custAddr VARCHAR(1000), dateSold DATETIME DEFAULT(getdate()) NOT NULL);";

                        SqlCommand cmd = new SqlCommand(cmdText, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Couldn't create report table!");
                    }

                }
            }
        }

        private void setupAdminAccess()
        {
            if (!DbHelper.doesTableExist("admin"))
            {
                //create admin table
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(@"CREATE TABLE admin (username VARCHAR(10) DEFAULT 'admin' NOT NULL PRIMARY KEY, password VARCHAR(MAX) NOT NULL);", connection);

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        insertInitialAdminCreds();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Admin setup error occured!");
                    }
                }
            }
        }

        private void insertInitialAdminCreds()
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO admin (password) VALUES (@defaultPass);", connection);
                cmd.Parameters.AddWithValue("defaultPass", Encryption.Encrypt("12345"));

                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void deleteStoreBtn_Click(object sender, EventArgs e)
        {
            Authenticator authenticator = new Authenticator("delete this store. All inventory and sales report data of this store will also be deleted!");

            var result = authenticator.ShowDialog();
            if (result == DialogResult.OK)
            {
                bool isConfirm = MessageBoxer.isConfirm("This store along with all its inventory and sales report data will be deleted! Are you sure?");
                if (isConfirm)
                {
                    using (SqlConnection connection = DbHelper.getConnection())
                    {
                        try
                        {
                            //delete store's tables
                            string invTable = "inventory_" + storeId, reportTable = "salesReport_" + storeId;
                            connection.Open();
                            SqlCommand cmdDltTables = new SqlCommand("DROP TABLE IF EXISTS " + invTable + ", " + reportTable + ";", connection);
                            cmdDltTables.ExecuteNonQuery();
                            connection.Close();

                            //delete store itself
                            connection.Open();
                            SqlCommand cmdDltStore = new SqlCommand("DELETE FROM stores WHERE storeId=@storeId;", connection);
                            cmdDltStore.Parameters.AddWithValue("storeId", storeId);
                            cmdDltStore.ExecuteNonQuery();
                            connection.Close();

                            MessageBoxer.showGeneralMsg("This store and all its data has been deleted!");

                            this.Close();
                        }
                        catch
                        {
                            MessageBoxer.showErrorMsg("Error occured while deleting store data!");
                        }
                    }
                }
                else
                {
                    MessageBoxer.showGeneralMsg("Okay. Task aborted.");
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Authentication error! Aborted store deletion task.");
            }
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            TabInventory inventory = new TabInventory(storeId);
            setupTab(inventory);
        }

        private void batchSaleBtn_Click(object sender, EventArgs e)
        {
            TabBatchSale batchSale = new TabBatchSale(storeId);
            setupTab(batchSale);
        }

        private void salesReportBtn_Click(object sender, EventArgs e)
        {
            TabSalesReport report = new TabSalesReport(storeId);
            setupTab(report);
        }

        private void adminOptionsBtn_Click(object sender, EventArgs e)
        {
            TabAdminOptions tabAdmin = new TabAdminOptions(storeId);
            setupTab(tabAdmin);
        }

        private void setupTab(Control control)
        {
            optionViewPanel.Controls.Clear();
            optionViewPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        //printing invoice codes
        public void handleInvoicePrint(string saleId)
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM " + reportTableName + @" WHERE saleId = @saleId;", connection);
                cmd.Parameters.AddWithValue("saleId", saleId);
                SqlDataReader reader = cmd.ExecuteReader();

                //read sale data
                Dictionary<string, string> saleData = new Dictionary<string, string>();
                while (reader.Read())
                {
                    saleData.Add("saleId", reader["saleId"].ToString());
                    saleData.Add("productsData", reader["productsData"].ToString());

                    saleData.Add("custName", reader["custName"].ToString());
                    saleData.Add("custPhone", reader["custPhone"].ToString());
                    saleData.Add("custAddr", reader["custAddr"].ToString());

                    saleData.Add("subTotal", reader["subTotal"].ToString());
                    saleData.Add("discount", reader["discount"].ToString());
                    saleData.Add("vat", reader["vat"].ToString());
                    saleData.Add("netTotal", reader["netTotal"].ToString());
                    saleData.Add("due", reader["due"].ToString());

                    saleData.Add("dateSold", reader["dateSold"].ToString());

                    reader.Close();
                    break;
                }
                connection.Close();

                //read store data
                Dictionary<string, string> storeData = getStoreData();

                //deserialize sold prods
                List<Dictionary<string, string>> listOfSoldProducts = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(saleData["productsData"]);

                //make a sold products table
                DataTable dt = new DataTable("soldProductsTable");
                dt.Clear();
                dt.Columns.Add("pCode", typeof(string));
                dt.Columns.Add("pName", typeof(string));
                dt.Columns.Add("qty", typeof(string));
                dt.Columns.Add("sppu", typeof(string));
                dt.Columns.Add("total", typeof(string));

                DataRow dr;
                for (int i = 0; i < listOfSoldProducts.Count; i++)
                {
                    dr = dt.NewRow();
                    dr["pCode"] = listOfSoldProducts[i]["pCode"];
                    dr["pName"] = listOfSoldProducts[i]["pName"];
                    dr["qty"] = listOfSoldProducts[i]["qty"];
                    dr["sppu"] = listOfSoldProducts[i]["sppu"];
                    dr["total"] = Math.Round(Convert.ToDouble(listOfSoldProducts[i]["qty"]) * Convert.ToDouble(listOfSoldProducts[i]["sppu"]), 2, MidpointRounding.AwayFromZero).ToString();

                    dt.Rows.Add(dr);
                }

                //generate and show report
                ReportParameterCollection reportParams = new ReportParameterCollection();
                reportParams.Add(new ReportParameter("storeName", storeData["storeName"]));
                reportParams.Add(new ReportParameter("storeDes", storeData["storeDes"]));
                reportParams.Add(new ReportParameter("storeAddr", storeData["storeAddr"]));

                reportParams.Add(new ReportParameter("saleId", saleData["saleId"]));
                reportParams.Add(new ReportParameter("custName", saleData["custName"]));
                reportParams.Add(new ReportParameter("custPhone", saleData["custPhone"]));
                reportParams.Add(new ReportParameter("custAddr", saleData["custAddr"]));

                reportParams.Add(new ReportParameter("subTotal", saleData["subTotal"]));
                reportParams.Add(new ReportParameter("discount", saleData["discount"]));
                reportParams.Add(new ReportParameter("vat", saleData["vat"]));
                reportParams.Add(new ReportParameter("netTotal", saleData["netTotal"]));

                reportParams.Add(new ReportParameter("paidAmt", Math.Round(Convert.ToDouble(saleData["netTotal"]) - Convert.ToDouble(saleData["due"]), 2, MidpointRounding.AwayFromZero).ToString()));
                reportParams.Add(new ReportParameter("due", saleData["due"]));

                reportParams.Add(new ReportParameter("dateSold", saleData["dateSold"]));

                //for products data
                ReportDataSource rds = new ReportDataSource("SoldProductsData", dt);

                InvoicePrinter invoicePrinter = new InvoicePrinter(reportParams, rds);
                invoicePrinter.ShowDialog();
            }
        }

        private Dictionary<string, string> getStoreData()
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(@"SELECT storeName, storeDes, storeAddr FROM stores WHERE storeId = @storeId", connection);
                cmd.Parameters.AddWithValue("storeId", storeId);
                SqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> storeData = new Dictionary<string, string>();
                while (reader.Read())
                {
                    storeData.Add("storeName", reader["storeName"].ToString());
                    storeData.Add("storeDes", reader["storeDes"].ToString());
                    storeData.Add("storeAddr", reader["storeAddr"].ToString());
                    reader.Close();
                    break;
                }

                connection.Close();

                return storeData;
            }
        }

    }
}
