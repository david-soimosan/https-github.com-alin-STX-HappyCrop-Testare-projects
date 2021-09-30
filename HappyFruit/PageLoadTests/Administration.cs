using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyFruit
{
    class Administration
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
        public void Company() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[1]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addCompanyButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div/div/div/div/div[20]/div/input"));

            Assert.That(addCompanyButton != null);
        }
        //
        [Test]
        public void FarmPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[3]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addFarmPage = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addFarmPage != null);
        }
        
        [Test]
        public void OrchardPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[4]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addOrchardPage = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addOrchardPage != null);
        }
        
        [Test]
        public void PlantationPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[5]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addNewPLantationButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addNewPLantationButton != null);
        }
        
        [Test]
        public void ParcelPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[6]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addNewParcelButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a[1]"));

            Assert.That(addNewParcelButton != null);
        }
        
        [Test]
        public void TypePage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[7]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addTypeButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addTypeButton != null);
        }
        
        [Test]
        public void ProductTypePage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[8]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addProductTypeButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addProductTypeButton != null);
        }
        
        [Test]
        public void ProductPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[10]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addProductButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addProductButton != null);
        }
        
        [Test]
        public void WorkloadCategoryPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[12]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addWorkloadCategoryButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addWorkloadCategoryButton != null);
        }
        
        [Test]
        public void WorkloadTypePage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[13]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addWorkloadTypePage = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addWorkloadTypePage != null);
        }
        
        [Test]
        public void UsersPage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[15]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addUsersButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a"));

            Assert.That(addUsersButton != null);
        }
        
        [Test]
        public void EmployeePage() 
        {
            var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[17]/a")).GetAttribute("href");

            driver.Navigate().GoToUrl(href);

            var addEmployeeButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/a[1]"));

            Assert.That(addEmployeeButton != null);
        }
        
        //[Test]
        //public void BanksPage() 
        //{
        //    var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[1]/a")).GetAttribute("href");

        //    driver.Navigate().GoToUrl(href);

        //    var saveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div/div/div/div/div[20]/div/input"));

        //    Assert.That(saveButton != null);
        //}
        
        //[Test]
        //public void DocumentsPage() 
        //{
        //    var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[1]/a")).GetAttribute("href");

        //    driver.Navigate().GoToUrl(href);

        //    var saveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div/div/div/div/div[20]/div/input"));

        //    Assert.That(saveButton != null);
        //}
        
        //[Test]
        //public void TemplatesPage() 
        //{
        //    var href = driver.FindElement(By.XPath("/html/body/div[1]/aside/section/ul/li[12]/ul/li[1]/a")).GetAttribute("href");

        //    driver.Navigate().GoToUrl(href);

        //    var saveButton = driver.FindElement(By.XPath("/html/body/div[1]/div/section/form/div/div/div/div/div[20]/div/input"));

        //    Assert.That(saveButton != null);
        //}

        [OneTimeTearDown]
        public void EndTest()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
