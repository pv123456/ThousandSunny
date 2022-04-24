using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustId = 1;
            TestItem.CustUsername = "TestName";
            TestItem.CustPassword = "TestTest";
            TestItem.CustEmail = "test@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = false;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustId = 1;
            TestCustomer.CustUsername = "TestName";
            TestCustomer.CustPassword = "TestTest";
            TestCustomer.CustEmail = "test@gmail.com";
            TestCustomer.CustDOB = DateTime.Now.Date;
            TestCustomer.Over18 = false;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.CustId = 1;
            TestItem.CustUsername = "TestName";
            TestItem.CustPassword = "TestTest";
            TestItem.CustEmail = "test@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = false;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustId = 15;
            TestItem.CustUsername = "JohnBale";
            TestItem.CustPassword = "baleofhay1";
            TestItem.CustEmail = "johnbale1@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = true;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustUsername = "Test";
            TestItem.CustPassword = "TestTest";
            TestItem.CustEmail = "testemail@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = false;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustId = PrimaryKey;
            TestItem.CustUsername = "NotTest";
            TestItem.CustPassword = "NotTestTest";
            TestItem.CustEmail = "nottest@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = true;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.CustId = 1;
            TestItem.CustUsername = "Test";
            TestItem.CustPassword = "TestTest";
            TestItem.CustEmail = "testemail@gmail.com";
            TestItem.CustDOB = DateTime.Now.Date;
            TestItem.Over18 = false;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }


    }
}
