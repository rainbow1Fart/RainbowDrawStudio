using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RainbowDrawStudio
{
    public class ControlHelper
    {
        public ControlHelper()
        {

        }
        ~ControlHelper()
        {

        }

        public static XtraMessageBoxArgs XtraMessageBoxArgs(string Caption, string Text,
            DialogResult[] DialogResult,
            Int32 Delay = 5000, 
            int DefaultButtonIndex = 0, 
            bool ShowTimerOnDefaultButton = true)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = Caption;
            args.Text = Text;
            args.AutoCloseOptions.Delay = Delay;
            args.DefaultButtonIndex = DefaultButtonIndex;
            args.AutoCloseOptions.ShowTimerOnDefaultButton = ShowTimerOnDefaultButton;
            args.Buttons = DialogResult;
            return args;
        }
    }
}
