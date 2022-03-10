using ClassLibrary;
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
            //test to see that it exists 
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void StockAvailabilityPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property 
            AnStock.StockAvailability = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockAvailability, TestData);
        }

        [TestMethod]

        public void StockLastAddedPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.StockLastAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockLastAdded, TestData);
        }

        [TestMethod]
        public void StockIDPropertyOK() 
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            int TestData = 1;
            //assign the data to the property 
            AnStock.StockID = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockID, TestData);
        }

        [TestMethod]
        public void StockPricePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            decimal TestData = 3;
            //assign the data to the property
            AnStock.StockPrice = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockPrice, TestData);
        }

        [TestMethod]
        public void StockNamePropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            string TestData = "SpiderMan";
            //assign the data to the property 
            AnStock.StockName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockName, TestData);
        }

        [TestMethod]
        public void StockDescriptionPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property 
            string TestData = " Poster of all spidermen together";
            //assign the data to the property 
            AnStock.StockDescription = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnStock.StockDescription, TestData);
        }

    }
}
