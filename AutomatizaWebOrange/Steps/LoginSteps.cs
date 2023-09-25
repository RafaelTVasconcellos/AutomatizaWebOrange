using AutomatizaWebOrange.PageObjects;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace AutomatizaWebOrange.Steps 
{
    public class LoginSteps : Inicializacao
    {
        /// <summary>
        /// Método utilizado para realizar Login
        /// </summary>
        public static void Login()
        {
            WriteLine("Preenche campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys("Admin");
            WriteLine("Preenche campo Password");
            Driver.FindElement(LoginPage.Password).SendKeys("admin123");
            WriteLine("Realiza o click no botão Login");
            Driver.FindElement(LoginPage.Login).Click();
        }

        public static void ValidarLoginComSucesso()
        {
            Login();
           
            string LoginSucesso = Convert.ToString(Driver.FindElement(DashboardPage.pgDashboard).Text);
            Assert.AreEqual("Dashboard", LoginSucesso, "Login foi realizado com sucesso");
        }


    }
}
