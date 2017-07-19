using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace ToolsQA.Libraries.Init
{
    class ConstantPara
    {
        //public const string Init_Folder = @"..\..\..\ToolsQA\Libraries\Init\";
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static int TimeOut = 30;
        public static string URL_Lazada = "https://www.lazada.vn";
        public static string URL_HelloPay = "https://www.alipay.com.sg";


        public static string Username;
        public static string Password;
        public static string DB_Server;
        public static string DB_Database;
        public static string DB_Username;
        public static string DB_Password;
        public static string ConnectionString
        {
            get
            {
                return "Data Source=" + DB_Server + ";Initial Catalog=" + DB_Database + ";User ID=" + DB_Username + ";Password=" + DB_Password;
            }
        }

    }
}
