using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        //Good TestData
        string SupplierName = "Genshin";
        string SupplierEmail = "Genshin@outlook.com";
        string SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
        string StartDateSupplier = DateTime.Now.Date.ToString();



        [TestMethod]
        public void InstanceOK()
        {
            //will create an instance of class i want
            clsSupplier AnSupplier = new clsSupplier();
            //Will see the class i made exist or not
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]

        public void SupplierDiscountPricePropertyOk()
        {
            //Creates an instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create some test data to assign some property
            Boolean TestData = true;
            // assign data to the property
            AnSupplier.SupplierDiscountPrice = TestData;
            // test to see if value match
            Assert.AreEqual(AnSupplier.SupplierDiscountPrice, TestData);
        }

        [TestMethod]
        public void StartDateSupplierPropertyOK()
        {
            //Create a supplier instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create test data to assign property 
            DateTime TestData = DateTime.Now.Date;
            //Assign data to propery
            AnSupplier.StartDateSupplier = TestData;
            //Test to see if value will match
            Assert.AreEqual(AnSupplier.StartDateSupplier, TestData);
        }

        [TestMethod]
        public void SupplierIdPropertyOk()
        {
            //Create a supplier instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create test data to assign property
            int TestData = 1;
            //Assign data to property 
            AnSupplier.SupplierID = TestData;
            //Test to see if value will match
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void SupplierNamePropertyOk()
        {
            //Create a supplier instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create test data to assign property
            String TestData = "Genshin";
            //Assign data to property
            AnSupplier.SupplierName = TestData;
            //Test to see if value match
            Assert.AreEqual(AnSupplier.SupplierName, TestData);
        }
        [TestMethod]
        public void SupplierEmailPropertyOk()
        {
            //Create a supplier instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create test data to assign property
            String TestData = "Genshin@outlook.com";
            //Assign data to property
            AnSupplier.SupplierEmail = TestData;
            //Test to see if value match
            Assert.AreEqual(AnSupplier.SupplierEmail, TestData);
        }
        [TestMethod]
        public void SupplierAddressPropertyOk()
        {
            //Create a supplier instance
            clsSupplier AnSupplier = new clsSupplier();
            //Create Test data to assign property
            String TestData = "28 Eastgate, Lincoln LN2 4AA";
            //Assign data to property
            AnSupplier.SupplierAddress = TestData;
            //Test to see if value match
            Assert.AreEqual(AnSupplier.SupplierAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //variable to store the result of the validation
            Boolean Found = false;
            //test data
            Int32 SupplierID = 2;
            //invoke find method     
            Found = AnSupplier.Find(SupplierID);
            //see if the test is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestSupplierIDFound()
        {
            //make an instace of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierId = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierId);
            //check the supplier id 
            if (AnSupplier.SupplierID != 2)
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStartDateSupplierFound()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierID = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierID);
            //check start date of supplier matches
            if (AnSupplier.StartDateSupplier != Convert.ToDateTime("15/08/2008"))
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierDiscountPriceFound()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierID = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierID);
            //check start date of supplier matches
            if (AnSupplier.SupplierDiscountPrice != true)
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierNameFound()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierID = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierID);
            //check start date of supplier matches
            if (AnSupplier.SupplierName != "Genshin")
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSupplierEmailFound()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierID = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierID);
            //check start date of supplier matches
            if (AnSupplier.SupplierEmail != "Genshin@outlook.com")
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestSupplierAddressFound()
        {
            //make an instance of supplier
            clsSupplier AnSupplier = new clsSupplier();
            //boolean variable 
            Boolean Found = false;
            Boolean OK = true;
            //test data
            Int32 SupplierID = 2;
            //invoke find method
            Found = AnSupplier.Find(SupplierID);
            //check start date of supplier matches
            if (AnSupplier.SupplierAddress != "28 Eastgate, Lincoln LN2 4AA")
            {
                OK = false;
            }
            //check if result matches
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidateMethodOk()
        {
            //create an instance
            clsSupplier AnSupplier = new clsSupplier();
            //store error message
            String Error = "";
            //invoke the message
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMinlessOne()
        {
            //create instance 
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store error message
            string Error = "";
            //test data trigger an error
            string SupplierName = "";
            //invoke validate method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see if result work
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "a"; //this should be ok
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void SupplierNameminPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aa";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void SupplierNameMaxlessOne()

        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(49, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(50, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierNameMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameMaxPlusOne()
        { 
       //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(51, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierName = "";
            SupplierName = SupplierName.PadRight(100, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "a";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMinPlusOne()

        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "aa";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void SupplierEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(49, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(50, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(51, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void SupplierEmailMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(25, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierEmailExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierEmail = "";
            SupplierEmail = SupplierEmail.PadRight(100, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMinLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMin()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "a";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "aa";
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(49, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void SupplierAddressMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(50, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(51, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressMid()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(25, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void SupplierAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string SupplierAddress = "";
            SupplierAddress = SupplierAddress.PadRight(100, 'a');
            //invoke the method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateSupplierExtremeMin() 
        {
            //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //chaning date to 100 year befor today
            TestData = TestData.AddYears(-200);
            //covert data variable to string variable
            string StartDateSupplier = TestData.ToString();
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateSupplierMinlessOne() 
        {
        //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //chaning date to 100 year befor today
            TestData = TestData.AddYears(-1);
            //covert data variable to string variable
            string StartDateSupplier = TestData.ToString();
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateSupplierMin() 
        {
        //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //covert data variable to string variable
            string StartDateSupplier = TestData.ToString();
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StartDateSupplierMinPlusOne() 
        {
        //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //chaning date to 100 year befor today
            TestData = TestData.AddYears(1);
            //covert data variable to string variable
            string StartDateSupplier = TestData.ToString();
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartDateSupplierExtremeMax() 
        {
        //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //Create Test data
            DateTime TestData;
            //Setting variable to today day
            TestData = DateTime.Now.Date;
            //chaning date to 100 year befor today
            TestData = TestData.AddYears(100);
            //covert data variable to string variable
            string StartDateSupplier = TestData.ToString();
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StartAddedInvalidData() 
        {
        //create an instance of the class we want to create
            clsSupplier AnSupplier = new clsSupplier();
            //string variable to store any error message
            String Error = "";
            //covert data variable to string variable
            string StartDateSupplier = "this is not a date";
            //invoke method
            Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
