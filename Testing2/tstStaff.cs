using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        string StaffFullName = "Light Yagi";
        string StartDate = DateTime.Now.Date.ToString();
        string StaffEmail = "Light@gmail.com";
        string StaffPassword = "Note222";

        [TestMethod]
        public void InstanceOK()
        {
            //Creates an instance of the staff class
            clsStaff AStaff = new clsStaff();
            //Tests to see if it exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffFullNameOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Erwin Smith";
            //assign the data to the property
            AStaff.StaffFullName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffFullName, TestData);
        }

        [TestMethod]
        public void StartDateOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStaff.StartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StartDate, TestData);
        }

        [TestMethod]
        public void IsAdminOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.IsAdmin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.IsAdmin, TestData);
        }

        [TestMethod]
        public void StaffEmailOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "ErwinSmith@Gmail.com";
            //assign the data to the property
            AStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffEmail, TestData);
        }

        [TestMethod]
        public void StaffPasswordOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "ThisPassword";
            //assign the data to the property
            AStaff.StaffPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffPassword, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.StaffId != 2)
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffFullNameFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.StaffFullName != "Erwin Smith")
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffStartDateFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.StartDate != Convert.ToDateTime("02/10/2020"))
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIsAdminFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.IsAdmin != true)
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.StaffEmail != "ErwinS@outlook.com")
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean vatiable to record if data os ok
            Boolean OK = true;
            //Create some test data to be used with the method
            Int32 StaffId = 2;
            //Invoke the method
            Found = AStaff.Find(StaffId);
            //Cheack the Staff ID
            if (AStaff.StaffPassword != "SA123")
            {
                OK = false;
            }
            //Test to see if result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
        }

        [TestMethod]
        public void StaffFullNameMinLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMin()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "L";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMinPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "Ll";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(99, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(100, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMaxPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(101, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameMid()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(50, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffFullNameExtremeMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffFullName = "";
            StaffFullName = StaffFullName.PadRight(500, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMin()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMin()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StartDateMinPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateExtremeMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StartDateInvalidData()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StartDate = "This is not a date";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailNameMin()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "L";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailNameMinPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "Ll";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(49, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(50, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(51, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailMid()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(25, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "L";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMinPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "Ll";
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxLessOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(49, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(50, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMaxPlusOne()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(51, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(25, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            //Creates an instant of the class we want to create
            clsStaff AStaff = new clsStaff();
            //String variable to store any error message
            String Error = "";
            //Create some test data to pass to the method
            string StaffPassword = "";
            StaffPassword = StaffPassword.PadRight(500, 'l');
            //invoke the method
            Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
            //Test to see if the results are correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
