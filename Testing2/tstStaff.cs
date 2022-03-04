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
    }
}
