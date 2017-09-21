using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGP.Helpers
{
    public class Helper
    {
        public static DialogResult Ask(string message = "")
        {
            return MessageBox.Show(message, "SGP", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        public static DialogResult Message(string message = "",  MessageBoxButtons buttons = MessageBoxButtons
            .OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            return MessageBox.Show(message, "SGP", buttons, icon);
        }
    }
}
