using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.Lazada
{
    public static class I_Register
    {
        public static By rad_Nam = By.XPath("//input[contains(@id,'RegistrationForm_gender')][@value='male']");
        public static By rad_Nu = By.XPath("//input[contains(@id,'RegistrationForm_gender')][@value='female']");

        public static By txt_Email = By.XPath("//input[@id='RegistrationForm_email']");
        public static By txt_Ten = By.XPath("//input[@id='RegistrationForm_first_name']");
        public static By txt_MatKhau = By.XPath("//input[@id='RegistrationForm_password']");
        public static By txt_NhapLaiMatKhau = By.XPath("//input[@id='RegistrationForm_password2']");

        public static By chk_DongY = By.XPath(" //input[@id='RegistrationForm_is_newsletter_subscribed'][@type='checkbox']");

        public static By cmb_Ngay = By.XPath("//select[@id='RegistrationForm_day']");
        public static By cmb_Thang = By.XPath("//select[@id='RegistrationForm_month']");
        public static By cmb_Nam = By.XPath("//select[@id='RegistrationForm_year']");

        public static By btn_Gui = By.XPath("//button[@id='send']");

    }
}
