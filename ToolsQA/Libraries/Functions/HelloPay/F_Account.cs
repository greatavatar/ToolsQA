using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Libraries.Init;
using ToolsQA.Interfaces.HelloPay;
using System.Threading;

namespace ToolsQA.Libraries.Functions.HelloPay
{
    class F_Account
    {

        /// <summary>
        /// Reset Password of a specific Email account
        /// </summary>
        /// <param name="pEmail">Email of account which needed to be reset password </param>
        public static void Reset_Password(string pEmail,string pNewPassord)
        {

            F_General.Click(I_Menu.lnk_Login);
            F_General.Click(I_Login.lnk_ForgotYourPassword);
            F_General.SendKey(I_ForgotPassword.txt_EmailAdress,pEmail);
            F_General.Click(I_ForgotPassword.btn_ResetYourPassword);

            string  mLink = Get_Reset_Password_Link_From_Mail(pEmail);
            ConstantPara.driver.Navigate().GoToUrl(mLink);
            F_General.SendKey(I_ResetPassword.txt_NewPassword,pNewPassord);

            string a= F_General.CaptureInterface(I_ResetPassword.btn_ResetPassword).Text;
     
            F_General.Click(I_ResetPassword.btn_ResetPassword);

        }

        /// <summary>
        /// Get Reset Password code from an email ---Currently using Mailinator for verifications
        /// </summary>
        /// <param name="pEmail">Email to get Reset Password code </param>
        public static string Get_Reset_Password_Link_From_Mail(string pEmail)
        {
            IWebDriver mDriver = new FirefoxDriver();
            mDriver.Url = "https://www.mailinator.com";
            mDriver.Manage().Window.Maximize();

            

            /*mDriver.FindElement(By.XPath("//a[text()='Email']")).Click();
            mDriver.FindElement(By.XPath("//input[@id='publicinboxfield']")).SendKeys(pEmail);
            mDriver.FindElement(By.XPath("//div[@class='input-group-btn']/button")).Click();*/

            mDriver.FindElement(By.XPath("//input[@id='inboxfield']")).SendKeys(pEmail);
            mDriver.FindElement(By.XPath("//button[contains(text(),'Go!')]")).Click();
            
            F_General.WaitForControlExist(mDriver, " //ul[@id='inboxpane']/li[1]", 30);
           

            IList<IWebElement> Ilist_Address = mDriver.FindElements(By.XPath("//ul[@id='inboxpane']//following-sibling::li/div/div[3]"));
            IList<IWebElement> Ilist_Link = mDriver.FindElements(By.XPath("//ul[@id='inboxpane']//following-sibling::li/div/div[4]"));
            
            for (int i = 0; i < Ilist_Address.Count; i++)
            {
                if (Ilist_Address[i].Text.Contains("Alipay Service") && Ilist_Link[i].Text.Contains("Reset Your Password"))
                {
                    Ilist_Link[i].Click();
                    break;
                }
            }


            mDriver.SwitchTo().Frame("msg_body");

            F_General.WaitForControlExist(mDriver, "//p[contains(text(),'You can also copy and paste this link into your browse')]//following-sibling::p[1]/a", 10);
            string mLink = mDriver.FindElement(By.XPath("//p[contains(text(),'You can also copy and paste this link into your browse')]//following-sibling::p[1]/a")).Text;
            
            mDriver.Quit();
            return mLink;
        }


        /// <summary>
        /// Create a new account 
        /// </summary>
        /// <param name="pPhoneNumber">PhoneNumber to get code</param>
        /// <param name="pUrl">URL for PhoneNumber</param>
        public static string Get_Phone_Verfication_Register_Code(string pPhoneNumber, string pUrl)
        {

            pPhoneNumber = "447751944683";
            pUrl = "https://receive-sms-online.com";
    
            IWebDriver driver_PhoneWeb = new FirefoxDriver();
            driver_PhoneWeb.Url = pUrl;
            driver_PhoneWeb.FindElement(By.XPath("//a[contains(@href,'" + pPhoneNumber  + "')]")).Click();
            List<string> mList_PhoneNumber = new List<string>();
            List<string> mList_CodeText = new List<string>();
            IList<IWebElement> Ilist_Phonenumber = driver_PhoneWeb.FindElements(By.XPath("//*[@id='mesages']/tbody//following-sibling::tr/td[2]"));
            IList<IWebElement> Ilist_CodeText = driver_PhoneWeb.FindElements(By.XPath("//*[@id='mesages']/tbody//following-sibling::tr/td[4]"));

            string code = null;
            for (int i = 0; i<Ilist_Phonenumber.Count - 1; i++)
            {
                if(Ilist_Phonenumber[i].Text == "Alipay")
                {
                    code = Ilist_CodeText[i].Text.Replace("Your secure accountactivation code is ", string.Empty);
                    driver_PhoneWeb.Quit();
                    
                }
            }
            return code;
        }


       

    }
}
