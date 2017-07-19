using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Libraries.Init;
using ToolsQA.Interfaces.HelloPay;
using System.Threading;

namespace ToolsQA.Libraries.Functions.HelloPay
{
    class F_Navigation
    {
        /// <summary>
        /// Navigate to HelloPay
        /// </summary>
        public static void Navigate_HelloPay()
        {
            ConstantPara.driver.Navigate().GoToUrl(ConstantPara.URL_HelloPay);
        }

    }
}
