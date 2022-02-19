using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it executes
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void StockAvalibilityOK()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.StockAvalibility = TestData;
            Assert.AreEqual(AnStock.StockAvalibility, TestData);
        }
        [TestMethod]
        public void StockLastAddedOK()
        {
            clsStock AnStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AnStock.StockLastAdded = TestData;
            Assert.AreEqual(AnStock.StockLastAdded, TestData);
        }

        [TestMethod]
        public void StockNameOK()
        {
            clsStock Anstock = new clsStock();
            String TestData = "Avengers";
            Anstock.StockName = TestData;
            Assert.AreEqual(Anstock.StockName, TestData);
        }
        [TestMethod]
        public void StockDescriptionOK()
        {
            clsStock Anstock = new clsStock();
            String TestData = "Avengers";
            Anstock.StockDescription = TestData;
            Assert.AreEqual(Anstock.StockDescription, TestData);
        }
        [TestMethod]
        public void StockPriceOK()
        {
            clsStock Anstock = new clsStock();
            decimal TestData = 3;
            Anstock.StockPrice = TestData;
            Assert.AreEqual(Anstock.StockPrice, TestData);
        }
    }
}
