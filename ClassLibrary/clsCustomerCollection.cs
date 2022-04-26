using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList 
        { 
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        { 
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }


        public clsCustomer ThisCustomer
        { 
            get
            {
                return mThisCustomer;
            }
            set
            {
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomerManagement_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustUsername", mThisCustomer.CustUsername);
            DB.AddParameter("@CustPassword", mThisCustomer.CustPassword);
            DB.AddParameter("@CustEmail", mThisCustomer.CustEmail);
            DB.AddParameter("@custDOB", mThisCustomer.CustDOB);
            DB.AddParameter("@Over18", mThisCustomer.Over18);
            return DB.Execute("sproc_tblCustomerManagement_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustID", mThisCustomer.CustId);
            DB.AddParameter("@CustUsername", mThisCustomer.CustUsername);
            DB.AddParameter("@CustPassword", mThisCustomer.CustPassword);
            DB.AddParameter("@CustEmail", mThisCustomer.CustEmail);
            DB.AddParameter("@CustDOB", mThisCustomer.CustDOB);
            DB.AddParameter("@Over18", mThisCustomer.Over18);
            DB.Execute("sproc_tblCustomerManagement_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustID", mThisCustomer.CustId);
            DB.Execute("sproc_tblCustomerManagement_Delete");
        }

        public void ReportByEmail(string CustEmail)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustEmail", CustEmail);
            DB.Execute("sproc_tblCustomerManagement_FilterByEmail");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustID"]);
                ACustomer.CustUsername = Convert.ToString(DB.DataTable.Rows[Index]["CustUsername"]);
                ACustomer.CustPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustPassword"]);
                ACustomer.CustEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustEmail"]);
                ACustomer.CustDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustDOB"]);
                ACustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }


    }
}