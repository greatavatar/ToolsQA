using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using ToolsQA.Libraries.Functions.HelloPay;
using ToolsQA.Libraries.Functions;
using ToolsQA.Libraries.Init;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsQA.Libraries.Verifications;
using ToolsQA.Libraries.Verifications.HelloPay;
using ToolsQA.Interfaces.HelloPay;

namespace ToolsQA.Tests
{
    [TestClass]
    public class HelloPayTestcase : TestInitial
    {
        [TestMethod, TestProperty("HelloPay", "01"), Priority(1), TestCategory("Functionality"), Owner("test")]
        public void TC01_HelloPay_Verify_Reset_Existing_Passowrd()
        {

            //-------------------Section: Init Data---------------------------------
            string AccountEmail = "testavatar10@mailinator.com";
            string NewPass = "123456?zZ";

            //-------------------Section: Steps-------------------------------------

            F_Navigation.Navigate_HelloPay();
            F_Account.Reset_Password(AccountEmail, NewPass);

            F_Verify_General.VerifyElementExists("Label Your password has been successfully reset", I_ResetPassword.lbl_ResetPasswordSuccessfully, ref Result, ref Msg);

            Assert.IsTrue(Result, Msg);
            
        }


     
    }
}
