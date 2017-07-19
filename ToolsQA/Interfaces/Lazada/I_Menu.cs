using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ToolsQA.Interfaces.Lazada
{
    class I_Menu
    {

        public static By link_DangKy = By.XPath("//li[@class='c-top-bar__item ']/a[text()='Đăng ký']");
        
        public static By txt_Search = By.XPath("//input[contains(@class,'header-search__input-group-textbox')][@type = 'search']");

        public static By btn_Search = By.XPath("//button[@data-qa-locator='header-search-button'][@type='submit']");

        public static By lbl_TaiKhoan = By.XPath("//li[@class='top-nav__item js-header-logged-in-account']//p[contains(text(),'Tài khoản')]");
        public static By lbl_KetQuaTimKiemCua = By.XPath("//div[@data-qa-locator='catalog-search-result-title']/h1");
        public static By lbl_SoLuongSanPhamTimThay = By.XPath("//div[@data-qa-locator='catalog-search-result-quantity']");

    }
}
