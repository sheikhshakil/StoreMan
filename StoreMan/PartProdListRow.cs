using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class PartProdListRow : UserControl
    {
        private Dictionary<string, string> pData = null;
        private int serial = -1;

        public PartProdListRow(Dictionary<string, string> pData, int serial)
        {
            InitializeComponent();

            this.pData = pData;
            this.serial = serial;

            handleInitialTasks();
        }

        private void handleInitialTasks()
        {
            serialText.Text = serial.ToString();
            pNameText.Text = pData["pName"];
            pCodeText.Text = pData["pCode"];

            quantityInput.Text = pData["qty"];
            quantityInput.TextChanged += new EventHandler(handleQuantityUpdate);
            updateSellPrice();

            deleteProdBtn.Name = pData["pId"];
            quantityInput.Name = pData["pId"];
        }

        private void handleQuantityUpdate(object sender, EventArgs e)
        {
            string pId = ((Guna.UI2.WinForms.Guna2TextBox)sender).Name;
            string input = ((Guna.UI2.WinForms.Guna2TextBox)sender).Text.Trim();

            try
            {
                double qty = Math.Round(Convert.ToDouble(input), 2, MidpointRounding.AwayFromZero);

                for (int i = 0; i < TabBatchSale.listOfProductsData.Count; i++)
                {
                    if (TabBatchSale.listOfProductsData[i]["pId"].Equals(pId))
                    {
                        TabBatchSale.listOfProductsData[i]["qty"] = qty.ToString();
                        TabBatchSale.thisForm.updateOrderSummary();
                        updateSellPrice();
                    }
                }

            }
            catch
            {
                ((Guna.UI2.WinForms.Guna2TextBox)sender).Clear();
                for (int i = 0; i < TabBatchSale.listOfProductsData.Count; i++)
                {
                    if (TabBatchSale.listOfProductsData[i]["pId"].Equals(pId))
                    {
                        TabBatchSale.listOfProductsData[i]["qty"] = "0";
                        TabBatchSale.thisForm.updateOrderSummary();
                        updateSellPrice();
                    }
                }
            }
        }

        private void updateSellPrice()
        {
            try
            {
                sppuText.Text = "Sell price : " + Convert.ToDouble(pData["qty"]) * Convert.ToDouble(pData["sppu"]) + @" /-";
            }
            catch
            {
                sppuText.Text = @"Sell price : 0 /-";
            }
        }

        private void deleteProdBtn_Click(object sender, EventArgs e)
        {
            string pId = ((Guna.UI2.WinForms.Guna2ImageButton)sender).Name;

            for (int i = 0; i < TabBatchSale.listOfProductsData.Count; i++)
            {
                if (TabBatchSale.listOfProductsData[i]["pId"].Equals(pId))
                {
                    TabBatchSale.listOfProductsData.RemoveAt(i);
                    TabBatchSale.thisForm.handleInitialTasks();
                }
            }
        }

    }
}
