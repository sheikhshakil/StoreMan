using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            handleInitialTasks();
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            getStoresList();
        }

        private void handleInitialTasks()
        {
            if (Activator.checkActivation())
            {
                if (!DbHelper.doesTableExist("stores"))
                {
                    setupTable();
                }
                setControlsEnabled(true);
                updateActivationFooter();
            }
            else
            {
                setControlsEnabled(false);
            }
        }

        private void updateActivationFooter()
        {
            Dictionary<string, string> actData = Activator.getActivationData();

            if (actData.Count == 3 && actData["key"].Length > 15)
            {
                if (actData["keyType"] == "lifetime")
                {
                    activateBtn.Visible = false;
                    activationIcon.Image = Properties.Resources.premium;
                    activationInfo.Text = "Activated for lifetime.";
                }
                else if (actData["keyType"] == "trial")
                {
                    activateBtn.Text = "Upgrade to lifetime";
                    activationIcon.Image = Properties.Resources.trial;
                    activationInfo.Text = "Trial activated until " + actData["validity"] + ".";
                }
            }
        }

        private void setControlsEnabled(bool value)
        {
            getStartedBox.Enabled = value;
            storesListBox.Enabled = value;
        }

        private void getStoresList()
        {
            storesLayout.Controls.Clear();
            List<string> storeNames = new List<string>();
            List<int> storeIds = new List<int>();

            if (DbHelper.doesTableExist("stores"))
            {
                using (SqlConnection connection = DbHelper.getConnection())
                {
                    try
                    {
                        connection.Open();

                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM stores", connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            storeIds.Add(Convert.ToInt32(reader["storeId"]));
                            storeNames.Add(reader["storeName"].ToString());
                        }

                        connection.Close();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to read stores list!");
                    }

                }
            }

            showStoresList(storeIds, storeNames);
        }

        private void showStoresList(List<int> storeIds, List<string> storeNames)
        {
            if (storeIds.Count > 0)
            {
                int posX = 0, posY = 0;
                for (int i = 0; i < storeIds.Count; i++, posY += 65)
                {
                    Guna2Button btn = new Guna2Button();
                    btn.Name = storeIds[i].ToString();
                    btn.Text = storeNames[i];

                    btn.Size = new Size(storesLayout.Width, 55);
                    btn.Location = new Point(posX, posY);

                    btn.FillColor = Color.LightGreen;
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font("Segoe UI", 10F);
                    btn.AutoRoundedCorners = true;
                    btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

                    btn.Click += new EventHandler(handleStoreBtn);

                    storesLayout.Controls.Add(btn);
                }
            }
            else
            {
                Label label = new Label();
                label.Text = "No stores in the database. Create one first.";
                label.Dock = DockStyle.Fill;
                label.AutoSize = false;
                label.TextAlign = ContentAlignment.MiddleCenter;

                storesLayout.Controls.Add(label);
            }

        }

        private void handleStoreBtn(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            string id = btn.Name;

            this.Hide();

            StoreOptions storeOptions = new StoreOptions(id);
            storeOptions.Show();

            storeOptions.FormClosed += new FormClosedEventHandler(showThisForm);
        }

        private void showThisForm(object sender, FormClosedEventArgs e)
        {
            this.Show();
            getStoresList();
        }

        private void setupTable()
        {
            using (SqlConnection connection = DbHelper.getConnection())
            {
                try
                {
                    connection.Open();

                    SqlCommand createStoresTable = new SqlCommand(@"CREATE TABLE stores (storeId INT NOT NULL PRIMARY KEY IDENTITY(1,1), storeName VARCHAR(500) NOT NULL, storeDes VARCHAR(1000) NOT NULL, storeAddr VARCHAR(5000) NOT NULL);", connection);

                    createStoresTable.ExecuteNonQuery();
                    connection.Close();
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Stores table creation failed!");
                }

            }
        }

        private void createStoreBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DbHelper.getConnection())
            {
                string storeName = storeNameInput.Text.Trim();
                string storeDes = storeDesInput.Text.Trim();
                string storeAddr = storeAddrInput.Text.Trim();

                if (storeName.Length >= 3 && storeDes.Length > 0 && storeAddr.Length > 0)
                {
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(@"INSERT INTO stores (storeName, storeDes, storeAddr) VALUES (@storeName, @storeDes, @storeAddr);", conn);

                        cmd.Parameters.AddWithValue("storeName", storeName);
                        cmd.Parameters.AddWithValue("storeDes", storeDes);
                        cmd.Parameters.AddWithValue("storeAddr", storeAddr);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBoxer.showGeneralMsg("Successfully created a store");
                        getStoresList();
                    }
                    catch
                    {
                        MessageBoxer.showErrorMsg("Failed to create a store!");
                    }

                }
                else
                {
                    MessageBoxer.showErrorMsg("Please fillup all fields with a Store name of minimum 3 characters!");
                }
            }
        }

        private void clearFieldsBtn_Click(object sender, EventArgs e)
        {
            storeNameInput.Clear();
            storeDesInput.Clear();
            storeAddrInput.Clear();
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            Activator activator = new Activator();
            var result = activator.ShowDialog();

            if (result == DialogResult.OK)
            {
                handleInitialTasks();
            }
        }
    }
}
