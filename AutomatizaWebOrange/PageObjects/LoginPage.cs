using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizaWebOrange.PageObjects
{
    public class LoginPage 
    {
        public static By Username = By.XPath("//*[@name='username']");
        public static By Password = By.XPath("//*[@name='password']");
        public static By Login = By.XPath("//*[(text()= ' Login ' )]");
    }
}
