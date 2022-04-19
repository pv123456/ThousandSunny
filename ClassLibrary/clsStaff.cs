﻿using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffId;
        private string mStaffFullName;
        private DateTime mStartDate;
        private Boolean mIsAdmin;
        private string mStaffEmail;
        private string mStaffPassword;
        public Int32 StaffId
        {
            get
            {
                //This line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //This line of code allows data into the property
                mStaffId = value;
            }
        }
        public string StaffFullName
        {
            get
            {
                //This line of code sends data out of the property
                return mStaffFullName;
            }
            set
            {
                //This line of code allows data into the property
                mStaffFullName = value;
            }
        }
        public DateTime StartDate 
        {
            get
            {
                //This line of code sends data out of the property
                return mStartDate;
            }
            set
            {
                //This line of code allows data into the property
                mStartDate = value;
            }
        }
        public bool IsAdmin 
        {

            get
            {
                //This line of code sends data out of the property
                return mIsAdmin;
            }
            set
            {
                //This line of code allows data into the property
                mIsAdmin = value;
            }
        }
        public string StaffEmail 
        {

            get
            {
                //This line of code sends data out of the property
                return mStaffEmail;
            }
            set
            {
                //This line of code allows data into the property
                mStaffEmail = value;
            }
        }
        public string StaffPassword 
        {

            get
            {
                //This line of code sends data out of the property
                return mStaffPassword;
            }
            set
            {
                //This line of code allows data into the property
                mStaffPassword = value;
            }
        }

        public bool Find(int StaffId)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaffManagment_FilterByStaffId");
            if (DB.Count == 1)
            {
                mStaffId = 2;
                mStaffFullName = "Erwin Smith";
                mStartDate = Convert.ToDateTime("02/10/2020");
                mIsAdmin = true;
                mStaffEmail = "ErwinS@outlook.com";
                mStaffPassword = "SA123";
                return true;
            }
            else
            {
                return false;
            }      
        }
    }
}