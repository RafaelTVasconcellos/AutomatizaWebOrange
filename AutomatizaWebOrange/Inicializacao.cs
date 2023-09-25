using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;

namespace AutomatizaWebOrange
{
    public class Inicializacao
    {
        #region Globals
        private static ChromeDriver ChromeDriver;
        public static EventFiringWebDriver Driver;
        #endregion Globals
        
        #region Atributos
        #region Método que será executado no início de cada teste
        [TestInitialize]
        public void Inicializar()
        {
            ChromeDriver = new ChromeDriver("Deploy");
            ChromeDriver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            ChromeDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            ChromeDriver.Manage().Window.Maximize();
            Driver = new EventFiringWebDriver(ChromeDriver);
        }
        #endregion Método que será executado no início de cada teste

        #region Método que será executado no final de cada teste
        [TestCleanup]
        public void Fechar()
        {
            ChromeDriver.Quit();
            Driver.Quit();
        }
        #endregion Método que será executado no final de cada teste
        #endregion Atributos
    }
}
