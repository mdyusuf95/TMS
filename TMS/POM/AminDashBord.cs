using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TMS.Genric;

namespace TMS.POM
{
    public  class AminDashBord
    {

        [FindsBy(How=How.XPath,Using = "//p[text()='Welcome']")]
        private IWebElement welcomebtn{ get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Profile']")]
        private IWebElement profilebtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()=' Logout']")]
        private IWebElement logOutbtn { get; set; }

        [FindsBy(How =How.XPath,Using = "//span[text()=' Tour Packages']")]
        private IWebElement TourPackagesbtn{ get; set; }    

        [FindsBy(How = How.XPath, Using = "//a[text()='Create']")]
        private IWebElement Createbtn { get; set; }


        [FindsBy(How = How.XPath, Using = "//a[text()='Manage']")]
        private IWebElement Managebtn { get; set; }

        public AminDashBord(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public IWebElement GetTourCratePakage()
        {
            return TourPackagesbtn;
            
        }

        public void setCratebtn()
        {
            Createbtn.Click();

        }

        public IWebElement GetMnage()
        {
            return Managebtn;

        }

        public IWebElement Getwelcome()
        {
            return welcomebtn;

        }

        public IWebElement GetProfile()
        {
            return profilebtn;

        }

        public void ClickLogOut()
        {
            welcomebtn.Click(); 
            logOutbtn.Click();

        }

        public void ClilkOnPro()
        {
            welcomebtn.Click();
            logOutbtn.Click();

        }


    }

}
