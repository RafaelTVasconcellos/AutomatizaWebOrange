using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaWebOrange.PageObjects
{
    public class RequestPasswordResetCodePage
    {
        public static By Username = By.XPath("//*[@name='username']");
        public static By btCancel = By.XPath("//*[text()=' Cancel ']");
        public static By btResetPassword = By.XPath("//*[@class='oxd-button oxd-button--large oxd-button--secondary orangehrm-forgot-password-button orangehrm-forgot-password-button--reset']");
    }
}
