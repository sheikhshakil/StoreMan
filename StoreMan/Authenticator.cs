using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class Authenticator : Form
    {
        public Authenticator(string why)
        {
            InitializeComponent();
            infoText.Text += why;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (passwordInput.Text.Length > 0)
            {
                if (authenticate(passwordInput.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Enter admin password!");
            }
        }

        public static bool authenticate(string inputPass)
        {
            if (DbHelper.doesTableExist("admin"))
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT password FROM admin WHERE username = 'admin';", connection);
                        string password = (string)cmd.ExecuteScalar();
                        connection.Close();
                        if (Encryption.Decrypt(password).Equals(inputPass))
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

    }
}
