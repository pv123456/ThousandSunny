using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        //Constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //Stores the record count
            Int32 RecordCount = 0;
            //Object for data connection
            clsDataConnection DB = new clsDataConnection();
            //Execute the stored procedures
            DB.Execute("sproc_tblStaffManagment_SelectAll");
            //Get the count of records
            RecordCount = DB.Count;
            //While there are records to process
            while (Index < RecordCount)
            {
                //Create blank staff
                clsStaff AStaff = new clsStaff();
                //Read in the fields from current records
                AStaff.StaffFullName = Convert.ToString(DB.DataTable.Rows[Index]["StaffFullName"]);
                AStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AStaff.StaffPassword = Convert.ToString(DB.DataTable.Rows[Index]["StaffPassword"]);
                AStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AStaff.IsAdmin = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAdmin"]);
                //Add the record the the private data member
                mStaffList.Add(AStaff);
                //Point index to next record
                Index++;

            }
        }

        //Public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }

            set
            {
                //Set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }

            set
            {
              
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }

            set
            {
                mThisStaff = value;
            }
        }

        public int add()
        {
            clsDataConnection DB = new clsDataConnection();
            //Set the perameters for the stored procedure
            DB.AddParameter("@StaffFullName", mThisStaff.StaffFullName);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsAdmin", mThisStaff.IsAdmin);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPassword", mThisStaff.StaffPassword);
            //Execute the query returning the primary key value
            return DB.Execute("sproc_tblStaffManagment_Insert");
        }
    }
}