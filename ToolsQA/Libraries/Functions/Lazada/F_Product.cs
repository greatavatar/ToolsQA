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
    class F_Product
    {

        /// <summary>
        /// Searh products by Search textbox
        /// </summary>
        /// <param name="pSearchText">Name of account</param>
        public static void Search_Product(string pSearchText)
        {
            
            F_General.SendKey(I_Menu.txt_Search, pSearchText);
            F_General.Click(I_Menu.btn_Search);
            
        }
    }
}
