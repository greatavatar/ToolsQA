using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.Lazada
{
    class I_Product
    {

        public static By lbl_KetQuaTimKiemCua = By.XPath("//div[@data-qa-locator='catalog-search-result-title']/h1");
        public static By lbl_SoLuongSanPhamTimThay = By.XPath("//div[@data-qa-locator='catalog-search-result-quantity']");

        
        
        

    }
}
