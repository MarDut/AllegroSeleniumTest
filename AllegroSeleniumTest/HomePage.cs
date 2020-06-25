using OpenQA.Selenium;

namespace AllegroSeleniumTest
{
    class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        { 

        }

        public override string Url => "#";

        public IWebElement AcceptButton => FindElement("button._13q9y._8hkto.munh_56_m.m7er_k4.m7er_wn.m7er_56_m");


    }
}
