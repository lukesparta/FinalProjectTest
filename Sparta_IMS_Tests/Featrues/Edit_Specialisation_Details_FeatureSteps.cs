using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Edit_Specialisation_Details_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the Specialisation Details page")]
        public void GivenIAmOnTheSpecialisationDetailsPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[4]/a")).Click();
        }
        
        [Given(@"I change some spec details")]
        public void GivenIChangeSomeSpecDetails()
        {
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

            driver.FindElement(By.Id("SpecName")).Clear();
            driver.FindElement(By.Id("SpecName")).SendKeys("C++");
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"click on Update")]
        public void WhenClickOnUpdate()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[2]/input")).Click();

        }
        
        [Then(@"I want to be redirected to the Specialisations page and any changes made are visibly updated")]
        public void ThenIWantToBeRedirectedToTheSpecialisationsPageAndAnyChangesMadeAreVisiblyUpdated()
        {
            Assert.AreEqual(driver.Url, "https://localhost:44307/Specialisations");
        }
    }
}
