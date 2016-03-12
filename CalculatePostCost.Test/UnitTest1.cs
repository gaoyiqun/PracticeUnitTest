using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTests
{
    [TestClass]
    public class WebFormTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize()]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost:56899";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup()]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheWebFormTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/CalculatePostCost/WebForm.aspx");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductName")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductName")).SendKeys("Test1");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnCalculate")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductWeight")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductWeight")).SendKeys("10");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductLength")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductLength")).SendKeys("30");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductWidth")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductWidth")).SendKeys("20");
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductHeight")).Clear();
            driver.FindElement(By.Id("ContentPlaceHolder1_txtProductHeight")).SendKeys("10");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnCalculate")).Click();
            driver.FindElement(By.Id("ContentPlaceHolder1_rdoNeedCool_0")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_drpCompany"))).SelectByText("黑貓");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnCalculate")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_drpCompany"))).SelectByText("新竹貨運");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnCalculate")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_drpCompany"))).SelectByText("郵局");
            driver.FindElement(By.Id("ContentPlaceHolder1_btnCalculate")).Click();
            Assert.AreEqual("郵局", driver.FindElement(By.Id("ContentPlaceHolder1_lblCompany")).Text);
            Assert.AreEqual("180", driver.FindElement(By.Id("ContentPlaceHolder1_lblCharge")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
