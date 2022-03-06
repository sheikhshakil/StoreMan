using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class SaleData : Form
    {
        string tableName = null, saleId = null;

        public SaleData(string storeId, string saleId)
        {
            InitializeComponent();
            tableName = "salesReport_" + storeId;
            this.saleId = saleId;

            loadSaleData();
        }

        private void loadSaleData()
        {
            soldProductsPanel.Controls.Clear();
            using(SqlConnection connection = DbHelper.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM " + tableName + @" WHERE saleId = @saleId;", connection);
                    cmd.Parameters.AddWithValue("saleId", saleId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        //deserialize sold prods
                        List<Dictionary<string, string>> listOfSoldProducts = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(reader["productsData"].ToString());

                        foreach (var pData in listOfSoldProducts)
                        {
                            PartSoldProductRow row = new PartSoldProductRow(pData);
                            row.Dock = DockStyle.Top;
                            soldProductsPanel.Controls.Add(row);
                        }

                        //update text fields
                        subTotalText.Text = reader["subTotal"].ToString();
                        discountText.Text = reader["discount"].ToString();
                        vatText.Text = reader["vat"].ToString() + " %";
                        netTotalText.Text = reader["netTotal"].ToString();

                        paidAmtText.Text = Math.Round(Convert.ToDouble(reader["netTotal"].ToString()) - Convert.ToDouble(reader["due"].ToString()), 2, MidpointRounding.AwayFromZero).ToString();
                        dueText.Text = reader["due"].ToString();

                        custNameText.Text = reader["custName"].ToString();
                        custPhoneText.Text = reader["custPhone"].ToString();
                        custAddrText.Text = reader["custAddr"].ToString();

                        reader.Close();
                        break;
                    }

                    connection.Close();
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Error occured while loading sale data!"); ;
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string value = newPaidAmtInput.Text.Trim().ToLower();
            double due;

            if(value.Length <= 0)
            {
                MessageBoxer.showErrorMsg("Paid amount should be a number value or \"Full\" to indicate zero due!");
                return;
            }
            else if(value.Equals("full"))
            {
                due = 0;
            }
            else
            {
                try
                {
                    due = Math.Round(Convert.ToDouble(netTotalText.Text) - Convert.ToDouble(value), 2, MidpointRounding.AwayFromZero);
                } 
                catch
                {
                    MessageBoxer.showErrorMsg("Paid amount should be a number value or \"Full\" to indicate zero due!");
                    return;
                }
            }

            using(SqlConnection connection = DbHelper.getConnection())
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE " + tableName + @" SET due = @due WHERE saleId = @saleId;", connection);
                cmd.Parameters.AddWithValue("due", due);
                cmd.Parameters.AddWithValue("saleId", saleId);
                cmd.ExecuteNonQuery();

                MessageBoxer.showGeneralMsg("Due updated successfully.");
                loadSaleData();
            }
        }

        private void printInvoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StoreOptions.options.handleInvoicePrint(saleId);
            }
            catch
            {
                MessageBoxer.showErrorMsg("Invoice generation failed!");
            }
        }
    }
}
