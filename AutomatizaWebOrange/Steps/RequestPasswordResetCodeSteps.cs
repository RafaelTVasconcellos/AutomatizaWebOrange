using AutomatizaWebOrange.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AutomatizaWebOrange.Steps
{
    public class RequestPasswordResetCodeSteps : Inicializacao
    {
        public static void PreencherUsername(string Username)
        {
            WriteLine("Preenche campo Username");
            Driver.FindElement(RequestPasswordResetCodePage.Username).SendKeys(Username);
        }

        public static void ClicarBotaoResetPassword()
        {
            WriteLine("Realiza o click no botão 'Reset Password'");
            Driver.FindElement(RequestPasswordResetCodePage.btResetPassword).Click();
        }

        public static void ValidarRecuperarSenha(string Username)
        {
            PreencherUsername(Username);
            ClicarBotaoResetPassword();
        }
    }
}
