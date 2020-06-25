using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AllegroSeleniumTest
{
    class SearchPage : HomePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        { 
        
        }

        public IWebElement SearchTextBox => FindElement("input[name='string']");
        public SelectElement SearchComboBox => new SelectElement(FindElement(
            "select._d25db_ZZIhH._1h7wt._k70df.m7er_k4.m7er_wn"));
        public IWebElement SearchButton => FindElement("button._d25db_10Nyi._13q9y._8tsq7._1q2ua");
        public int OfferCount
        {
            get
            {
                IWebElement span = FindElement("span._11fdd_39FjG");

                return int.Parse(span.Text);
            }
        }

        public bool HasOffers => OfferCount > 0;
    }
}
