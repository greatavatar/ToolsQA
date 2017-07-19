using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.HelloPay
{
    public static class I_Register
    {
        public static By ddl_Country = By.XPath("//select[@id='countryCode']");

        public static By txt_FullName = By.XPath("//input[@id='fullName']");
        public static By txt_CountryCode = By.XPath("//input[@id='mobilePrefix']");
        public static By txt_PhoneNumber = By.XPath("//input[@id='mobile']");
        public static By txt_Email = By.XPath("//input[@id='email']");
        public static By txt_Password = By.XPath("//input[@id='password']");

        public static By btn_OpenAccountNow = By.XPath("//input[@id='register']");

    }
}
