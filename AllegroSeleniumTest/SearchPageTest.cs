using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AllegroSeleniumTest
{
    class SearchPageTest
    {
        private SearchPage page;

        [TestInitialize]
        public void Initialize()
        {
            page = new SearchPage(DriverManager.Create());
        }

        [TestCleanup]
        public void Cleanup()
        {
            page.Close();
        }

        [TestMethod]
        public void TestDefaultSuccess()
        {

        }

        [TestMethod]
        public void TestDefaultFail()
        {

        }

    }
}
