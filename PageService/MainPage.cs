using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Shakar.PageService
{
    class MainPage
    {
        PageObject.MainPage mainPage = new PageObject.MainPage();
        IWebDriver webDriver;

        public MainPage(IWebDriver webdriver) {
            this.webDriver = webdriver;
        }

        public void click() {
            webDriver.FindElement(By.CssSelector(mainPage.cssManCity)).Click();
        }
    }
}
