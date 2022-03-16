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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StockID = 11;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //test to see that the result is correct 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create 
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search 
            Boolean Found = false;
            //boolean  variable to record if data is OK 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockID = 11;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the stock id
            if (AnStock.StockID != 11)
            {
                OK = false;
            }
            //test to see that the result is correct 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStockpriceFound()
        {
            //make an instance of Stock
            clsStock AnStock = new clsStock();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 StockID = 11;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check price  of stock matches
            if (AnStock.StockPrice != 2)
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockLastAddedFound()
        {
            //make an instance of Stock
            clsStock AnStock = new clsStock();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 StockID = 11;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check last added of stock matches
            if (AnStock.StockLastAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockNameFound()
        {
            //make an instance of Stock
            clsStock AnStock = new clsStock();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 StockID = 11;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check name of stock matches
            if (AnStock.StockName != Convert.ToString("Test Name"))
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAvailabilityFound()
        {
            //make an instance of Stock
            clsStock AnStock = new clsStock();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 StockID = 11;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check Avalibility  of stock matches
            if (AnStock.StockAvailability != true)
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockDescriptionFound()
        {
            //make an instance of Stock
            clsStock AnStock = new clsStock();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 StockID = 11;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check Description  of stock matches
            if (AnStock.StockDescription != Convert.ToString("Test Description"))
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

    }
}
