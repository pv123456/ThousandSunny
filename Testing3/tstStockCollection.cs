using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {

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

            clsStock TestData = new clsStock();

            TestData.StockID = 2;
            TestData.StockAvailability = true;
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockName = "spiderman";
            TestData.StockDescription = "poster of all spidermen together";
            TestData.StockPrice = 3;

            TestList.Add(TestData);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();

            TestStock.StockID = 2;
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

            clsStock TestData = new clsStock();

            TestData.StockID = 2;
            TestData.StockAvailability = true;
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockName = "spiderman";
            TestData.StockDescription = "poster of all spidermen together";
            TestData.StockPrice = 3;

            TestList.Add(TestData);

            AllStock.StockList = TestList;

            Assert.AreEqual(AllStock.Count, TestList.Count);
        }



        [TestMethod]
        public void AddMethodOk()
        {
            // make an instance of collection
            clsStockCollection AllStock = new clsStockCollection();
            //test data
            //create test data
            clsStock TestData = new clsStock();
            Int32 PrimaryKey = 0;

            //Setting attributes 
            TestData.StockID = 11;
            TestData.StockName = "SpiderMan";
            TestData.StockDescription = "All the spiderMen";
            TestData.StockPrice = 3;
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockAvailability = true;

            //Setting  to testdata
            AllStock.ThisStock = TestData;
            //Add the record
            PrimaryKey = AllStock.Add();
            //set Primary Key to test data
            TestData.StockID = PrimaryKey;
            //find record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see if value match
            Assert.AreEqual(AllStock.ThisStock, TestData);

        }





        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestData = new clsStock();

            Int32 PrimaryKey = 0;

            TestData.StockAvailability = true;
            TestData.StockName = "SpiderMan";
            TestData.StockDescription = "Spiderman image";
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockPrice = 2;


            AllStock.ThisStock = TestData;

            PrimaryKey = AllStock.Add();

            TestData.StockID = PrimaryKey;

            TestData.StockAvailability = false;
            TestData.StockName = "Coffee";
            TestData.StockDescription = "Coffee image";
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockPrice = 2;

            AllStock.ThisStock = TestData;

            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestData);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            //create an instance of Supplier List
            clsStockCollection AllStock = new clsStockCollection();
            //create the test data
            clsStock TestData = new clsStock();

            //store primary key
            Int32 PrimaryKey = 0;

            //set attributes
            TestData.StockAvailability = true;
            TestData.StockID = 2;
            TestData.StockLastAdded = DateTime.Now.Date;
            TestData.StockName = "SpiderMan";
            TestData.StockDescription = "All the spiderMen";
            TestData.StockPrice = 3;

            //set  test data
            AllStock.ThisStock = TestData;
            //add record
            PrimaryKey = AllStock.Add();
            //set primary ket to test data
            TestData.StockID = PrimaryKey;
            //find record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete record
            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see if record was not found
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByStockNameMethodOK()
        {
            //create an instance of the class contatining 
            clsStockCollection StockList = new clsStockCollection();
            //create instance  of the filter data
            clsStockCollection FilteredStock = new clsStockCollection();
            //apply a blank string (aim is to return all records)
            FilteredStock.ReportByStockName("");
            //test to see that value matches
            Assert.AreEqual(StockList.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReportByStockNameNoneFound()
        {
            clsStockCollection FilteredStockList = new clsStockCollection();
            Boolean OK = true;

            FilteredStockList.ReportByStockName("Avenger");
            if (FilteredStockList.Count == 2)
            {
                if (FilteredStockList.StockList[0].StockID != 3)
                {
                    OK = false;
                }

                if (FilteredStockList.StockList[1].StockID != 328)
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

    




