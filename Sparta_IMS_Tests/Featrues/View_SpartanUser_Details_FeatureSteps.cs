using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class View_SpartanUser_Details_FeatureSteps
    {
        static public IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");

        [Given(@"I am on the Sparta Users page")]
        public void GivenIAmOnTheSpartaUsersPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/a")).Click();
        }
        
        [When(@"I click on a SpartanUser")]
        public void WhenIClickOnASpartanUser()
        {
            var a = driver.FindElements(By.TagName("a"));
            foreach (var ancher in a)
            {
                var href = ancher.GetAttribute("href");
                if (href.Contains("Details"))
                {
                    ancher.Click();
                    break;
                }
            }
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be redirected to a page with the SpartanUsers details and information")]
        public void ThenIWantToBeRedirectedToAPageWithTheSpartanUsersDetailsAndInformation()
        {
        }
    }
}
