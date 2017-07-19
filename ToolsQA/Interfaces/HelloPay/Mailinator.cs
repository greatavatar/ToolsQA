using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.HelloPay
{
    class I_Mailinator
    {


        public static By txt_EmailBox = By.XPath("//input[@id='inboxfield']");

        public static By btn_Go = By.XPath("//button[contains(text(),'Go!')]");

        
         /*
           
        --created
            http://www.smsver.com
            +351918117485 Portugal
            testavatar10@mailinator.com

        not create yet
            http://www.smsver.com
            +351918117484 Portugal

            --created
            http://7sim.net/free-phone-number-aL9Bv0rwG
            +447453474589
            UK
        testavatar15 @mailinator.com

                    not create yet
           http://7sim.net/free-phone-number-aL9Bv0rwG
            +447453444863
            */
    }
}
