using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TMS.Genric;
using TMS.POM;

namespace TMS.TestScripts
{
    class testAdminpage:Base
    {
        [Test]
        public void adminlogin()
        {

            //HomePage hp= new HomePage(driver);
            //hp.getadminLoginbotton().Click();

            //AdminSignIN ad = new AdminSignIN(driver);
            //ad.setLogIn("admin", "Test@123");

            //AminDashBord adb=new AminDashBord(driver);
            //String atitel = driver.Title;
            //String Etitel = "TMS | Admin Dashboard";

            //Assert.AreEqual(atitel,Etitel);
            //Console.WriteLine("Admin Dashbord Displed ");

            Console.WriteLine("login to app");


        }

          [Test]
          public void CreatPakage()
          {
            //AminDashBord adb = new AminDashBord(driver);
            //adb.GetTourCratePakage().Click();
            //adb.GetCratebtn().Click();
            //PackageCreationPage pcp=new PackageCreationPage(driver);
            //pcp.SetpackagenameBox("MADGASKAR");
            //pcp.SetpackagetypeBox("internaltional");
            //pcp.SetpakagePrice("85000");
            //pcp.Setpackagefeatures("testing ");
            //pcp.Setpackagedetails("5days 4 nights all travling facilities provided ");
            //pcp.SetSaveBtn();
            Console.WriteLine("create pakages");



         }

    }
}
