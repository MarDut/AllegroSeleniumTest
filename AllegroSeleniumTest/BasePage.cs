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

        public string Title => driver.Title;

        public void Navigate()
        {
            driver.Url = Settings.Default.AllegroHost + Url;
        }

        public void Close()
        {
            driver.Close();
        }

        public IWebElement FindElement(string selectoor) 
        {
            return driver.FindElement(By.CssSelector(selectoor)); // jak nie znajdzie elementu to rzuca wyjątek
        }

        public bool HasElement(string selector)
        {
            return driver.FindElements(By.CssSelector(selector)).Count > 0; // Tutaj jak nie znajdzie to nie rzuci wyjątku
        }
    }
}
