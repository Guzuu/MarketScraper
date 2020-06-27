using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarketScraper;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSearchBiedronka()
        {
            //Arrange
            QueryScraper q1 = new QueryScraper();
            QueryScraper q2 = new QueryScraper();
            QueryScraper q3 = new QueryScraper();

            //Act
            q1.ScrapeBiedronka("chleb");
            q2.ScrapeBiedronka("szynka");
            q3.ScrapeBiedronka("");

            //Assert
            Assert.AreEqual(3, q1.BiedronkaProducts.Count);
            Assert.AreEqual(10, q2.BiedronkaProducts.Count);
            Assert.AreEqual(0, q3.BiedronkaProducts.Count);
        }

        [TestMethod]
        public void TestMethodSearchSpar()
        {
            //Arrange
            QueryScraper q1 = new QueryScraper();
            QueryScraper q2 = new QueryScraper();
            QueryScraper q3 = new QueryScraper();

            //Act
            q1.ScrapeSpar("chleb", "rzeszow");
            q2.ScrapeSpar("szynka", "polska");
            q3.ScrapeSpar("bad product", "bad city");

            //Assert
            Assert.AreEqual(12, q1.SparProducts.Count);
            Assert.AreEqual(4, q2.SparProducts.Count);
            Assert.AreEqual(0, q3.SparProducts.Count);
        }
    }
}
