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
        [TestCategory("01")]
        public void ValidarLoginComSucesso()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário preeviamente cadastrado");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O login deve ser realizado com sucesso");

            LoginSteps.ValidarLoginComSucesso("Admin", "admin123");
        }

        [TestMethod]
        [TestCategory("02")]
        public void ValidarTelaLoginComUsuarioInvalido()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com usuário não cadastrado");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O sistema apresentará a mensagem 'Invalid credentials' e o acesso não será permitido");

            LoginSteps.ValidarTelaLoginComUsuarioInvalido("administrador", "admin123");
        }

        [TestMethod]
        [TestCategory("03")]
        public void ValidarTelaLoginComPasswordInvalido()
        {
            WriteLine("Dado que: Acesse o site 'https://opensource-demo.orangehrmlive.com/web/index.php/auth/login'");
            WriteLine("E: Preencher os campos @UserName e @Password com password inválido");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O sistema apresentará a mensagem 'Invalid credentials' e o acesso não será permitido");

            LoginSteps.ValidarTelaLoginComPasswordInvalido("Admin", "123456789132456");
        }


    }
}
