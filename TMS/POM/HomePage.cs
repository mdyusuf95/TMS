using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.POM
{
     class HomePage
    {
        [FindsBy(How = How.XPath, Using = "//a[text()='Admin Login']")]
        private IWebElement adminLoginbotton { get; set; }
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public IWebElement getadminLoginbotton( )
        {
            return adminLoginbotton;
        }

    }
}
