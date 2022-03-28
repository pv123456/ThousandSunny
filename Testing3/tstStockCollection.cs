using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        private object mStockList;

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.StockID = 1;
            TestItem.StockAvailability = true;
            TestItem.StockLastAdded = DateTime.Now.Date;
            TestItem.StockName = "spiderman";
            TestItem.StockDescription = "poster of all spidermen together";
            TestItem.StockPrice = 3;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.StockID = 1;
            TestStock.StockAvailability = true;
            TestStock.StockLastAdded = DateTime.Now.Date;
            TestStock.StockName = "spiderman";
            TestStock.StockDescription = "poster of all spidermen together";
            TestStock.StockPrice = 3;

            AllStock.ThisStock = TestStock;

            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

      

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            List<clsStock> TestList = new List<clsStock>();

            clsStock TestItem = new clsStock();

            TestItem.StockID = 1;
            TestItem.StockAvailability = true;
            TestItem.StockLastAdded = DateTime.Now.Date;
            TestItem.StockName = "spiderman";
            TestItem.StockDescription = "poster of all spidermen together";
            TestItem.StockPrice = 3;

            TestList.Add(TestItem);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.StockID = 1;
            TestItem.StockAvailability = true;
            TestItem.StockLastAdded = DateTime.Now.Date;
            TestItem.StockName = "SuperMan";
            TestItem.StockDescription = "poster of all superman";
            TestItem.StockPrice = 3;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.StockID = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        
    }
}
    

   
