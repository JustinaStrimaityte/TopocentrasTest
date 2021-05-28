using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baigiamasis_darbas.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Baigiamasis_darbas.Test
{
    public class TopoCentrastest

    {
        private static TopocentrasPage _page;
        private static SearchHighprice _searchPage;

       

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            IWebDriver _driver = new ChromeDriver();
            _driver.Url = "https://www.topocentras.lt/";
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _page = new TopocentrasPage(_driver);
            
            _searchPage = new SearchHighprice(_driver);
            

        }

       

        [OneTimeTearDown]

        public static void OneTimeTearDown()
        {
            _page.Closebrowser();
        }
        [Test]
        public static void SearchHighprice()
        {
            _page.SearchByText("paspirtukas");
            //_page.PressOnSearchbutton();
            _searchPage.OrderByHighestPrice();
            _searchPage.VerifyPrice("");

            
        }    





    }


    
        
    }

