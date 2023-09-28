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

        [TestMethod]
        [TestCategory("04")]
        public void ValidarTelaComUsuarioObrigatorio()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Não preencher o campo @username");
            WriteLine("E: Preencher o campo @password com valor válido");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O acesso não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @username");

            LoginSteps.ValidarTelaComUsuarioObrigatorio("", "admin123");
        }

        [TestMethod]
        [TestCategory("05")]
        public void ValidarTelaComSenhaObrigatorio()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Preencher o campo @username com valor válido");
            WriteLine("E: Não preencher o campo @password");
            WriteLine("Quando: Clicar no botão[Login]");
            WriteLine("Então: O acesso não será permitido");
            WriteLine("E: Será exibido a mensagem 'Required' logo abaixo no campo @password");

            LoginSteps.ValidarTelaComSenhaObrigatorio("Admin", "");
        }

        [TestMethod]
        [TestCategory("06")]
        public void ValidarTrocaDeSenha()
        {
            WriteLine("Dado: Ao acessar o site https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            WriteLine("E: Preencher o campo @Username com valor válido");
            WriteLine("E: Não saber o @Password preeviamente cadastrado");
            WriteLine("Quando: Clicar no botão[Forgot your password ?]");
            WriteLine("Então: Será redirecionado ao link: https://opensource-demo.orangehrmlive.com/web/index.php/auth/requestPasswordResetCode");
            WriteLine("E: Deverá preencher o @Username preeviamente cadastrado");
            WriteLine("E: Clicar no botão [Resset Password]");
            WriteLine("E: Visualizará em sua tela a mensagem 'Reset Password link sent' ");
            WriteLine("E: Receberá em seu e-mail a mensagem de recuperação de senha");

            LoginSteps.ValidarTrocaDeSenha("Admin");
        }
    }
}
