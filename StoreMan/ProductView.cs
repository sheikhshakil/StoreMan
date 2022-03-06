using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class ProductView : Form
    {
        private string pId = null;
        private string invTableName = null;

        public ProductView(string pId, string storeId)
        {
            InitializeComponent();

            this.pId = pId;
            invTableName = "inventory_" + storeId;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            showProductData();
        }

        private void showProductData()
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                try
                {
                    connection.Open();
                    string cmdText = "SELECT * FROM " + invTableName + @" WHERE pId=@pId;";
                    SqlCommand cmd = new SqlCommand(cmdText, connection);

                    cmd.Parameters.AddWithValue("pId", pId);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {

                        byte[] picByte = reader["photo"] as byte[] ?? null;
                        MemoryStream stream = new MemoryStream(picByte);
                        photo.Image = Image.FromStream(stream);

                        pCodeText.Text = reader["pCode"].ToString();
                        pNameText.Text = reader["pName"].ToString();
                        quantityText.Text = reader["quantity"].ToString();
                        bppuText.Text = reader["bppu"].ToString();
                        sppuText.Text = reader["sppu"].ToString();
                        dateAddedText.Text = reader["dateAdded"].ToString();

                        break;
                    }

                    connection.Close();
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Failed to load product data!");
                }
            }
        }

        private void updateChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateChoiceBox.SelectedIndex == 5)
            {
                valueInput.Enabled = false;
                choosePhotoBox.Visible = true;
            }
            else
            {
                valueInput.Enabled = true;
                choosePhotoBox.Visible = false;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            switch (updateChoiceBox.SelectedIndex)
            {
                case 0:
                    {
                        //update pCode
                        if (getSanitizedValue().Length > 1)
                        {
                            //update
                            valueUpdater("pCode", getSanitizedValue());
                        }
                        else
                        {
                            MessageBoxer.showErrorMsg("Product code should be minimum 2 characters!");
                        }
                        break;
                    }
                case 1:
                    {
                        if (Validator.validate_pName(getSanitizedValue()))
                        {
                            valueUpdater("pName", getSanitizedValue());
                        }
                        break;
                    }
                case 2:
                    {
                        if (Validator.validate_quantity(getSanitizedValue()))
                        {
                            valueUpdater("quantity", getSanitizedValue());
                        }
                        break;
                    }
                case 3:
                    {
                        if (Validator.validate_ppu(getSanitizedValue()))
                        {
                            valueUpdater("bppu", getSanitizedValue());
                        }
                        break;
                    }
                case 4:
                    {
                        if (Validator.validate_ppu(getSanitizedValue()))
                        {
                            valueUpdater("sppu", getSanitizedValue());
                        }
                        break;
                    }
                case 5:
                    {
                        if (newPhotoInput.Image == null)
                        {
                            MessageBoxer.showErrorMsg("Please select an image for this product to update!");
                        }
                        else
                        {
                            valueUpdater("photo", null, processImage());
                        }
                        break;
                    }
                default:
                    {
                        MessageBoxer.showErrorMsg("Please choose a value type to update");
                        break;
                    }
            }
        }

        private void valueUpdater(string cell, string value = null, byte[] photo = null)
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE " + invTableName + " SET " + cell + @" = @value WHERE pId = @pId;", connection);

                    if (cell.Equals("photo") && photo != null)
                    {
                        cmd.Parameters.AddWithValue("value", photo);
                    }
                    else if (value != null)
                    {
                        cmd.Parameters.AddWithValue("value", value);
                    }

                    cmd.Parameters.AddWithValue("pId", pId);
                    cmd.ExecuteNonQuery();

                    connection.Close();

                    MessageBoxer.showGeneralMsg("Specified data successfully updated.");
                    showProductData();
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Failed to update data!");
                }
            }
        }

        private string getSanitizedValue()
        {
            return valueInput.Text.Trim();
        }

        private void chooseNewPhotoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    newPhotoInput.Image = Image.FromFile(fileDialog.FileName);
                }
            }
            catch
            {
                MessageBoxer.showErrorMsg("Failed to select photo!");
            }
        }

        private void clearUpdateFieldsBtn_Click(object sender, EventArgs e)
        {
            updateChoiceBox.SelectedIndex = -1;
            valueInput.Clear();
            newPhotoInput.Image = null;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool isConfirm;

            isConfirm = MessageBoxer.isConfirm("Do you really want to delete this product?");

            if (isConfirm)
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM " + invTableName + @" WHERE pId=@pId;", connection);
                        cmd.Parameters.AddWithValue("pId", pId);
                        cmd.ExecuteNonQuery();

                        connection.Close();
                        MessageBoxer.showGeneralMsg("Product is deleted successfully.");
                        this.DialogResult = DialogResult.OK;
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to delete the product!");
                    }
                }
            }
        }

        //convert pb image to byte array
        private byte[] processImage()
        {
            MemoryStream stream = new MemoryStream();

            try
            {
                newPhotoInput.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            }
            catch
            {
                MessageBoxer.showErrorMsg("Product photo processing failed!");
            }

            return stream.ToArray();
        }
    }
}
