using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.HelloPay
{
    public static class I_ForgotPassword
    {
        
        public static By txt_EmailAdress = By.XPath("//input[@id='uid']");

        public static By btn_ResetYourPassword = By.XPath("//input[contains(@value,'Reset Your Password')]");

        
    }
}
