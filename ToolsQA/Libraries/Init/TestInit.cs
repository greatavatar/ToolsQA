using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolsQA.Libraries.Init;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ToolsQA.Libraries.Init
{
    public class TestInitial
    {
        public bool Result = true;
        public string Msg = "\r\n";

        [TestInitialize]
        public void Testinit()
        {
            ConstantPara.driver = new FirefoxDriver();
            //ConstantPara.driver = new InternetExplorerDriver();
            ConstantPara.driver.Manage().Window.Maximize();
            
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            ConstantPara.driver.Quit();
        }
    }
}
