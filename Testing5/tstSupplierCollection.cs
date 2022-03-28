using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic; 


namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //see if the test exist
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]

        public void SupplierListOk()
        {
            // make an instance of collection
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //test data
            List<clsSupplier> TestList = new List<clsSupplier>();
            //create test supplier data
            clsSupplier TestData = new clsSupplier();
            //Setting attributes 
            TestData.SupplierID = 2;
            TestData.SupplierName = "Genshin";
            TestData.SupplierEmail = "Genshin@outlook.com";
            TestData.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = true;
            // add data to list
            TestList.Add(TestData);
            //assign data to property
            AllSupplier.SupplierList = TestList;
            // see if value  matches
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }
      


        [TestMethod]
        public void ThisSupplierPropertyOk()
        {
            // make an instance of collection
            clsSupplierCollection AllSupplier = new clsSupplierCollection();

            //create test supplier data
            clsSupplier TestSupplier = new clsSupplier();
            //Setting attributes 
            TestSupplier.SupplierID = 2;
            TestSupplier.SupplierName = "Genshin";
            TestSupplier.SupplierEmail = "Genshin@outlook.com";
            TestSupplier.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestSupplier.StartDateSupplier = DateTime.Now.Date;
            TestSupplier.SupplierDiscountPrice = true;
            //assign data to property
            AllSupplier.ThisSupplier = TestSupplier;
            // see if value  matches
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            // make an instance of collection
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //test data
            List<clsSupplier> TestList = new List<clsSupplier>();
            //create test supplier data
            clsSupplier TestData = new clsSupplier();
            //Setting attributes 
            TestData.SupplierID = 2;
            TestData.SupplierName = "Genshin";
            TestData.SupplierEmail = "Genshin@outlook.com";
            TestData.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = true;
            // add data to list
            TestList.Add(TestData);
            //assign data to property
            AllSupplier.SupplierList = TestList;
            // see if value  matches
            Assert.AreEqual(AllSupplier.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk() 
        {
            // make an instance of collection
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //test data
            //create test supplier data
            clsSupplier TestData = new clsSupplier();
            Int32 PrimaryKey = 0;

            //Setting attributes 
            TestData.SupplierID = 2;
            TestData.SupplierName = "Genshin";
            TestData.SupplierEmail = "Genshin@outlook.com";
            TestData.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = true;

            //Setting ThisSupplier to testdata
            AllSupplier.ThisSupplier = TestData;
            //Add the record
            PrimaryKey = AllSupplier.Add();
            //set Primary Key to test data
            TestData.SupplierID = PrimaryKey;
            //find record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see if value match
            Assert.AreEqual(AllSupplier.ThisSupplier, TestData);

        }
    }
}
