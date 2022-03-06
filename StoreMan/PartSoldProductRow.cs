using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMan
{
    public partial class PartSoldProductRow : UserControl
    {
        Dictionary<string, string> pData;

        public PartSoldProductRow(Dictionary<string, string> pData)
        {
            InitializeComponent();
            this.pData = pData;
            handleDataSetup();
        }

        private void handleDataSetup()
        {
            pCodeText.Text = pData["pCode"];
            pNameText.Text = pData["pName"];
            bppuText.Text = pData["bppu"];
            sppuText.Text = pData["sppu"];
            quantityText.Text = pData["qty"];
        }
    }
}
