using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarketScraper;
using System.Drawing;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestPromoScraper
    {

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
}








































    

