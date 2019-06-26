using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace RDS_Controller
{
    public class LogsHelper
    {
        public LogsHelper()
        {

        }

        ~LogsHelper()
        {

        }


        private static RDS_Controller.ThreadDelegate.ThreadEvent<string, LogsEnum, Exception> OnThreadEvent;

        public static void WriteLog(string caption, LogsEnum logsEnum, Exception exception = null)
        {
            //开启异步线程
            OnThreadEvent = new RDS_Controller.ThreadDelegate.ThreadEvent<string, LogsEnum, Exception>(Write);
            IAsyncResult result = OnThreadEvent.BeginInvoke(caption, logsEnum, exception, WriteCallBack, null);
        }

        protected static void Write(string caption, LogsEnum logsEnum, Exception exception)
        {
            string path = @"./Logs/" + DateTime.Today.ToString("yyyy-MM-dd") + ".txt";

            //如果文件夹不存在,则创建
            if (!Directory.Exists(@"./Logs"))
            {
                Directory.CreateDirectory(@"./Logs");
            }

            FileStream fs;
            FileInfo file = new FileInfo(path);
            fs = file.Open(FileMode.Append, FileAccess.Write);
            switch (logsEnum)
            {
                case LogsEnum.Print:
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("LogsEnum.Print" + caption + "\r\n");
                    }
                    break;
                case LogsEnum.Debug:
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("LogsEnum.Debug" + caption + "\r\n" + exception.StackTrace + "\r\n" + exception.Message + "\r\n");
                    }
                    break;
                case LogsEnum.Warning:
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("LogsEnum.Warning" + caption + "\r\n" + exception.StackTrace + "\r\n" + exception.Message + "\r\n");
                    }
                    break;
                case LogsEnum.Error:
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine("LogsEnum.Error" + caption + "\r\n" + exception.StackTrace + "\r\n" + exception.Message + "\r\n");
                    }
                    break;
                default:break;
                
            }
            fs.Close();
        }

        /// <summary>
        /// 结束线程
        /// </summary>
        /// <param name="result"></param>
        protected static void WriteCallBack(IAsyncResult result)
        {
            OnThreadEvent.EndInvoke(result);
        }
    }


    public enum LogsEnum
    {
        Print,
        Warning,
        Debug,
        Error,
    }
}
