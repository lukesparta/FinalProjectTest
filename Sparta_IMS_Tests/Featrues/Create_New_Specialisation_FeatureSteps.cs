using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Create_New_Specialisation_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the Create Specialisation page")]
        public void GivenIAmOnTheCreateSpecialisationPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[4]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/p/a")).Click();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"I enter the Specialisation name")]
        public void GivenIEnterTheSpecialisationName()
        {
            driver.FindElement(By.Id("SpecName")).SendKeys("Data");           
        }
        
        [When(@"I click on Create button")]
        public void WhenIClickOnCreateButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[2]/input")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be redirected to the Specialisations page and the new Specialisation to be added to the Specialisations table")]
        public void ThenIWantToBeRedirectedToTheSpecialisationsPageAndTheNewSpecialisationToBeAddedToTheSpecialisationsTable()
        {
            Assert.AreEqual(driver.Url, "https://localhost:44307/Specialisations");
        }
    }
}
