using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFruit.PageLoadTests
{
    class Invoice
    {
        IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl(Configuration.URL_Dev + "Home/Login");
            //http://happycropdev.happyfruit.ro/Home/Login
            driver.Manage().Window.Maximize();

            driver.FindElement(By.Id("Email")).SendKeys("david.soimosan@seltronix.eu");
            Console.Write("username value is entered\n ");

            driver.FindElement(By.Id("Password")).SendKeys("Ronaldo!2011" + Keys.Enter);
            Console.Write("password is entered\n ");

            Console.Write("login button is clicked\n ");

            Assert.That(driver.Url == Configuration.URL_Dev_Home);
        }

        [Test]
        public void InvoicePage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[10]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var createNewInvoiceButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(createNewInvoiceButton != null);
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();

        }
    }
}
