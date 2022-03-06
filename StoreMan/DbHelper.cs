using System;
using System.Data.SqlClient;

namespace StoreMan
{
    class DbHelper
    {
        public static SqlConnection getConnection()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StoreManData\Database.mdf;Integrated Security=True

            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\Database.mdf"";Integrated Security=True

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\StoreManData\Database.mdf;Integrated Security=True";

            return connection;
        }

        public static bool doesTableExist(string tableName)
        {
            using (SqlConnection conn = getConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"IF OBJECT_ID(@tableName) IS NOT NULL SELECT 1 ELSE SELECT 0", conn);
                    cmd.Parameters.AddWithValue("tableName", tableName);

                    int res = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();

                    if (res == 1)
                        return true;
                    else
                        return false;
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Database initialization failed! Please restart your PC.");
                    return false;
                }
            }
        }
    }
}
