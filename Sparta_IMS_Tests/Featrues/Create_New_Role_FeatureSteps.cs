using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Create_New_Role_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the Create Roles page")]
        public void GivenIAmOnTheCreateRolesPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div/p/a")).Click();
            System.Threading.Thread.Sleep(1000);
        }
        
        [Given(@"I enter the Role name")]
        public void GivenIEnterTheRoleName()
        {
            driver.FindElement(By.Id("JobRoleName")).SendKeys("Training Assistant");
        }
        
        [When(@"I press on Create button")]
        public void WhenIPressOnCreateButton()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[2]/input")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be redirected to the Roles page and the new Specialisation to be added to the Roles table")]
        public void ThenIWantToBeRedirectedToTheRolesPageAndTheNewSpecialisationToBeAddedToTheRolesTable()
        {
            Assert.AreEqual(driver.Url, "https://localhost:44307/JobRoles");
        }
    }
}
