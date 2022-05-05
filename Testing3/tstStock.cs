using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        string StockName = "Avengers";
        string StockDescription = "All the Avengers cast";
        string StockLastAdded = DateTime.Now.Date.ToString();


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
            String TestData = "coffee";
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
            String TestData = " Poster of coffee";
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
            Int32 StockID = 2;
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
            Int32 StockID = 21;
            //invoke the method 
            Found = AnStock.Find(StockID);
            //check the stock id
            if (AnStock.StockID != 21)
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
            Int32 StockID = 13;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check price  of stock matches
            if (AnStock.StockPrice != 3)
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
            Int32 StockID = 13;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check last added of stock matches
            if (AnStock.StockLastAdded != Convert.ToDateTime("31/03/2022"))
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
            Int32 StockID = 13;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check name of stock matches
            if (AnStock.StockName != Convert.ToString("SuperMan"))
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
            Int32 StockID = 13;
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
            Int32 StockID = 13;
            //invoke find method
            Found = AnStock.Find(StockID);
            //check Description  of stock matches
            if (AnStock.StockDescription != Convert.ToString("poster of all superman"))
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidateMethodOK()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMinlessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string StockName = "";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "b";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNamePlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "bb";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockNameMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "";
            StockName = StockName.PadRight(29, 'b');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "";
            StockName = StockName.PadRight(30, 'b');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "";
            StockName = StockName.PadRight(15, 'b');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNameExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockName = "";
            StockName = StockName.PadRight(100, 'b');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void StockDescriptionLessOne()
        {

            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMin()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "a";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }
      
        [TestMethod]
        public void StockDescriptionPlusOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "aa";
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void StockDescriptionMaxLessOne()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(49, 'a');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }
         
      [TestMethod]
      public void StockDescriptionMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(50, 'a');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionMid()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(25, 'a');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockDescriptionExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            string StockDescription = "";
            StockDescription = StockDescription.PadRight(100, 'a');
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StockLastAddedExtremeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-200);

            string StockLastAdded = TestDate.ToString();

            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastAddedMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(-1);

            string StockLastAdded = TestDate.ToString();

            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);

            Assert.AreNotEqual(Error, "");
        }

        

        [TestMethod]
        public void StockLastAddedMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            DateTime TestDate;

            TestDate = DateTime.Now.Date;

            TestDate = TestDate.AddYears(1);

            string StockLastAdded = TestDate.ToString();

            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //covert data variable to string variable
            string StockLastAdded = TestData.ToString();
            //invoke method
            Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }





        [TestMethod]
        public void StockLastAddedExtremeMax()
        {
            clsStock AnStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StockLastAdded = TestDate.ToString();
            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockLastAddedInvalidData()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockLastAdded = "This is not a date!";

            Error = AnStock.Valid(StockName, StockLastAdded, StockDescription);

            Assert.AreNotEqual(Error, "");
        }

        

    }
}





