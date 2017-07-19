using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using ToolsQA.Interfaces.Lazada;
using ToolsQA.Libraries.Functions;
using ToolsQA.Libraries.Init;
using System.Text.RegularExpressions;

namespace ToolsQA.Libraries.Verifications.Lazada
{
    class F_Verify_Product
    {

        /// <summary>
        /// Verify Searching Successfully by Tim Kiem San Pham textbox in Menu
        /// </summary>
        /// <param name="pSearchText">Text to Search</param>
        public static void Verify_Search_Product_Successfully(string pSearchText,ref bool pResult,ref string pMsg)
        {

            IWebElement mlbl_KetQuaTimKiem_Ele = F_General.CaptureInterface(I_Product.lbl_KetQuaTimKiemCua);
            IWebElement mlbl_SoLuongTimThay_Ele = F_General.CaptureInterface(I_Product.lbl_SoLuongSanPhamTimThay);
            
            //Using action CompareTwoTexts for comparing 2 Vietnamese text instead of (if == )cause UTF-16 character problem
            bool mResult = F_General.CompareTwoTexts(mlbl_KetQuaTimKiem_Ele.Text, "Kết quả tìm kiếm của \"" + pSearchText + "\"");
            if (mResult == false)
            {
                pResult = false;
                pMsg += "Label Ket Qua Tim Kiem does not display.\r\n";
            }


            mResult = mlbl_SoLuongTimThay_Ele.Text.Contains("Sản Phẩm Được Tìm Thấy");

            if (mResult == false)
            {
                pResult = false;
                pMsg += "Label xxx So Luong Tim Thay does not display.\r\n";
            }


            F_General.WaitForControlExist(ConstantPara.driver, "//div[contains(@class,'c-product-list_view_grid')]");

            IList <IWebElement> list_Product = ConstantPara.driver.FindElements(By.XPath("//div[@class='catalog__main__content']/div/div//following-sibling::div[@class='c-product-card__description']/a"));

            if (list_Product.Count == 0)
            {
                pResult = false;
                pMsg += "There is no product for the searching text " + pSearchText + "\r\n";
            }

            else
            {

                for (int i = 0; i < list_Product.Count - 1; i++)
                {
                    //if (list_Product[i].Text.ToUpper().Contains(pSearchText.ToUpper()) == false)
                    if (Regex.IsMatch(list_Product[i].Text, pSearchText, RegexOptions.IgnoreCase) == false)
                    {
                        pResult = false;
                        pMsg += "Product number " + i + " does not contain expected searching text.\r\n";
                        break;
                    }
                }

            }

        }
    }
}
