using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarketScraper;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestPromoScraper
    {
        [TestMethod]
        [ExpectedException(typeof(System.Exception), "ex")]
        public void TestMethodDownloadImageFromUrl()
        {
            //Arrange
            PromoScraper p1 = new PromoScraper();

            //Act
            PromoScraper.DownloadImageFromUrl("Bad URL");
            Image img = PromoScraper.DownloadImageFromUrl("https://img.e-piotripawel.pl/5900585000141.jpg");

            //Assert
            Assert.IsNotNull(img);

        }


    }

    [TestClass]
    public class UnitTestDBconnect
    {
        [TestMethod]
        public void TestMethodDeleteFromDB()
        {
            //Arrange
            DBConnect db = new DBConnect();

            //Assert
            Assert.AreEqual(2, db.SelectOrders().Count);
        }
    }
}








































    

