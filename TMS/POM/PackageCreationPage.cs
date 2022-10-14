using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.POM
{
     class PackageCreationPage
    {
        [FindsBy(How = How.Id, Using = "packagename")]
        private IWebElement packagenameBox { get; set; }

        [FindsBy(How = How.Id, Using = "packagetype")]
        private IWebElement packagetypeBox { get; set; }

        [FindsBy(How = How.Id, Using = "packagelocation")]
        private IWebElement packagelocationBox { get; set; }


        [FindsBy(How = How.Id, Using = "packageprice")]
        private IWebElement packagepriceBox { get; set; }


        [FindsBy(How = How.Id, Using = "packagefeatures")]
        private IWebElement packagefeaturesBox { get; set; }


        [FindsBy(How = How.Id, Using = "packagedetails")]
        private IWebElement packagedetailsBox { get; set; }


        [FindsBy(How = How.Id, Using = "//button[text()='Create']")]
        private IWebElement creatSaveBtn { get; set; }


        public PackageCreationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

    }
}
