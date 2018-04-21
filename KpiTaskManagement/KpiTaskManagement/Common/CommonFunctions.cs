
using System.Windows.Forms;

namespace KpiTaskManagement.Common
{  
    public static class CommonFunctions
    {
        public static void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
