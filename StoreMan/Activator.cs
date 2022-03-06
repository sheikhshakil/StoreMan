using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class Activator : Form
    {
        private static string ck = Encryption.Encrypt("key");
        private static string ct = Encryption.Encrypt("keyType");
        private static string cv = Encryption.Encrypt("validity");

        public Activator()
        {
            InitializeComponent();

            Dictionary<string, string> actData = getActivationData();
            if (actData.Count == 3 && actData["keyType"] == "trial")
            {
                typeChoiceBox.SelectedIndex = 1;
            }
        }

        private async void activateStoreMan(string type, string key)
        {
            JObject jsonData = new JObject();
            jsonData.Add("key", key);
            jsonData.Add("keyType", type);

            string url = @"https://storemanweb.herokuapp.com/api/verifyKey";

            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.PostAsync(url, new StringContent(jsonData.ToString(), Encoding.UTF8, "application/json"));

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        setActivationData(key, type);
                        MessageBoxer.showGeneralMsg("Thank you for choosing StoreMan. This app is now activated for current user.");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBoxer.showErrorMsg("Activation failed! Please ensure that you entered a valid key.");
                        indicateLoadingFinished();
                    }
                }
                catch
                {
                    MessageBoxer.showErrorMsg("Error in processing activation data! Make sure you have an active internet connection.");
                    indicateLoadingFinished();
                }
            }

        }

        private void setActivationData(string key, string keyType)
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\smtc");

            if (keyType == "trial")
            {
                DateTime upto = DateTime.Now.AddDays(7); //add 7days trial

                regKey.SetValue(ck, Encryption.Encrypt(key));
                regKey.SetValue(ct, Encryption.Encrypt(keyType));
                regKey.SetValue(cv, Encryption.Encrypt(upto.ToString()));
            }
            else if (keyType == "lifetime")
            {
                regKey.SetValue(ck, Encryption.Encrypt(key));
                regKey.SetValue(ct, Encryption.Encrypt(keyType));
                regKey.SetValue(cv, Encryption.Encrypt("lifetime"));
            }

            regKey.Close();
        }

        public static Dictionary<string, string> getActivationData()
        {
            Dictionary<string, string> actData = new Dictionary<string, string>();

            try
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\smtc");

                if (regKey != null)
                {
                    actData.Add("key", Encryption.Decrypt((string)regKey.GetValue(ck)));
                    actData.Add("keyType", Encryption.Decrypt((string)regKey.GetValue(ct)));
                    actData.Add("validity", Encryption.Decrypt((string)regKey.GetValue(cv)));
                }
            }
            catch
            {
                MessageBoxer.showErrorMsg("Failed to get activation data!");
            }

            return actData;
        }

        public static bool checkActivation()
        {
            try
            {
                Dictionary<string, string> actData = getActivationData();

                if (actData.Count == 3)
                {
                    if (actData["keyType"] == "trial" && actData["key"].Length > 15)
                    {
                        DateTime today = DateTime.Now;
                        DateTime upto = Convert.ToDateTime(actData["validity"]);

                        if (today > upto)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else if (actData["keyType"] == "lifetime" && actData["key"].Length > 15)
                    {
                        return true;
                    }
                    else return false;
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

        private void activatorBtn_Click(object sender, EventArgs e)
        {
            if (typeChoiceBox.SelectedIndex > -1 && keyInput.Text.Trim().Length > 15)
            {
                indicateLoading();

                if (typeChoiceBox.SelectedIndex == 0)
                {
                    if (hasAlreadyTried())
                    {
                        MessageBoxer.showErrorMsg("You have already tried the app. No more trials available!");
                        indicateLoadingFinished();
                        return;
                    }
                    else
                    {
                        activateStoreMan("trial", keyInput.Text.Trim());
                    }
                }
                else if (typeChoiceBox.SelectedIndex == 1)
                {
                    activateStoreMan("lifetime", keyInput.Text.Trim());
                }
            }
            else
            {
                MessageBoxer.showErrorMsg("Please enter a valid activation key!");
            }
        }

        private bool hasAlreadyTried()
        {
            Dictionary<string, string> actData = getActivationData();
            if (actData.Count == 3 && actData["key"].Length > 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void indicateLoading()
        {
            activatorBtn.Enabled = false;
            activatorBtn.Text = "Verifying...";
        }

        private void indicateLoadingFinished()
        {
            activatorBtn.Enabled = true;
            activatorBtn.Text = "Activate";
        }
    }
}
