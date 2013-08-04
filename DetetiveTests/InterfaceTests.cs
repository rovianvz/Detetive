using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace DetetiveTests
{
    [TestClass]
    public class InterfaceTests
    {
        private static string SITE_URL = "http://localhost/detetive";
    
        
        [TestMethod]
        public void TestMensagemAlertaNenhumSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemSomenteSuspeitoSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbSuspects = driver.FindElement(By.Id("lbSuspects"));

            new SelectElement(lbSuspects).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemSomenteLocalSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbPlaces = driver.FindElement(By.Id("lbPlaces"));

            new SelectElement(lbPlaces).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemSomenteArmaSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbGuns = driver.FindElement(By.Id("lbGuns"));

            new SelectElement(lbGuns).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemSuspeitoELocalSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbSuspects = driver.FindElement(By.Id("lbSuspects"));
            new SelectElement(lbSuspects).Options[0].Click();

            IWebElement lbPlaces = driver.FindElement(By.Id("lbPlaces"));
            new SelectElement(lbPlaces).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemSuspeitoEArmaSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbSuspects = driver.FindElement(By.Id("lbSuspects"));
            new SelectElement(lbSuspects).Options[0].Click();

            IWebElement lbGuns = driver.FindElement(By.Id("lbGuns"));
            new SelectElement(lbGuns).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestMensagemArmaELocalSelecionado()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            driver.FindElement(By.Id("btnSolucionar")).Click();

            IWebElement lbPlaces = driver.FindElement(By.Id("lbPlaces"));
            new SelectElement(lbPlaces).Options[0].Click();

            IWebElement lbGuns = driver.FindElement(By.Id("lbGuns"));
            new SelectElement(lbGuns).Options[0].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.IsTrue(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestSumirAlerta()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);

            driver.FindElement(By.Id("btnSolucionar")).Click();

            IWebElement lbSuspects = driver.FindElement(By.Id("lbSuspects"));
            new SelectElement(lbSuspects).Options[4].Click();

            IWebElement lbPlaces = driver.FindElement(By.Id("lbPlaces"));
            new SelectElement(lbPlaces).Options[4].Click();

            IWebElement lbGuns = driver.FindElement(By.Id("lbGuns"));
            new SelectElement(lbGuns).Options[4].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            //Espera 5 segundos para garantir que deu tempo de sair
            Thread.Sleep(5000);

            Assert.IsFalse(driver.FindElement(By.Id("divErrorMessage")).Displayed);
            driver.Quit();
        }

        [TestMethod]
        public void TestResolveCaso()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(SITE_URL);
            
            IWebElement lbSuspects = driver.FindElement(By.Id("lbSuspects"));
            new SelectElement(lbSuspects).Options[4].Click();

            IWebElement lbPlaces = driver.FindElement(By.Id("lbPlaces"));
            new SelectElement(lbPlaces).Options[4].Click();

            IWebElement lbGuns = driver.FindElement(By.Id("lbGuns"));
            new SelectElement(lbGuns).Options[4].Click();

            driver.FindElement(By.Id("btnSolucionar")).Click();

            Assert.AreEqual(driver.FindElement(By.Id("resposta")).Text, "Ivar J. Acobson, em Restaurante no Fim do Universo, com a Maça");
            driver.Quit();
        }
    }
}
