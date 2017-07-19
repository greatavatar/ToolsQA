using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Net;
using System.Threading;
using System.Globalization;
using OpenQA.Selenium;
using ToolsQA.Libraries.Init;
using ToolsQA.Interfaces;
using ToolsQA.Libraries.Functions;

namespace ToolsQA.Libraries.Verifications
{
    class F_Verify_General
    {
        /// <summary>
        /// Verify Web Element does not exist
        /// </summary>
        /// <param name="pElementName">Name of Web Element to verify</param>
        /// <param name="pBy">Web Element to verify</param>
        /// <param name="pResult">Flag that indicates result of the test case</param>
        /// <param name="pMsg">Message of failure</param>
        public static void VerifyElementDoesNotExist(string pElementName, By pBy, ref bool pResult, ref string pMsg)
        {
            //ConstantPara.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Convert.ToDouble(5)));

            
            if (F_General.CaptureInterface(pBy) != null && F_General.CaptureInterface(pBy).Displayed == true)
            {
                pResult = false;
                pMsg += pElementName + " still displays.\r\n";
            }

            //ConstantPara.driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(Convert.ToDouble(ConstantPara.TimeOut)));
        }

        /// <summary>
        /// Verify Web Element exists
        /// </summary>
        /// <param name="pElementName">Name of Web Element to verify</param>
        /// <param name="pBy">Web Element to verify</param>
        /// <param name="pResult">Flag that indicates result of the test case</param>
        /// <param name="pMsg">Message of failure</param>
        public static void VerifyElementExists(string pElementName, By control, ref bool pResult, ref string pMsg)
        {
            IWebElement mElement = F_General.CaptureInterface(control);
            if (mElement == null || mElement.Displayed == false)
            {
                pResult = false;
                pMsg += pElementName + " does not display.\r\n";
            }
            
        }

        public static void VerifyElementPropertyValue(string pElementName, By pBy, string pProperty, string pExpectedValue, ref bool pResult, ref string pMsg)
        {
            
            IWebElement mElement = F_General.CaptureInterface(pBy);
            string mValue = mElement.GetAttribute(pProperty);
            if (mValue.ToString() != pExpectedValue)
            {
                pResult = false;
                pMsg += pElementName + " does not have " + pProperty + " with value " + pExpectedValue + ".\r\n";
            }
            

        }

        public static void VerifyElementDisable(string pElementName, By pBy, ref bool pResult, ref string pMsg)
        {
            
            IWebElement mElement = F_General.CaptureInterface(pBy);
            string mValue = mElement.GetAttribute("disabled");
            if (mValue != "true")
            {
                pResult = false;
                pMsg += pElementName + " is not disabled .\r\n";
            }
            

        }

        public static void VerifyElementEndable(string pElementName, By pBy, ref bool pResult, ref string pMsg)
        {
            
            IWebElement mElement = F_General.CaptureInterface(pBy);
            string mValue = mElement.GetAttribute("disabled");
            if (mValue == "true")
            {
                pResult = false;
                pMsg += pElementName + " is not enabled .\r\n";
            }
            
        }

        public static void VerifyElementText(By pBy, string pExpectedText, ref bool pResult, ref string pMsg)
        {

            IWebElement control = F_General.CaptureInterface(pBy);
            string mText = control.Text;

            if (mText != pExpectedText)
            {
                pResult = false;
                pMsg += "Control displays the text " + mText + " instead of expected text " + pExpectedText + " \r\n";
            }
        }

    }
}
