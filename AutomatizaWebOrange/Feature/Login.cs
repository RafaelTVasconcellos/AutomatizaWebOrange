using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatizaWebOrange.Steps;

namespace AutomatizaWebOrange.Feature
{
    [TestClass]
    public class Login : Inicializacao
    {
        [TestMethod]
        public void ValidarLoginComSucesso()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário preeviamente cadastrado");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O login deve ser realizado com sucesso");

            LoginSteps.ValidarLoginComSucesso();
        }
    }
}
