using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace AllegroSeleniumTest
{
    public static class DriverManager
    {
        public static IWebDriver Create()
        {
            IWebDriver driver;
#if FIREFOX
            driver = new FirefoxDriver();
#endif // FIREFOX          
#if CHROME
            ChromeOptions options = new ChromeOptions();
#if HEADLESS
            options.AddArgument("headless");
#endif // HEADLESS
            driver = new ChromeDriver(options);
#endif // CHROME

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5.0);

            return driver;
        }
    }
}
