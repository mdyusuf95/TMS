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


        [FindsBy(How = How.XPath, Using = "//div[text()=':Package Created Successfully ']")]
        private IWebElement Success { get; set; }


        public PackageCreationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void  SetpackagenameBox(String name)
        {
            packagenameBox.SendKeys(name);
        }

        public void SetpackagetypeBox(String type)
        {
            packagetypeBox.SendKeys(type);
        }

        public void SetpackageLocation(String location)
        {
            packagelocationBox.SendKeys(location);
        }

        public void Setpackagefeatures(String packagefeatures)
        {
            packagefeaturesBox.SendKeys(packagefeatures);
        }

        public void SetpakagePrice(String price)
        {
            packagepriceBox.SendKeys(price);
        }

        public void Setpackagedetails(String packagedetails)
        {
            packagedetailsBox.SendKeys(packagedetails);
        }

        public void SetSaveBtn()
        {
            creatSaveBtn.Click();  
        }

        public IWebElement Getsucess()
        {
            return Success;
        }







    }
}
