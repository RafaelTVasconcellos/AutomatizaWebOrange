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
        public static void Login(string Username, string Password)
        {
            Thread.Sleep(5000);
            WriteLine("Preenche campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys(Username);
            Thread.Sleep(5000);
            WriteLine("Preenche campo Password");
            Driver.FindElement(LoginPage.Password).SendKeys(Password);
            Thread.Sleep(5000);
            WriteLine("Realiza o click no botão Login");
            Driver.FindElement(LoginPage.Login).Click();
        }

        public static void ValidarLoginComSucesso(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            string LoginSucesso = Convert.ToString(Driver.FindElement(DashboardPage.pgDashboard).Text);
            Assert.AreEqual("Dashboard", LoginSucesso, "Login foi realizado com sucesso");
        }

        public static void ValidarTelaLoginComUsuarioInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizo a validação com usuário inválido");
            string UsernameInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", UsernameInvalido, "Usuário inválido conforme esperado");
        }

        public static void ValidarTelaLoginComPasswordInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizo a validação com senha inválida");
            string PasswordInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", PasswordInvalido, "Senha inválida conforme esperado");
        }
    }
}
