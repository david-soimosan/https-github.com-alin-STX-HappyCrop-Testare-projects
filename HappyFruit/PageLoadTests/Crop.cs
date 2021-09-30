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
    class Crop
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
        public void CropPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[5]/ul/li[1]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var cropListButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a[3]"));

            Assert.That(cropListButton != null);
        }

        [Test]
        public void PivotReportYMWDPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[5]/ul/li[1]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var exportXLSButton = driver.FindElement(By.XPath("/html/body/div/div/section/section/h1/strong"));

            Assert.That(exportXLSButton != null);
        }

        [Test]
        public void PivotReportYearPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div/aside/section/ul/li[5]/ul/li[3]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var exportXLSButton = driver.FindElement(By.XPath("/html/body/div/div/section/form/div/div/div/div/div[1]/div/button[1]"));

            Assert.That(exportXLSButton != null);
        }

        [Test]
        public void PivotReportMonthPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div/aside/section/ul/li[5]/ul/li[4]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var exportXLSButton = driver.FindElement(By.XPath("/html/body/div/div/section/form/div/div/div/div/div[1]/div/button[1]"));

            Assert.That(exportXLSButton != null);
        }

        [Test]
        public void PivotReportWeekPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div/aside/section/ul/li[5]/ul/li[5]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var cropListButton = driver.FindElement(By.XPath("/html/body/div/div/section/form/div/div/div/div/div[1]/div/button[1]"));

            Assert.That(cropListButton != null);
        }

        [Test]
        public void PivotReportDayPage()
        {
            var href = driver.FindElement(By.XPath("/html/body/div/aside/section/ul/li[5]/ul/li[6]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var cropListButton = driver.FindElement(By.XPath("/html/body/div/div/section/form/div/div/div/div/div[1]/div/button[1]"));

            Assert.That(cropListButton != null);
        }

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();

        }
    }
}
