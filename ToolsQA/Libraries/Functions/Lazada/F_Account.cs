using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ToolsQA.Libraries.Init;
using ToolsQA.Interfaces.Lazada;
using System.Threading;

namespace ToolsQA.Libraries.Functions.Lazada
{
    class F_Account
    {

        /// <summary>
        /// Create a new account 
        /// </summary>
        /// <param name="pUserAccount">A new UserAccount class</param>
        public static void Register_Account(UserAccount pUserAccount)
        {
            F_General.Click(I_Menu.link_DangKy);


            if (pUserAccount.Sex == "Nam")
                F_General.SetRadioButtonON(I_Register.rad_Nam);
            else
                F_General.SetRadioButtonON(I_Register.rad_Nu);

            F_General.SendKey(I_Register.txt_Email, pUserAccount.Email);
            F_General.SendKey(I_Register.txt_Ten, pUserAccount.Account_Name);
            F_General.SelectDropdown(I_Register.cmb_Ngay, pUserAccount.Birth_Day);
            F_General.SelectDropdown(I_Register.cmb_Thang, pUserAccount.Birth_Month.ToString());
            F_General.SelectDropdown(I_Register.cmb_Nam, pUserAccount.Birth_Year.ToString());
            F_General.SendKey(I_Register.txt_MatKhau, pUserAccount.Password);
            F_General.SendKey(I_Register.txt_NhapLaiMatKhau, pUserAccount.Password);

            if (pUserAccount.Agree_News == false)
                F_General.SetCheckboxOFF(I_Register.chk_DongY);
            else
                F_General.SetCheckboxON(I_Register.chk_DongY);

            F_General.Click(I_Register.btn_Gui);
        }

    }
}
