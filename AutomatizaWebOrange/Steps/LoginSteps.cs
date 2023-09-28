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
            WriteLine("Preencher campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys(Username);
            Thread.Sleep(5000);
            WriteLine("Preencher campo Password");
            Driver.FindElement(LoginPage.Password).SendKeys(Password);
            Thread.Sleep(5000);
            WriteLine("Realizar o click no botão Login");
            Driver.FindElement(LoginPage.Login).Click();
        }

        public static void ValidarLoginComSucesso(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Validação realizada pela descrição 'Dashboard' na tela");
            string LoginSucesso = Convert.ToString(Driver.FindElement(DashboardPage.pgDashboard).Text);
            Assert.AreEqual("Dashboard", LoginSucesso, "Login foi realizado com sucesso");

            WriteLine("Validação realizada pela link da página Dashboard");
            string pgDashboardEsperado = "https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index";
            string pgDashboardAtual = Convert.ToString(Driver.Url);
            Assert.AreEqual(pgDashboardEsperado, pgDashboardAtual, "Login foi realizado com sucesso");
        }

        public static void ValidarTelaLoginComUsuarioInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizar a validação com usuário inválido");
            string UsernameInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", UsernameInvalido, "Usuário inválido conforme esperado");
        }

        public static void ValidarTelaLoginComPasswordInvalido(string Username, string Password)
        {
            Login(Username, Password);

            WriteLine("Realizar a validação com senha inválida");
            string PasswordInvalido = Convert.ToString(Driver.FindElement(LoginPage.UsernamePasswordInvalido).Text);
            Assert.AreEqual("Invalid credentials", PasswordInvalido, "Senha inválida conforme esperado");
        }

        public static void ValidarTelaComUsuarioObrigatorio(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Campo obrigatório Username validado com sucesso");
            string UsernameObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", UsernameObrigatorio, "Campo obrigatório Username validado com sucesso");
        }

        public static void ValidarTelaComSenhaObrigatorio(string Username, string Password)
        {
            Login(Username, Password);

            Thread.Sleep(5000);
            WriteLine("Campo obrigatório Password validado com sucesso");
            string PasswordObrigatorio = Convert.ToString(Driver.FindElement(LoginPage.CampoObrigatorio).Text);
            Assert.AreEqual("Required", PasswordObrigatorio, "Campo obrigatório Password validado com sucesso");
        }

        public static void ValidarTrocaDeSenha(string Username)
        {
            Thread.Sleep(5000);
            WriteLine("Preencher campo Username");
            Driver.FindElement(LoginPage.Username).SendKeys(Username);

            WriteLine("Clicar no botão [Forgot Your Password]");
            Driver.FindElement(LoginPage.btForgotYourPassword).Click();

            WriteLine("Validar se redirecionou para a página 'Forgot Your Password'");
            string pgForgotYourPasswordAtual = Convert.ToString(Driver.Url);
            string pgForgotYourPasswordEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/auth/requestPasswordResetCode");
            Assert.AreEqual(pgForgotYourPasswordEsperado, pgForgotYourPasswordAtual, "Página carregada com sucesso!");

            RequestPasswordResetCodeSteps.ValidarRecuperarSenha(Username);

            WriteLine("Validar se redirecionou para a página 'Send Password Reset'");
            string pgSendPasswordResetAtual = Convert.ToString(Driver.Url);
            string pgSendPasswordResetEsperado = Convert.ToString("https://opensource-demo.orangehrmlive.com/web/index.php/auth/sendPasswordReset");
            Assert.AreEqual(pgSendPasswordResetEsperado, pgSendPasswordResetAtual, "Página carregada com sucesso!");

            WriteLine("Validar se exibiu a mensagem 'Reset Password link sent successfully' ");
            string msgSendPasswordResetAtual = Convert.ToString(Driver.FindElement(SendPasswordResetPage.msgSendPasswordReset).Text);
            Assert.AreEqual("Reset Password link sent successfully", msgSendPasswordResetAtual, "Página carregada com sucesso!");
        }
    }
}