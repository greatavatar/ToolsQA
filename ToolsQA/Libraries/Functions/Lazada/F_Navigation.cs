using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Libraries.Init;
using ToolsQA.Interfaces.Lazada;
using System.Threading;

namespace ToolsQA.Libraries.Functions.Lazada
{
    class F_Navigation
    {
        /// <summary>
        /// Navigate to Lazada
        /// </summary>
        public static void Navigate_Lazada()
        {
            ConstantPara.driver.Navigate().GoToUrl(ConstantPara.URL_Lazada);
        }

    }
}
