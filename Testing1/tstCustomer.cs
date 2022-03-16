
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance of the Customer class
            clsCustomer ACustomer = new clsCustomer();
            //Tests to see if it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustEmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "ErwinSmith@gmail.com";
            //assign the data to the property
            ACustomer.CustEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustEmail, TestData);
        }

        [TestMethod]
        public void CustPasswordOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "ThisPassword";
            ACustomer.CustPassword = TestData;
            Assert.AreEqual(ACustomer.CustPassword, TestData);
        }
        [TestMethod]
        public void CustIdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.CustId = TestData;
            Assert.AreEqual(ACustomer.CustId, TestData);
        }

        [TestMethod]
        public void CustUsernameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "ErwinSmith";
            ACustomer.CustUsername = TestData;
            Assert.AreEqual(ACustomer.CustUsername, TestData);
        }

        [TestMethod]
        public void CustDOBOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.CustDOB = TestData;
            Assert.AreEqual(ACustomer.CustDOB, TestData);
        }

        [TestMethod]
        public void Over18OK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Over18 = TestData;
            Assert.AreEqual(ACustomer.Over18, TestData);
        }

        
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            Assert.IsTrue(Found);
        }
      
        [TestMethod]
        public void TestCustIdFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.CustId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustUsernameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.CustUsername != "TestName")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustPasswordFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.CustPassword != "TestTest")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.CustEmail != "test@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.CustDOB != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOver18Found()
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustId = 21;
            Found = ACustomer.Find(CustId);
            if (ACustomer.Over18 != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
