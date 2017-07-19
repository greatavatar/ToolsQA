using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.HelloPay
{
    public static class I_ResetPassword
    {
        
        public static By txt_NewPassword = By.XPath("//input[@id='newPassword']");

        public static By btn_ResetPassword = By.XPath("//input[contains(@value,'Reset Password')]");
        
        public static By lbl_ResetPasswordSuccessfully = By.XPath("//section[@id='welcomeHeader']/div[text()='Your password has been successfully reset.']");
       
    }
}
