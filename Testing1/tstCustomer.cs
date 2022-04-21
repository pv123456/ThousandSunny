using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string CustUsername = "TestName1";
        string CustPassword = "TestTest1";
        string CustEmail = "test1@gmail.com";
        string CustDOB = DateTime.Now.Date.ToString();

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

        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustId = 1;
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
        {
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

        //Valid Testing

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error,"");
        }

        [TestMethod]
        public void custUsernameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = ""; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "a"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "aa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "aaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "aaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "aaaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "aaaaaaaaaaaaaaaa"; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void custUsernameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustUsername = "";
            CustUsername = CustUsername.PadRight(500, 'a'); //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        //CustPassword Tests
        [TestMethod]
        public void CustPasswordMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = ""; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "a"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "aa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "aaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "aaaaaaaaaaaaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustPasswordExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustPassword = "";
            CustEmail = CustPassword.PadRight(500, 'a'); //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }



        //CustEmail Tests
        [TestMethod]
        public void CustEmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = ""; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "a"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "aa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "aaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "aaaaaaaaaaaaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //Should pass
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "aaaaaaaaaaaaaaaaaaaaaaaaaa"; //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustEmail = "";
            CustEmail = CustEmail.PadRight(500, 'a'); //Should fail
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }


        //CustDOB Tests
        [TestMethod]
        public void CustDOBExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-500); //Should Fail
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101); //Should Fail
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100); //Should Pass
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99); //Should Pass
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50); //Should Pass
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1); //Should Pass
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;//Should Pass
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1); //Should Fail
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100); //Should Fail
            string CustDOB = TestDate.ToString();
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustDOBInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string CustDOB = "Not a date";
            Error = ACustomer.Valid(CustUsername, CustPassword, CustEmail, CustDOB);
            Assert.AreNotEqual(Error, "");
        }

    }
}
