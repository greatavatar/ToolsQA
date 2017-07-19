using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;

namespace ToolsQA.Libraries.Init
{
    [TestClass()]
    class AssemblyInitial
    {

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Process[] processes = Process.GetProcessesByName("geckodriver");

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
           //Process[] processes = Process.GetProcessesByName("IEDriverServer"); 
           //Geckodriver ---Firefox
            Process[] processes = Process.GetProcessesByName("geckodriver");

            foreach (Process process in processes)
            {
                process.Kill();
            }

        }
    }
}
