using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
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
            Int32 SupplierID =2;
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
    }
}
