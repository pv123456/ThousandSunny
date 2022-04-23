using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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


        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomerManagement_SelectAll");
            RecordCount = DB.Count;
            while(Index<RecordCount)
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