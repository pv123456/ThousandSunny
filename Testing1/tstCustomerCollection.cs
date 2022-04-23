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



    }
}
