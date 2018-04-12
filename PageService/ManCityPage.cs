using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Shakar.PageService
{
    class ManCityPage
    {
        PageObject.ManCityPage mcp = new PageObject.ManCityPage();
        IWebDriver webDriver;

        public ManCityPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        public void setAuthor(string strAuthor) {
            webDriver.FindElement(By.CssSelector(mcp.css_txtAuthor)).SendKeys(strAuthor);
        }

        public void setEmail(string strEmail)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtemail)).SendKeys(strEmail);
        }

        public void setUrl(string strUrl)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtUrl)).SendKeys(strUrl);
        }

        public void setComment(string strComment)
        {
            webDriver.FindElement(By.CssSelector(mcp.css_txtComment)).SendKeys(strComment);
        }

        public void clickSubmit()
        {
            webDriver.FindElement(By.CssSelector(mcp.css_btnSubmit)).Click();
        }

        public void submitComment(string strAuthor, string strEmail, string strUrl, string strComment)
        {
            this.setAuthor(strAuthor);
            this.setEmail(strEmail);
            this.setUrl(strUrl);
            this.setComment(strComment);
        }
    }
}
