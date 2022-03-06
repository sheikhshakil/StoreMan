using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class TabInventory : UserControl
    {
        private string tableName = null, storeId = null;
        public static TabInventory inventory = null;

        public TabInventory(string storeId)
        {
            InitializeComponent();

            inventory = this;
            this.storeId = storeId;
            tableName = "inventory_" + storeId;
        }

        private void InventoryTab_Load(object sender, EventArgs e)
        {
            loadData();
        }

        // overloaded function for also providing search functionality
        private void loadData(string searchValue = "", string qty = "")
        {
            if (DbHelper.doesTableExist(tableName))
            {
                SqlDataAdapter adapter;

                using (SqlConnection connection = DbHelper.getConnection())
                {
                    if (searchValue.Length >= 2)
                    {
                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM " + tableName + @" WHERE pName LIKE '%" + searchValue + "%' OR pCode LIKE '%" + searchValue + "%';", connection);

                        adapter = new SqlDataAdapter(cmd);
                    }
                    else if (qty.Length > 0)
                    {
                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM " + tableName + @" WHERE quantity <= " + qty, connection);

                        adapter = new SqlDataAdapter(cmd);
                    }
                    else
                    {
                        adapter = new SqlDataAdapter(@"SELECT * FROM " + tableName, connection);
                    }
                    try
                    {
                        connection.Open();
                        DataSet data = new DataSet();
                        adapter.Fill(data, tableName);

                        inventoryView.DataSource = data.Tables[tableName].DefaultView;
                        inventoryView.Sort(inventoryView.Columns["pId"], ListSortDirection.Descending);
                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Couldn't read inventory data!");
                    }
                }
            }
        }

        private void saveProductBtn_Click(object sender, EventArgs e)
        {
            if (DbHelper.doesTableExist(tableName)
                && Validator.validate_pName(pNameInput.Text.Trim())
                && Validator.validate_quantity(quantityInput.Text.Trim())
                && Validator.validate_ppu(bppuInput.Text.Trim())
                && Validator.validate_ppu(sppuInput.Text.Trim())
                )
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();
                        string cmdText = "INSERT INTO " + tableName + @" (photo, pCode, pName, quantity, bppu, sppu) VALUES (@photo, @pCode, @pName, @quantity, @bppu, @sppu);";

                        SqlCommand cmd = new SqlCommand(cmdText, connection);

                        cmd.Parameters.AddWithValue("photo", processImage());
                        cmd.Parameters.AddWithValue("pCode", pCodeInput.Text.Trim());
                        cmd.Parameters.AddWithValue("pName", pNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("quantity", Math.Round(Convert.ToDouble(quantityInput.Text.Trim()), 2, MidpointRounding.AwayFromZero));
                        cmd.Parameters.AddWithValue("bppu", Math.Round(Convert.ToDouble(bppuInput.Text.Trim()), 2, MidpointRounding.AwayFromZero));
                        cmd.Parameters.AddWithValue("sppu", Math.Round(Convert.ToDouble(sppuInput.Text.Trim()), 2, MidpointRounding.AwayFromZero));

                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBoxer.showGeneralMsg("Data saved successfully");
                        loadData();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to save data!");
                    }
                }
            }
        }

        private void inventoryView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == inventoryView.Rows[e.RowIndex].Cells["photo"].ColumnIndex)
            {
                string pId = inventoryView.Rows[e.RowIndex].Cells["pId"].Value.ToString();

                if (pId.Length > 0)
                {
                    ProductView view = new ProductView(pId, storeId);
                    view.ShowDialog();
                    loadData();
                }
            }
            else if (e.RowIndex >= 0)
            {
                //update products list in cart
                string pId = inventoryView.Rows[e.RowIndex].Cells["pId"].Value.ToString();

                if (isProductPresentInCart(pId))
                {
                    notiBar.Text = "Product is already in cart!";
                }
                else
                {
                    if (Convert.ToDouble(inventoryView.Rows[e.RowIndex].Cells["quantity"].Value.ToString()) > 0)
                    {
                        Dictionary<string, string> pData = new Dictionary<string, string>();
                        pData.Add("pId", pId);
                        pData.Add("pName", inventoryView.Rows[e.RowIndex].Cells["pName"].Value.ToString());
                        pData.Add("pCode", inventoryView.Rows[e.RowIndex].Cells["pCode"].Value.ToString());
                        pData.Add("bppu", inventoryView.Rows[e.RowIndex].Cells["bppu"].Value.ToString());
                        pData.Add("sppu", inventoryView.Rows[e.RowIndex].Cells["sppu"].Value.ToString());
                        pData.Add("qty", "1");

                        TabBatchSale.listOfProductsData.Add(pData);

                        notiBar.Text = pData["pCode"] + " - Product is successfully added to cart. Use Batch Sale to sell.";
                    }
                    else
                    {
                        notiBar.Text = "Product is not available in stock.";
                    }
                }
            }
        }

        //to check if product is already in cart
        private bool isProductPresentInCart(string pId)
        {
            int flag = 0;
            for (int i = 0; i < TabBatchSale.listOfProductsData.Count; i++)
            {
                if (TabBatchSale.listOfProductsData[i]["pId"].Equals(pId))
                {
                    ++flag;
                }
            }

            if (flag == 0)
                return false;
            else
                return true;
        }

        public double getProductStock(string pId)
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT quantity FROM " + tableName + @" WHERE pId = @pId;", connection);
                    cmd.Parameters.AddWithValue("pId", pId);
                    double stock = (double)cmd.ExecuteScalar();
                    connection.Close();

                    return stock;
                }
                catch
                {
                    return 0;
                }
            }
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            if (searchInput.Text.Trim().Length > 0)
            {
                searchByQtyInput.Clear();
                if (searchInput.Text.Trim().Length > 2)
                {
                    loadData(searchInput.Text.Trim());
                }
            }
            else
            {
                loadData();
            }
        }

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            pCodeInput.Clear();
            pNameInput.Clear();
            quantityInput.Clear();
            bppuInput.Clear();
            sppuInput.Clear();
            photoInput.Image = Properties.Resources.sampleProduct;
        }

        private void choosePhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoInput.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch
            {
                MessageBoxer.showErrorMsg("Failed to select photo!");
            }
        }

        private void searchByQtyInput_TextChanged(object sender, EventArgs e)
        {
            if (searchByQtyInput.Text.Trim().Length > 0)
            {
                searchInput.Clear();
                string text = searchByQtyInput.Text.Trim();
                try
                {
                    Convert.ToDouble(text);

                    //quantity is double.
                    loadData("", text);
                }
                catch
                {
                    searchByQtyInput.Clear();
                    loadData();
                }
            }
            else
            {
                loadData();
            }
        }

        //convert pb image to byte array
        private byte[] processImage()
        {
            MemoryStream stream = new MemoryStream();
            if (photoInput.Image != null)
            {
                try
                {
                    photoInput.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                }
                catch
                {
                    MessageBoxer.showErrorMsg("Product photo processing failed!");
                }

            }
            return stream.ToArray();
        }
    }
}
