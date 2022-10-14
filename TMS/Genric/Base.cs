using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Genric
{
    public class Base
    {
        public IWebDriver driver;
        
        [OneTimeSetUp]
        public void OpenBrowser()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            Library lb= new Library();
            lb.GoToUrl(driver,"http://rmgtestingserver/domain/Online_Tourism_Management_System/");



        }
       [OneTimeTearDown]
          public void CloseBrowser()
          {
              Thread.Sleep(4000);
              driver.Close();

          }
    }
}
