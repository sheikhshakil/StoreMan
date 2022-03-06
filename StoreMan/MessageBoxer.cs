using System.Windows.Forms;

namespace StoreMan
{
    class MessageBoxer
    {
        public static void showErrorMsg(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void showGeneralMsg(string msg)
        {
            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool isConfirm(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        public static bool generalConfirmation(string msg)
        {
            DialogResult result = MessageBox.Show(msg, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
    }
}
