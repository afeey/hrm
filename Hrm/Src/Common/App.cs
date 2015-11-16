using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace Hrm.Common
{
    public class App
    {
        private static string _connectString = "";

        public static string ConnectString
        {
            get
            {
                if (_connectString.Length == 0)
                {
                    _connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\" + ConfigurationSettings.AppSettings["database"].ToString();
                }

                return _connectString;
            }
        }
    }
}
