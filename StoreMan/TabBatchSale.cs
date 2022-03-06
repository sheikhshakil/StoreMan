using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class TabBatchSale : UserControl
    {
        public static List<Dictionary<string, string>> listOfProductsData = new List<Dictionary<string, string>>();
        public static TabBatchSale thisForm = null;
        private string salesTableName = null, invTableName = null;

        public TabBatchSale(string storeId)
        {
            InitializeComponent();

            thisForm = this;
            salesTableName = "salesReport_" + storeId;
            invTableName = "inventory_" + storeId;

            handleInitialTasks();
        }

        public void handleInitialTasks()
        {
            productsListPanel.Controls.Clear();
            updateOrderSummary();

            if (listOfProductsData.Count > 0)
            {
                for (int i = listOfProductsData.Count - 1; i >= 0; i--)
                {
                    PartProdListRow prodListRow = new PartProdListRow(listOfProductsData[i], i + 1);
                    prodListRow.Dock = DockStyle.Top;

                    productsListPanel.Controls.Add(prodListRow);
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "Cart is empty. Double click a product in inventory to add it to cart.";
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;

                productsListPanel.Controls.Add(label);
            }
        }

        private void clearCartBtn_Click(object sender, EventArgs e)
        {
            listOfProductsData.Clear();
            handleInitialTasks();
        }

        public void updateOrderSummary()
        {
            if (listOfProductsData.Count > 0)
            {
                summaryText.Text = "<pre><code>" +
                    JsonConvert.SerializeObject(listOfProductsData, Formatting.Indented) +
                    "</code></pre>";
            }
            else
            {
                summaryText.Text = "No product in cart!";
            }

            subtotalText.Text = calcSubtotal().ToString();
            nettotalText.Text = calcNettotal().ToString();
        }

        private double calcSubtotal()
        {
            double subtotal = 0;

            if (listOfProductsData.Count > 0)
            {
                try
                {
                    for (int i = 0; i < listOfProductsData.Count; i++)
                    {
                        double sppu = Convert.ToDouble(listOfProductsData[i]["sppu"]);
                        double qty = Convert.ToDouble(listOfProductsData[i]["qty"]);

                        subtotal += sppu * qty;
                    }
                }
                catch
                {
                    return 0;
                }
            }

            return Math.Round(subtotal, 2, MidpointRounding.AwayFromZero);
        }

        private double calcNettotal()
        {
            double subtotal = calcSubtotal();

            if (listOfProductsData.Count > 0)
            {
                double vat, discount;

                //get discount
                try
                {
                    discount = Convert.ToDouble(discountInput.Text.Trim());
                }
                catch
                {
                    discount = 0;
                }

                //get vat
                try
                {
                    vat = Convert.ToDouble(vatInput.Text.Trim());
                }
                catch
                {
                    vat = 0;
                }

                //calculate
                double discountedSub = subtotal - discount;
                double netTotal = discountedSub + (discountedSub * (vat / 100));

                return Math.Round(netTotal, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                return subtotal;
            }
        }


        private void vatInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(vatInput.Text.Trim());
                nettotalText.Text = calcNettotal().ToString();
            }
            catch
            {
                vatInput.Clear();
                nettotalText.Text = calcNettotal().ToString();
            }
        }

        private void discountInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToDouble(discountInput.Text.Trim());
                nettotalText.Text = calcNettotal().ToString();
            }
            catch
            {
                discountInput.Clear();
                nettotalText.Text = calcNettotal().ToString();
            }
        }

        private double calcDue()
        {
            double due = 0;
            string paidAmt = paidAmtInput.Text.Trim().ToLower();

            if (paidAmt.Length == 0)
            {
                due = calcNettotal();
                return due;
            }
            else if (paidAmt.Equals("full"))
            {
                return due;
            }
            else
            {
                try
                {
                    due = Math.Round(calcNettotal() - Convert.ToDouble(paidAmt), 2, MidpointRounding.AwayFromZero);
                    return due;
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Paid amount should be a number value or \"Full\" to indicate zero due!");
                    throw new Exception();
                }
            }

        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            if (listOfProductsData.Count < 1)
            {
                MessageBoxer.showErrorMsg("No product in cart!");
                return;
            }

            bool hasStock = true;
            List<Dictionary<string, string>> stockDataList = new List<Dictionary<string, string>>();

            //verify stock availability
            for (int i = 0; i < listOfProductsData.Count; i++)
            {
                try
                {
                    double qty = Convert.ToDouble(listOfProductsData[i]["qty"]);
                    double stock = TabInventory.inventory.getProductStock(listOfProductsData[i]["pId"]);

                    if (qty < 1)
                    {
                        MessageBoxer.showErrorMsg(listOfProductsData[i]["pName"] + " - sale quantity must be a value greater than 0!");
                        return;
                    }

                    if (stock > 0 && qty <= stock)
                    {
                        Dictionary<string, string> stockData = new Dictionary<string, string>();
                        stockData.Add("pId", listOfProductsData[i]["pId"]);
                        stockData.Add("newStock", Math.Round((stock - qty), 2, MidpointRounding.AwayFromZero).ToString());

                        stockDataList.Add(stockData);
                        continue;
                    }
                    else
                    {
                        MessageBoxer.showErrorMsg(listOfProductsData[i]["pName"] + " has insufficient stock!\nAvailable quantity : " + stock.ToString());
                        return;
                    }
                }
                catch
                {
                    hasStock = false;
                }
            }

            if (hasStock)
            {
                //start sale op.
                string productsData = JsonConvert.SerializeObject(listOfProductsData);
                double buyPriceTotal = 0;

                //calculate the stock cost of sold products
                for (int i = 0; i < listOfProductsData.Count; i++)
                {
                    try
                    {
                        buyPriceTotal += Convert.ToDouble(listOfProductsData[i]["bppu"]) * Convert.ToDouble(listOfProductsData[i]["qty"]);
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Type conversion error occured! Please try again.");
                        return;
                    }
                }

                //insert sale data and update stock
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    if (stockDataList.Count == listOfProductsData.Count)
                    {
                        try
                        {
                            connection.Open();
                            string query = "INSERT INTO " + salesTableName + @" (productsData, typesCount, buyPriceTotal, subTotal, discount, vat, netTotal, due, custName, custPhone, custAddr) VALUES(@pd, @tc, @bpt, @st, @dc, @vat, @nt, @due, @cn, @cp, @ca) SELECT CAST(scope_identity() AS INT);";

                            SqlCommand cmd = new SqlCommand(query, connection);
                            cmd.Parameters.AddWithValue("pd", productsData);
                            cmd.Parameters.AddWithValue("tc", listOfProductsData.Count);
                            cmd.Parameters.AddWithValue("bpt", Math.Round(buyPriceTotal, 2, MidpointRounding.AwayFromZero));
                            cmd.Parameters.AddWithValue("st", calcSubtotal());
                            cmd.Parameters.AddWithValue("dc", discountInput.Text.Trim());
                            cmd.Parameters.AddWithValue("vat", vatInput.Text.Trim());
                            cmd.Parameters.AddWithValue("nt", calcNettotal());
                            cmd.Parameters.AddWithValue("due", calcDue());
                            cmd.Parameters.AddWithValue("cn", custNameInput.Text.Trim());
                            cmd.Parameters.AddWithValue("cp", custPhoneInput.Text.Trim());
                            cmd.Parameters.AddWithValue("ca", custAddrInput.Text.Trim());

                            string saleId = Convert.ToString(cmd.ExecuteScalar());

                            connection.Close();

                            //update stock
                            for (int i = 0; i < stockDataList.Count; i++)
                            {
                                connection.Open();

                                SqlCommand cmdUpdateStock = new SqlCommand("UPDATE " + invTableName + @" SET quantity = @newStock WHERE pId = @pId;", connection);

                                cmdUpdateStock.Parameters.AddWithValue("newStock", stockDataList[i]["newStock"]);
                                cmdUpdateStock.Parameters.AddWithValue("pId", stockDataList[i]["pId"]);

                                cmdUpdateStock.ExecuteNonQuery();

                                connection.Close();
                            }

                            //print invoice by asking
                            bool needPrint = MessageBoxer.generalConfirmation("Sale successful. Sale ID = " + saleId.ToString() + ".\nDo you want to print invoice for this sale?");

                            if (needPrint)
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
                        catch
                        {
                            MessageBoxer.showErrorMsg("Sale operation had some errors! Please try again.");
                        }
                    }
                    else
                    {
                        MessageBoxer.showErrorMsg("Sale operation failed due to inconsistency between product lists!");
                    }
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Failed to read products stock from inventory!");
            }
        }
    }
}
