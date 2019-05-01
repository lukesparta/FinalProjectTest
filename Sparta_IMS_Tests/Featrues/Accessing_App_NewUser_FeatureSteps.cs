using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Accessing_App_NewUser_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the Register page")]
        public void GivenIAmOnTheRegisterPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");

            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[1]/a")).Click();
        }

        [Given(@"I enter the relevent details")]
        public void GivenIEnterTheReleventDetails()
        {
            //email
            driver.FindElement(By.Id("Input_Email")).SendKeys("JohnDoe1234@spartaglobal.com");

            //password
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");

            //confirm password
            driver.FindElement(By.Id("Input_ConfirmPassword")).SendKeys("Password01#");
        }
        
        [When(@"I click on Register")]
        public void WhenIClickOnRegister()
        {
            //register button
            driver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be granted access to the app and redirected to the Home page")]
        public void ThenIWantToBeGrantedAccessToTheAppAndRedirectedToTheHomePage()
        {
            Assert.AreEqual(driver.Url, "https://localhost:44307/");
        }
    }
}
