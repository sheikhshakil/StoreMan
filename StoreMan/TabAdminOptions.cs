using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class TabAdminOptions : UserControl
    {
        private string storeId = null;
        public TabAdminOptions(string storeId)
        {
            InitializeComponent();
            this.storeId = storeId;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            string oldPass = oldPassInput.Text.Trim(), newPass = newPassInput.Text.Trim();

            if (oldPass.Length > 0 && newPass.Length > 0)
            {
                //proceed
                if (Validator.validate_adminPass(newPass))
                {
                    if (Authenticator.authenticate(oldPass))
                    {
                        //change pass
                        string encryptedPass = Encryption.Encrypt(newPass);
                        using (SqlConnection connection = DbHelper.getConnection())
                        {
                            try
                            {
                                connection.Open();
                                SqlCommand cmd = new SqlCommand(@"UPDATE admin SET password = @newPass WHERE username = 'admin';", connection);
                                cmd.Parameters.AddWithValue("newPass", encryptedPass);
                                cmd.ExecuteNonQuery();
                                connection.Close();
                                MessageBoxer.showGeneralMsg("Admin password is successfully updated.");
                            }
                            catch
                            {
                                MessageBoxer.showErrorMsg("Failed to update admin password!");
                            }
                        }
                    }
                    else
                    {
                        MessageBoxer.showErrorMsg("Authentication failed! Make sure old password is correct.");
                    }
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Both fields are required!");
            }
        }

        private void updateStoreBtn_Click(object sender, EventArgs e)
        {
            if (updateChoiceBox.SelectedIndex >= 0 && getSanitizedUpdateInput().Length > 0)
            {
                switch (updateChoiceBox.SelectedIndex)
                {
                    case 0:
                        {
                            //store name
                            if (getSanitizedUpdateInput().Length >= 3)
                            {
                                //update value
                                storeValueUpdater("storeName", getSanitizedUpdateInput());
                            }
                            else
                            {
                                MessageBoxer.showErrorMsg("Store name should be minimum 3 characters!");
                            }

                            break;
                        }
                    case 1:
                        {
                            //store desc
                            storeValueUpdater("storeDes", getSanitizedUpdateInput());
                            break;
                        }
                    case 2:
                        {
                            //store addr
                            storeValueUpdater("storeAddr", getSanitizedUpdateInput());
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Please specify update values!");
            }
        }

        private string getSanitizedUpdateInput()
        {
            return updateValueInput.Text.Trim();
        }

        private void storeValueUpdater(string key, string value)
        {
            Authenticator authenticator = new Authenticator("update specified value of this store.");
            var result = authenticator.ShowDialog();
            if (result == DialogResult.OK)
            {
                //update value
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE stores SET " + key + @" = @value WHERE storeId=@storeId;", connection);
                        cmd.Parameters.AddWithValue("value", value);
                        cmd.Parameters.AddWithValue("storeId", storeId);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBoxer.showGeneralMsg("Specified value is successfully updated.");
                        StoreOptions.options.showStoreDetails();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to update specified value!");
                    }
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Authentication failed! Update task aborted.");
            }
        }

        private void clearPassFieldsBtn_Click(object sender, EventArgs e)
        {
            oldPassInput.Clear();
            newPassInput.Clear();
        }

        private void clearStoreUpdateFieldsBtn_Click(object sender, EventArgs e)
        {
            updateChoiceBox.SelectedIndex = -1;
            updateValueInput.Clear();
        }

        private void deleteInventoryBtn_Click(object sender, EventArgs e)
        {
            Authenticator authenticator = new Authenticator("delete all data in inventory.");
            var result = authenticator.ShowDialog();
            if (result == DialogResult.OK)
            {
                //delete
                bool isConfirm = MessageBoxer.isConfirm("All inventory data of this store will be deleted! Are you sure?");
                if (isConfirm)
                {
                    using (SqlConnection connection = DbHelper.getConnection())
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE inventory_" + storeId + ";", connection);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBoxer.showGeneralMsg("All inventory data of this store is deleted.");
                        }
                        catch
                        {
                            MessageBoxer.showErrorMsg("Failed to delete inventory data!");
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
                MessageBoxer.showErrorMsg("Authentication failed! Aborted inventory deletion task!");
            }
        }

        private void deleteReportsBtn_Click(object sender, EventArgs e)
        {
            Authenticator authenticator = new Authenticator("delete all sales report entries.");
            var result = authenticator.ShowDialog();
            if (result == DialogResult.OK)
            {
                //delete
                bool isConfirm = MessageBoxer.isConfirm("All sales report of this store will be deleted! Are you sure?");
                if (isConfirm)
                {
                    using (SqlConnection connection = DbHelper.getConnection())
                    {
                        try
                        {
                            connection.Open();
                            SqlCommand cmd = new SqlCommand("TRUNCATE TABLE salesReport_" + storeId + ";", connection);
                            cmd.ExecuteNonQuery();
                            connection.Close();
                            MessageBoxer.showGeneralMsg("All sales report of this store is deleted.");
                        }
                        catch
                        {
                            MessageBoxer.showErrorMsg("Failed to delete sales report data!");
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
                MessageBoxer.showErrorMsg("Authentication error! Aborted sales report deletion task.");
            }
        }
    }
}
