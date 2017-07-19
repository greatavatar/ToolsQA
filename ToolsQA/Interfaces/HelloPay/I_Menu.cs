using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.HelloPay
{
    class I_Menu
    {


        public static By btn_Register = By.XPath("//a[@class ='smallButton'][text()='Register']");

        //public static By lnk_Login = By.XPath("//a[text()='Login']");

        public static By lnk_Login = By.XPath("//nav[@class='subNav']//a[text()='Login']");



    }
}
