﻿using OpenQA.Selenium;
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

        public static By UsernamePasswordInvalido = By.XPath("//*[(text()= 'Invalid credentials' )]");
        public static By CampoObrigatorio = By.XPath("//*[(text()='Required')]");
        public static By btForgotYourPassword = By.XPath("//*[text()='Forgot your password? ']");
        
    }
}
