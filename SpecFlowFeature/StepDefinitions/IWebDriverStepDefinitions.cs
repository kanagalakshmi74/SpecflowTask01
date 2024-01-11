
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowFeature.StepDefinitions
{
    [Binding]
    public sealed class IWebDriverStepDefinitions
    {
        private IWebDriver driver;

        [Given(@"Open chrome page")]
        public void GivenOpenChromePage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize(); 
        }

        [When(@"enter the url")]
        public void WhenEnterTheUrl()
        {
             driver.Url = "https://www.flipkart.com/";
        }

        [Then(@"close the chrome page")]
        public void ThenCloseTheChromePage()
        {
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("Laptops");
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
