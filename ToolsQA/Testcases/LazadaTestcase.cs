using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using ToolsQA.Libraries.Functions.Lazada;
using ToolsQA.Libraries.Functions;
using ToolsQA.Libraries.Init;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsQA.Libraries.Verifications;
using ToolsQA.Libraries.Verifications.Lazada;
using ToolsQA.Interfaces.Lazada;

namespace ToolsQA.Tests
{
    [TestClass]
    public class LazadaTestcase : TestInitial
    {
        [TestMethod, TestProperty("Lazada", "01"), Priority(1), TestCategory("Functionality"), Owner("test")]
        public void TC01_Lazada_Verify_Creating_New_Account()
        {

            //-------------------Section: Init Data---------------------------------
            UserAccount NewUserAccount = new UserAccount
            {
                Account_Name = F_General.RandomString(6),
                Email = F_General.RandomString(6) + "@gmai.com",
                Password = F_General.RandomString(6) + "1"
            };

            //-------------------Section: Steps-------------------------------------
            F_Navigation.Navigate_Lazada();
            F_Account.Register_Account(NewUserAccount);
            F_Verify_Account.Verify_Create_Account_Successfully(NewUserAccount.Account_Name, NewUserAccount.Email, ref Result, ref Msg);

            Assert.IsTrue(Result, Msg);
        }


        [TestMethod, TestProperty("Lazada", "02"), Priority(2), TestCategory("Functionality"), Owner("test")]
        public void TC02_Lazada_Verify_Search_Product_By_TextboxMenu_Successfully()
        {

            //-------------------Section: Init Data---------------------------------
            string str_SearchText = "test";

            //-------------------Section: Steps-------------------------------------
            F_Navigation.Navigate_Lazada();
            F_Product.Search_Product(str_SearchText);
            F_Verify_Product.Verify_Search_Product_Successfully(str_SearchText, ref Result, ref Msg);

            Assert.IsTrue(Result, Msg);
        }
    }
}
