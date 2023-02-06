using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.POM
{
     class AdminSignIN
    {
        [FindsBy(How = How.Name, Using = "username")]
        private IWebElement usernamebox { get; set; }


        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordbox { get; set; }


        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement singInbtn { get; set; }




        public AdminSignIN(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        public IWebElement getusernamebox()
        {
            return usernamebox;
        }

        public IWebElement getpasswordbox()
        {
            return usernamebox;
        }

        public IWebElement getsigninbtn()
        {
            return usernamebox;
        }
        public void setLogIn(String usrname,String pwd)
        { 
        usernamebox.SendKeys(usrname);
        passwordbox.SendKeys(pwd);
            singInbtn.Click();
        
        }

    }
}
