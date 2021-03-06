using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            //Sets it properties
            TestItem.StaffId = 2;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;
            //Add te item to the test list
            TestList.Add(TestItem);
            //Assign the data to the propertie
            AllStaff.StaffList = TestList;
            //Test to see the two values asr the same
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

        //[TestMethod]
        //public void StaffCountOK()
        //{
        //    clsStaffCollection AllStaff = new clsStaffCollection();
        //    //Create some test data to assign to the property
        //    Int32 SomeCount = 0;
        //    //Assign data to the property
        //    AllStaff.Count = SomeCount;
        //    //Test to see that the two values are the same
        //    Assert.AreEqual(AllStaff.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();

            clsStaff TestItem = new clsStaff();
            //Sets it properties
            TestItem.StaffId = 2;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;

            //Assign the data to the propertie
            AllStaff.ThisStaff = TestItem;
            //Test to see the two values asr the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            //Sets it properties
            TestItem.StaffId = 2;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;
            //Add te item to the test list
            TestList.Add(TestItem);
            //Assign the data to the propertie
            AllStaff.StaffList = TestList;
            //Test to see the two values asr the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);


        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.StaffId = 1;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;
            //Sets this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.add();
            //Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the two variables are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.StaffId = 4;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;
            //Sets this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.add();
            //Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            //Modify the test data
            TestItem.StaffId = 5;
            TestItem.StaffFullName = "Joey koh";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "Joey@outlook.com";
            TestItem.StaffPassword = "joyyo";
            TestItem.IsAdmin = true;
            //set the record based on the new test data
            AllStaff.ThisStaff = TestItem;
            //update the record
            AllStaff.Update();
            //Find the record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see if ThisStaff matches TestData
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create the item of test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Sets its properties
            TestItem.StaffId = 1;
            TestItem.StaffFullName = "Erwin Smith";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.StaffEmail = "ErwinS@outlook.com";
            TestItem.StaffPassword = "SA123";
            TestItem.IsAdmin = true;
            //Sets this staff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add the record
            PrimaryKey = AllStaff.add();
            //Set the primary key of the test data
            TestItem.StaffId = PrimaryKey;
            AllStaff.Delete();
            //Find the record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to see that the two variables are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of filtered data
            clsStaffCollection FilteredNames = new clsStaffCollection();
            //apply a blenk screen(should return all records)
            FilteredNames.ReportByName("");
            //test to see the two values are the same
            Assert.AreEqual(AllStaff.Count, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsStaffCollection FilteredNames = new clsStaffCollection();
            FilteredNames.ReportByName("yyy");
            Assert.AreEqual(0, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create an instance of filtered data
            clsStaffCollection FilteredNames = new clsStaffCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that exists
            FilteredNames.ReportByName("xxx xxx");
            //check the correct number of records are found
            if(FilteredNames.Count == 2)
            {
                //check that the first record has ID 9
                if (FilteredNames.StaffList[0].StaffId != 9)
                {
                    OK = false;
                }
                //check that the second record has ID 10
                if (FilteredNames.StaffList[1].StaffId != 10)
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
