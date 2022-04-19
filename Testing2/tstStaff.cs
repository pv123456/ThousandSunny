using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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
        public void IsAdmin()
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
    }
}
