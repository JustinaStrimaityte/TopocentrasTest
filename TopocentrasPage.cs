using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Baigiamasis_darbas.Page
{
   public class TopocentrasPage  : BasePageClass
    {
        private IWebElement searchInput => Driver.FindElement(By.Id("Sort-selectBox-2qH"));
        private IWebElement searchIcon => Driver.FindElement(By.ClassName("Sort-selectBox-2qH"));
        public TopocentrasPage(IWebDriver webdriver): base(webdriver) { }

        public void SearchByText(string paspirtukas)
        {
            Driver.FindElement(By.ClassName("HeaderContent-searchInput-3Ks")).SendKeys(paspirtukas);
            Driver.FindElement(By.ClassName("HeaderContent-searchInput-3Ks")).SendKeys(Keys.Return);

        }




        ////public void PressOnSearchbutton()
        ////        {
        ////            searchIcon.Click();
        ////        }
            }                                       
        }  
        

        
        

        
    

