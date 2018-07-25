using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEngineer
{
    class AccessLayer
    {
        public static string CsvPath()
        {
            try
            {
                return System.Configuration.ConfigurationManager.AppSettings["Disk"] + System.Configuration.ConfigurationManager.AppSettings["FileName"];
            }
            catch
            {
                return "";
            }
        }

        public static string CsvSource()
        {
            try
            {
                return System.Configuration.ConfigurationManager.AppSettings["Source"] + System.Configuration.ConfigurationManager.AppSettings["FileSource"];
            }
            catch
            {
                return "";
            }
        }
    }
}
