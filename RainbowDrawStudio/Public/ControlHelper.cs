using System;
using System.Runtime.InteropServices;
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



        ////关于水印控件的一些代码
        //private const uint ECM_FIRST = 0x1500;
        //private const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        //[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        //static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        ///// <summary>
        ///// 为TextEdit设置水印文字
        ///// </summary>
        ///// <param name="textEdit">textEdit</param>
        ///// <param name="watermark">水印文字</param>
        //public static void SetWatermark(this TextEdit textEdit, string watermark)
        //{
        //    SendMessage(textEdit.Handle, EM_SETCUEBANNER, 0, watermark);
        //}
        ///// <summary>
        ///// 清除水印文字
        ///// </summary>
        ///// <param name="textEdit">textEdit</param>
        //public static void ClearWatermark(this TextEdit textEdit)
        //{
        //    SendMessage(textEdit.Handle, EM_SETCUEBANNER, 0, string.Empty);
        //}
    }
}
