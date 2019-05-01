using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Edit_Role_Details_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the Role Details page")]
        public void GivenIAmOnTheRoleDetailsPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[5]/a")).Click();
            var a = driver.FindElements(By.TagName("a"));
            foreach (var ancher in a)
            {
                var href = ancher.GetAttribute("href");
                if (href.Contains("Edit"))
                {
                    ancher.Click();
                    break;
                }
            }
            System.Threading.Thread.Sleep(2000);
        }
        
        [Given(@"I change some edit details")]
        public void GivenIChangeSomeEditDetails()
        {
            driver.FindElement(By.Id("JobRoleName")).Clear();
            driver.FindElement(By.Id("JobRoleName")).SendKeys("Trainer (T)");
        }
        
        [When(@"I click on edit Update")]
        public void WhenIClickOnEditUpdate()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[2]/input")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be redirected to the Roles page and any changes made are visibly updated")]
        public void ThenIWantToBeRedirectedToTheRolesPageAndAnyChangesMadeAreVisiblyUpdated()
        {
            Assert.AreEqual(driver.Url, "https://localhost:44307/JobRoles");
        }
    }
}
