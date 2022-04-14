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

        [TestMethod]
        public void UpdateMethodOk() 
        {
            // make an instance of collection
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            
            //test data
           
            //create test supplier data
            clsSupplier TestData = new clsSupplier();
            
            //variable to stroe primary key
            Int32 PrimaryKey = 0;

            //Setting attributes 
            TestData.SupplierName = "Genshin";
            TestData.SupplierEmail = "Genshin@outlook.com";
            TestData.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = true;

            //set this address to test data
            AllSupplier.ThisSupplier = TestData;
            //add record
            PrimaryKey = AllSupplier.Add();
            //set the primarky key of data
            TestData.SupplierID = PrimaryKey;

            //modifying test Data
            TestData.SupplierName = "Genshins";
            TestData.SupplierEmail = "Genshins@outlook.com";
            TestData.SupplierAddress = "29 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = false;

            AllSupplier.ThisSupplier = TestData;

            //update record
            AllSupplier.Update();

            //Find Recond
            AllSupplier.ThisSupplier.Find(PrimaryKey);

            //See if result matches
            Assert.AreEqual(AllSupplier.ThisSupplier, TestData);
        }

        [TestMethod]
        public void DeleteMethodOk()   
        {
            //create an instance of Supplier List
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            //create the test data
            clsSupplier TestData = new clsSupplier();

            //store primary key
            Int32 PrimaryKey = 0;

            //set attributes
            TestData.SupplierID = 2;
            TestData.SupplierName = "Genshin";
            TestData.SupplierEmail = "Genshin@outlook.com";
            TestData.SupplierAddress = "28 Eastgate, Lincoln LN2 4AA";
            TestData.StartDateSupplier = DateTime.Now.Date;
            TestData.SupplierDiscountPrice = true;
            //set this supplier to test data
            AllSupplier.ThisSupplier = TestData;
            //add record
            PrimaryKey = AllSupplier.Add();
            //set primary ket to test data
            TestData.SupplierID = PrimaryKey;
            //find record
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            //delete record
            AllSupplier.Delete();

            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            //test to see if record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByAddressMethodOk() 
        {
            //create an instance of the class contatining 
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            //create instance  of the filter data
            clsSupplierCollection FilteredSupplier = new clsSupplierCollection();
            //apply a blank string (aim is to return all records)
            FilteredSupplier.ReportByAddress("");
            //test to see that value matches
            Assert.AreEqual(SupplierList.Count, FilteredSupplier.Count);
        }
        [TestMethod]
        public void ReportByAddressByNoneFound() 
        {
            //create an instance of supplier collection
            clsSupplierCollection FilteredSupplierList = new clsSupplierCollection();
            Boolean OK = true;
            //apply a randome asupplier addresss
            FilteredSupplierList.ReportByAddress("21 York Pl, Edinburgh EH1 3EN");
            if (FilteredSupplierList.Count == 2)
            {
                if (FilteredSupplierList.SupplierList[0].SupplierID != 3)
                {
                    OK = false;
                }
                if (FilteredSupplierList.SupplierList[1].SupplierID != 406)
                {
                    OK = false;
                }
            }
            else 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
