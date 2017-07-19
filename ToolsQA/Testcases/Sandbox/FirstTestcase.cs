using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading;
using OpenQA.Selenium.Appium.Android;

namespace ToolsQA
{
    
    class FirstTestcase
    {
        static void Main(string[] args)
        {

            /*
                //System.Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"J:\Selenium\Browser Driver\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
                driver.Url = "https://www.lazada.vn/";
                driver.FindElement(By.XPath("//a[text() = 'Đăng ký']")).Click();

                Thread.Sleep(4000);

                driver.Quit();
                //MessageBox.Show("f");*/



            //--------------test Phone code-----------
            /*
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://receive-sms-online.com";

            driver.FindElement(By.XPath("//a[contains(@href,'447751944683')]")).Click();
            List<string> mList_PhoneNumber = new List<string>();
            List<string> mList_CodeText = new List<string>();
            IList<IWebElement> Ilist_Phonenumber = driver.FindElements(By.XPath("//*[@id='mesages']/tbody//following-sibling::tr/td[2]"));
            IList<IWebElement> Ilist_CodeText = driver.FindElements(By.XPath("//*[@id='mesages']/tbody//following-sibling::tr/td[4]"));

            string str_code ="";

            for (int i = 0; i < Ilist_Phonenumber.Count - 1; i++)
            {
                if(Ilist_Phonenumber[i].Text == "Alipay")
                {
                    str_code = Ilist_CodeText[i].Text.Replace("Your secure accountactivation code is ", string.Empty);
                    
                }
            }
            Thread.Sleep(5000);*/



            //--------------test mail code-----------

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.mailinator.com";
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//input[@id='inboxfield']")).SendKeys("zzzz");
            driver.FindElement(By.XPath("//button[contains(text(),'Go!')]")).Click();

            IList<IWebElement> Ilist_Address = driver.FindElements(By.XPath("//div[@class='someviewport']//following-sibling::div[contains(@id,'row_public')]/div[2]/div[2]/div"));
            IList<IWebElement> Ilist_Link = driver.FindElements(By.XPath("//div[@class='someviewport']//following-sibling::div[contains(@id,'row_public')]/div[2]/div[5]/div"));

            for (int i = 0; i < Ilist_Address.Count - 1; i++)
            {
                if (Ilist_Address[i].Text.Contains("Alipay Service"))
                {
                    Ilist_Link[i].Click();

                }
            }


            driver.SwitchTo().Frame("publicshowmaildivcontent");
            
            
            

            string code = driver.FindElement(By.XPath("//p[contains(text(),'You can also enter the following code in the')]//following-sibling::p[1]")).Text;
            
            //Thread.Sleep(5000);
        }



    }
}
