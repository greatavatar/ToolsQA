using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ToolsQA.Interfaces.Lazada;
using ToolsQA.Libraries.Functions;
using ToolsQA.Libraries.Init;


namespace ToolsQA.Libraries.Verifications.Lazada
{
    class F_Verify_Account
    {

        /// <summary>
        /// Verify Create Account Successfully
        /// <param name="pName">Name of account</param>
        /// <param name="pEmail">Email of account</param>
        public static void Verify_Create_Account_Successfully(string pName, string pEmail,ref bool pResult,ref string pMsg)
        {

            By mName_Menu_Xpath = By.XPath("//li[@class='top-nav__item js-header-logged-in-account']//span[text()='" + pName + "']");
            By mName_And_Email_Xpath = By.XPath("//p[@class='account-dashboard__box-info' and normalize-space()='" + pName + " " + pEmail + "']");
            F_Verify_General.VerifyElementExists("Label Menu Tai Khoan Log In",mName_Menu_Xpath, ref pResult, ref pMsg);
            F_Verify_General.VerifyElementExists("Name and Emai Login Information", mName_And_Email_Xpath, ref pResult, ref pMsg);

        }
    }
}
