using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Libraries.Init;
using OpenQA.Selenium.Interactions;

namespace ToolsQA.Libraries.Functions
{
    class F_General
    {
        /// <summary>
        /// Capture interface
        /// </summary>
        /// <param name="pBy">The locating machanism to use</param>
        /// <returns>Return an IWebElement object</returns>
        public static IWebElement CaptureInterface (By pBy)
        {

            try
            {
                return ConstantPara.driver.FindElement(pBy);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Send a string to a Web Element
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        /// <param name="pValue">The string to type to the element</param>
        public static void SendKey(IWebElement pElement, string pValue)
        {
            pElement.SendKeys(pValue);
        }

        /// <summary>
        /// Send a string to a Web Element by BY property
        /// </summary>
        /// <param name="pBy">The locating mechanism of Web Element is used</param>
        /// <param name="pValue">The string to type to the element</param>
        public static void SendKey(By pBy, string pValue)
        {
            F_General.CaptureInterface(pBy).SendKeys(pValue);
        }

        /// <summary>
        /// Click on a web element
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        public static void Click(IWebElement pElement)
        {
            pElement.Click();
        }

        /// <summary>
        /// Click on a web element by BY property
        /// </summary>
        /// <param name="pBy">The locating machanism of Web Element is used</param>
        public static void Click(By pBy)
        {
            IWebElement mEle = F_General.CaptureInterface(pBy);

            mEle.Click();

        }
    
        /// <summary>
        /// Select a value in dropdown list
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        /// <param name="pValue">The value need to select</param>
        public static void SelectDropdown(IWebElement pElement, string pValue)
        {
            SelectElement mSe = new SelectElement(pElement);
            mSe.SelectByText(pValue);
        }

        /// <summary>
        /// Select a value in dropdown list by BY property
        /// </summary>
        /// <param name="pBy">The locating machanism of Web Element is used</param>
        /// <param name="pValue">The value need to select</param>
        public static void SelectDropdown(By pBy, string pValue)
        {
            SelectElement mSe = new SelectElement(F_General.CaptureInterface(pBy));
            mSe.SelectByText(pValue);
        }

        /// <summary>
        /// Hover a element
        /// </summary>
        /// <param name="pBy">Element Xpath</param>
        public static void MouseOver(IWebElement pElement)
        {
            Actions action = new Actions(ConstantPara.driver);
            action.MoveToElement(pElement).Build().Perform();
        }

        /// <summary>
        /// Hover a element By BY property
        /// </summary>
        /// <param name="pBy">Element Xpath</param>
        public static void MouseOver(By pBy)
        {
            IWebElement mEle = F_General.CaptureInterface(pBy);
            Actions action = new Actions(ConstantPara.driver);
            action.MoveToElement(mEle).Build().Perform();
        }

        /// <summary>
        /// Generate a random string
        /// </summary>
        /// <param name="length">Length of the string want to generate</param>
        /// <returns>Return the generated string</returns>
        public static string RandomString(int length)
        {
            //var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }


        /// <summary>
        /// Set ON a checkbox
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        public static void SetCheckboxON(By pBy)
        {
            IWebElement mEle = F_General.CaptureInterface(pBy);
            if (mEle.Selected == false)
            {
                mEle.Click();
            }
        }

        /// <summary>
        /// Set OFF a checkbox
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        public static void SetCheckboxOFF(By pBy)
        {
            IWebElement mEle = F_General.CaptureInterface(pBy);
            if (mEle.Selected == true)
            {
                mEle.Click();
            }
        }

        /// <summary>
        /// Set ON a radio button
        /// </summary>
        /// <param name="pElement">The Web Element is used</param>
        public static void SetRadioButtonON(By pBy)
        {
            IWebElement mEle = F_General.CaptureInterface(pBy);
            mEle.Click();
        }

        /// <summary>
        /// Compare Vietnamese Text --
        /// </summary>
        /// <param name="pFirstString">First Text to compare</param>
        /// /// <param name="pSecondString">Second Text to compare</param>
        public static bool CompareTwoTexts(string pFirstString, string pSecondString)
        {
            int mResult = pFirstString.CompareTo(pSecondString);
            if (mResult == 0)
            {
                return true;
            }
            else return false;

        }

        /// <summary>
        /// Wait for control exists
        /// </summary>
        /// <param name="pTimeout">Maximum time of minutes to wait</param>
        /// <param name="pControl">control to wait</param>
        public static void WaitForControlExist(IWebDriver pDriver, string pControl, int pTimeout = 12)
        {

            /*//ConstantPara.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Convert.ToDouble(5)));

            while (pTimeout > 0 && F_General.CaptureInterface(By.XPath(pControl)) == null)
            {
                pTimeout--;
                Thread.Sleep(2000);
            }
            //ConstantPara.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Convert.ToDouble(ConstantsLib.TimeOut)));*/

            while (pTimeout > 0)
            {

                try
                {
                    pDriver.FindElement(By.XPath(pControl));
                    break;
                }
                catch
                {

                    Thread.Sleep(2000);
                }

                pTimeout--;
            }

        }
    }
}
