using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class TabSalesReport : UserControl
    {
        private string reportTableName = null, storeId = null;
        public static TabSalesReport thisForm = null;
        private DataSet data;
        private ToolTip toolTip = new ToolTip();

        public TabSalesReport(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
            thisForm = this;

            reportTableName = "salesReport_" + storeId;

            dateInput.Value = DateTime.Now;
        }

        private void TabSalesReport_Load(object sender, EventArgs e)
        {
            loadData("", dateInput.Value.ToShortDateString());
        }

        private void loadData(string input = "", string dateValue = "")
        {
            if (DbHelper.doesTableExist(reportTableName))
            {
                //show data
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    SqlCommand cmd;

                    if (dateValue.Length <= 2 && dateValue.Length > 0)
                    {
                        //full month
                        string query = "SELECT * FROM " + reportTableName + @" WHERE DATEPART(MONTH, dateSold) LIKE '%" + dateValue + "%' AND DATEPART(YEAR, dateSold) LIKE '%" + dateInput.Value.Year.ToString() + "%';";
                        cmd = new SqlCommand(query, connection);
                    }
                    else if (dateValue.Length == 4)
                    {
                        //full year
                        string query = "SELECT * FROM " + reportTableName + @" WHERE DATEPART(YEAR, dateSold) LIKE '%" + dateValue + "%';";
                        cmd = new SqlCommand(query, connection);
                    }
                    else if (dateValue.Length <= 10 && dateValue.Length > 4)
                    {
                        //filter by specific date
                        string query = "SELECT * FROM " + reportTableName + @" WHERE CAST(dateSold as Date) = CAST('" + dateValue + @"' as Date) ;";
                        cmd = new SqlCommand(query, connection);
                    }
                    else if (input.Length > 0)
                    {
                        //filter by search strings
                        string query = "SELECT * FROM " + reportTableName + @" WHERE saleId LIKE '%" + input + "%' OR custName LIKE '%" + input + "%' OR custPhone LIKE '%" + input + "%';";
                        cmd = new SqlCommand(query, connection);
                    }
                    else
                    {
                        //show all
                        cmd = new SqlCommand("SELECT * FROM " + reportTableName, connection);
                    }

                    try
                    {
                        connection.Open();

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        data = new DataSet();
                        adapter.Fill(data, reportTableName);

                        reportView.DataSource = data.Tables[reportTableName].DefaultView;
                        reportView.Sort(reportView.Columns["saleId"], ListSortDirection.Descending);

                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to load sales report data!");
                    }
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Report table was not found!");
            }
        }

        private void dateInput_ValueChanged(object sender, EventArgs e)
        {
            searchInput.Clear();
            filterOptionsBox.SelectedIndex = 0;
            loadData("", dateInput.Value.ToShortDateString());
        }

        private void filterOptionsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Guna2ComboBox combo = (Guna2ComboBox)sender;
            int selectedIndex = combo.SelectedIndex;
            switch (selectedIndex)
            {
                case 0:
                    {
                        searchInput.Clear();
                        loadData("", dateInput.Value.ToShortDateString());
                        break;
                    }
                case 1:
                    {
                        searchInput.Clear();
                        loadData("", dateInput.Value.Month.ToString());
                        break;
                    }
                case 2:
                    {
                        searchInput.Clear();
                        loadData("", dateInput.Value.Year.ToString());
                        break;
                    }
                default:
                    return;
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            filterOptionsBox.SelectedIndex = -1;
            loadData(searchInput.Text.Trim());
        }

        private void reportView_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                updateBusinessResults();
            }
            catch
            {
                MessageBoxer.showErrorMsg("Error occured during calculations!");
            }
        }

        private void updateBusinessResults()
        {
            List<double> buyPriceTotals = data.Tables[reportTableName].AsEnumerable().Select(row => row.Field<double>("buyPriceTotal")).ToList();
            List<double> subTotals = data.Tables[reportTableName].AsEnumerable().Select(row => row.Field<double>("subTotal")).ToList();
            List<double> discounts = data.Tables[reportTableName].AsEnumerable().Select(row => row.Field<double>("discount")).ToList();
            List<double> netTotals = data.Tables[reportTableName].AsEnumerable().Select(row => row.Field<double>("netTotal")).ToList();
            List<double> dues = data.Tables[reportTableName].AsEnumerable().Select(row => row.Field<double>("due")).ToList();

            double totalInvestment = 0, totalSale = 0, totalDue = 0, totalNet = 0;

            for (int i = 0; i < subTotals.Count; i++)
            {
                totalInvestment += buyPriceTotals[i];
                totalSale = totalSale + (subTotals[i] - discounts[i]);
                totalNet += netTotals[i];
                totalDue += dues[i];
            }

            totalInvestLabel.Text = Math.Round(totalInvestment, 2, MidpointRounding.AwayFromZero).ToString();
            totalSaleLabel.Text = Math.Round(totalSale, 2, MidpointRounding.AwayFromZero).ToString();
            totalDueLabel.Text = Math.Round(totalDue, 2, MidpointRounding.AwayFromZero).ToString();
            totalProfitLabel.Text = Math.Round(totalSale - totalInvestment, 2, MidpointRounding.AwayFromZero).ToString();
            totalVatLabel.Text = Math.Round(totalNet - totalSale, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void showAllDataBtn_Click(object sender, EventArgs e)
        {
            filterOptionsBox.SelectedIndex = -1;
            searchInput.Clear();
            loadData();
        }

        private void totalInvestBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("Your investment behind the sold products.\nCalculated as Sum of Buy price totals.", (Guna2GroupBox)sender, 5000);
        }

        private void totalSalesBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("Yours income from the sold products excluding VAT.\nCalculated as Sum of (Sub totals - Total discounts).", (Guna2GroupBox)sender, 5000);
        }

        private void totalDuesBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("The amount still your specific customer(s) need(s) to pay you.\nCalculated as Sum of Dues : (Net totals - Paid amounts).", (Guna2GroupBox)sender, 5000);
        }

        private void totalProfitBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("The profit you got from the sold products.\nCalculated as (Total sales - Total investment).", (Guna2GroupBox)sender, 5000);
        }

        private void totalVatBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip.Show("The amount you need to pay the Government as VAT.\nCalculated as (Sum of Net totals - Total sales).", (Guna2GroupBox)sender, 5000);
        }

        private void reportView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = (DataGridViewRow)reportView.Rows[e.RowIndex];

            if (row.Cells["saleId"].Value.ToString().Length <= 0)
            {
                return;
            }

            SaleData saleData = new SaleData(storeId, row.Cells["saleId"].Value.ToString());
            saleData.ShowDialog();
        }

    }
}
