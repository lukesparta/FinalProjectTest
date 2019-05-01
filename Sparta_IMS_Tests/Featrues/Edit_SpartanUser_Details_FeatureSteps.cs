﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Sparta_IMS_Tests
{
    [Binding]
    public class Edit_SpartanUser_Details_FeatureSteps
    {
        IWebDriver driver = new ChromeDriver("C:/Sparta-IMS-Eng24");
        [Given(@"I am on the edit SpartanUser page")]
        public void GivenIAmOnTheEditSpartanUserPage()
        {
            driver.Navigate().GoToUrl("https://localhost:44307/");
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul[2]/li[2]/a")).Click();
            driver.FindElement(By.Id("Input_Email")).SendKeys("lukedawes@spartaglobal.com");
            driver.FindElement(By.Id("Input_Password")).SendKeys("Password01#");
            driver.FindElement(By.XPath("/html/body/div/div/div/section/form/div[5]/button")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/a")).Click();

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
        
        [Given(@"I change some details")]
        public void GivenIChangeSomeDetails()
        {
            driver.FindElement(By.Id("FirstName")).Clear();
            driver.FindElement(By.Id("FirstName")).SendKeys("Philip");
            driver.FindElement(By.Id("CohortID")).Click();
            driver.FindElement(By.XPath("//*[@id='CohortID']/option[3]")).Click();

        }
        
        [When(@"I click on Update")]
        public void WhenIClickOnUpdate()
        {
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/form/div[6]/input")).Click();
            System.Threading.Thread.Sleep(2000);
        }
        
        [Then(@"I want to be redirected to the Sparta Users page and any changes made are visibly updated")]
        public void ThenIWantToBeRedirectedToTheSpartaUsersPageAndAnyChangesMadeAreVisiblyUpdated()
        {
            
        }
    }
}
