using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllegroSeleniumTest
{
    [TestClass]
    public class HomePageTest
    {
        private HomePage page;

        [TestInitialize]
        public void Initialize()
        {
            page = new HomePage(DriverManager.Create());
        }

        [TestCleanup]
        public void Cleanup()
        {
            page.Close();
        }


        [TestMethod]
        public void TestDefault()
        {
            page.Navigate();
            page.AcceptButton.Click();

            Assert.IsTrue(page.Title.Contains("Allegro"));
        }

    }
}
