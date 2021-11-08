using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using SeleniumExtras.WaitHelpers;
using System.Reflection;
using NUnit.Framework;
using System.Threading;

namespace SiteTest
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void Ordering()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Navigate().GoToUrl("http://localhost:5000");

            var buyButtonLocator = By.Id("Buy");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(
                ExpectedConditions.ElementIsVisible(buyButtonLocator));

            Thread.Sleep(5000);

            var buyButton = driver.FindElement(buyButtonLocator);
            buyButton.Click();


            var checkoutButtonLocator = By.Id("Checkout");
            wait.Until(
                ExpectedConditions.ElementIsVisible(checkoutButtonLocator));

            var firstName = driver.FindElement(By.Id("firstName"));
            var lastName = driver.FindElement(By.Id("lastName"));
            var email = driver.FindElement(By.Id("email"));
            var address = driver.FindElement(By.Id("address"));
            var address2 = driver.FindElement(By.Id("address2"));
            var country = driver.FindElement(By.Id("country"));
            var state = driver.FindElement(By.Id("state"));
            var zip = driver.FindElement(By.Id("zip"));
            var ccName = driver.FindElement(By.Id("cc-name"));
            var ccNumber = driver.FindElement(By.Id("cc-number"));
            var ccExpiration = driver.FindElement(By.Id("cc-expiration"));
            var ccCvv = driver.FindElement(By.Id("cc-cvv"));

            var checkoutButton = driver.FindElement(checkoutButtonLocator);

            firstName.SendKeys("Yash");
            Thread.Sleep(1000);
            lastName.SendKeys("Malpani");
            Thread.Sleep(1000);
            email.SendKeys("ymalpani@dovercorp.com");
            Thread.Sleep(1000);
            address.SendKeys("T-806, Nipun Saffron Valley");
            Thread.Sleep(1000);
            address2.SendKeys("Sahibabad");
            Thread.Sleep(1000);
            country.SendKeys("India");
            Thread.Sleep(1000);
            state.SendKeys("Delhi");
            Thread.Sleep(1000);
            zip.SendKeys("201010");
            Thread.Sleep(1000);
            ccName.SendKeys("Yash Malpani");
            Thread.Sleep(1000);
            ccNumber.SendKeys("123456789012");
            Thread.Sleep(1000);
            ccExpiration.SendKeys("01/22");
            Thread.Sleep(1000);
            ccCvv.SendKeys("001");
            Thread.Sleep(1000);

            checkoutButton.Click();

            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
