using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class CreateUserSteps
    {
        static public IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"create new user page")]
        public void GivenCreateNewUserPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/a")).Click();
            driver.FindElement(By.Id("createUser")).Click();
            System.Threading.Thread.Sleep(2000);
        }

        [Given(@"I complete all fields correctly")]
        public void GivenICompleteAllFieldsCorrectly()
        {
            driver.FindElement(By.Id("FirstName")).SendKeys("Jim");

            driver.FindElement(By.Id("LastName")).SendKeys("Harrington");

            driver.FindElement(By.Id("Email")).SendKeys("JJHarrington@spartaglobal.com");

            driver.FindElement(By.Id("CohortID")).Click();

            driver.FindElement(By.XPath("//*[@id='CohortID']/option")).Click();

            driver.FindElement(By.Id("JobRoleID")).Click();

            driver.FindElement(By.XPath("//*[@id='JobRoleID']/option")).Click();
        }
        
        [When(@"I click the submit button")]
        public void WhenIClickTheSubmitButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[6]/input")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I should have added a new user in the system")]
        public void ThenIShouldHaveAddedANewUserInTheSystem()
        {
            var tds = driver.FindElements(By.TagName("a"));
            bool found = false;
            foreach (var td in tds)
            {
                var href = td.GetAttribute("href");
                if (href.Contains("mailto:JHarrington@spartaglobal.com"))
                {
                    found = true;
                    break;
                }
            }
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(found);
        }
    }
}
