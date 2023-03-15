using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDFTest1
{
    public class commonMethods
    {
        public string a;

        public static string DataFilePath()
        {
            string basepath = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin", "").Replace("\\Debug", "\\");
            basepath = string.Join(basepath, "\\", ConfigurationManager.AppSettings["DataFile"].ToString());
            return basepath;
        }
    }
}
