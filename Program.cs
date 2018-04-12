using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shakar.PageService;
using OpenQA.Selenium.Chrome;

namespace Shakar
{
    class Program
    {
        static void Main(string[] args)
        {
            MainPage mainPage;
            ManCityPage mcp;

            IWebDriver webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "http://shakarbhattarai.com.np/wordpress/";
            

            mainPage = new MainPage(webDriver);
            mainPage.click();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            mcp = new ManCityPage(webDriver);
            mcp.submitComment(strAuthor: "Author Test", strEmail: "Test@gmail.com", strUrl: "www.test.com", strComment: "test comment");
            mcp.clickSubmit();

            webDriver.Close();

        }
    }
}
