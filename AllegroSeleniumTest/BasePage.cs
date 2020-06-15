using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllegroSeleniumTest
{
    public abstract class BasePage
    {
        protected IWebDriver driver;


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public abstract string Url { get; }

        public void Navigate()
        {
            driver.Url = Settings.Default.AllegroHost + Url;
        }

        public IWebElement FindElement(By by) 
        {
            return driver.FindElement(by); // jak nie znajdzie elementu to rzuca wyjątek
        }

        public bool HasElement(By by)
        {
            return driver.FindElements(by).Count > 0; // Tutaj jak nie znajdzie to nie rzuci wyjątku
        }
    }
}
