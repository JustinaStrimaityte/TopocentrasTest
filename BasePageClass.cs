using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Baigiamasis_darbas.Page
{
   public class BasePageClass
    {
        protected static IWebDriver Driver;

        public BasePageClass(IWebDriver webdriver)
        {
            Driver = webdriver;

        }
        public void Closebrowser()
        {
            Driver.Quit();
        }
    }
}
