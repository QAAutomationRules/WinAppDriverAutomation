using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWinappdriverPOC
{
    [TestClass]
    public class Selenium
    {

        protected const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723/wd/hub";
        protected static RemoteWebDriver AMSSession;
        protected static RemoteWebElement AMSResult;
        protected static string OriginalCalculatorMode;


        [TestMethod]
        public void SeleniumWinAppDriver()
        {
            ////var firefoxOptions = new FirefoxOptions();
            ////var profile = new FirefoxProfile();
            ////profile.AcceptUntrustedCertificates = true;
            ////profile.AssumeUntrustedCertificateIssuer = true;
            ////firefoxOptions.Profile = profile;
            ////IWebDriver driver = new FirefoxDriver(firefoxOptions);


            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("ignore-certificate-errors");
            //IWebDriver driver = new ChromeDriver(options);

            ////Notice navigation is slightly different than the Java version
            ////This is because 'get' is a keyword in C#
            //driver.Navigate().GoToUrl("https://botd-q-360iis-1.devop.vertafore.com/v1811561/NextGen/Home");

            //// Find the text input element by its name
            //IWebElement agency = driver.FindElement(By.Id("txtAgencyNo"));
            //IWebElement user = driver.FindElement(By.Id("txtUserId"));
            //IWebElement password = driver.FindElement(By.Id("txtPassword"));
            //IWebElement loginButton = driver.FindElement(By.Id("btnLogin"));

            //// Enter something to search for
            //agency.SendKeys("1811qac-1");
            //user.SendKeys("qaown");
            //password.SendKeys("P@ssw0rd2");

            //// Now submit the form. WebDriver will find the form for us from the element
            //loginButton.Submit();

            //// Google's search is rendered dynamically with JavaScript.
            //// Wait for the page to load, timeout after 10 seconds
            //var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(d => d.Title.StartsWith("Home", StringComparison.OrdinalIgnoreCase));

            //// Should see: "Cheese - Google Search" (for an English locale)
            //Console.WriteLine("Page title is: " + driver.Title);


            // Launch the calculator app
            DesiredCapabilities appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", @"C:\Users\ticeky\AppData\Local\AMS Services, Inc\AMS 360\WorkstationCoordinator.exe");
            appCapabilities.SetCapability("platformName", "Windows");
            appCapabilities.SetCapability("deviceName", "WindowsPC");
            AMSSession = new RemoteWebDriver(new Uri(WindowsApplicationDriverUrl), appCapabilities);
            Assert.IsNotNull(AMSSession);

            AMSSession.FindElementByName("Create Activity").Click();
            AMSSession.FindElementByName("Action:").SendKeys("Acord Forms");
            

        }
    }
}
