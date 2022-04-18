using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustId;
        public Int32 CustId
        {
            get
            {
                //sends data out of property
                return mCustId;
            }
            set
            {
                //allows data into property
                mCustId = value;
            }
        }
        private String mCustUsername;
        public String CustUsername
        {
            get
            {
                //sends data out of property
                return mCustUsername;
            }
            set
            {
                //allows data into property
                mCustUsername = value;
            }
        }
        private String mCustPassword;
        public String CustPassword
        {
            get
            {
                //sends data out of property
                return mCustPassword;
            }
            set
            {
                //allows data into property
                mCustPassword = value;
            }
        }
        private String mCustEmail;
        public String CustEmail
        {
            get
            {
                //sends data out of property
                return mCustEmail;
            }
            set
            {
                //allows data into property
                mCustEmail = value;
            }
        }
        private DateTime mCustDOB;
        public DateTime CustDOB
        {
            get
            {
                //sends data out of property
                return mCustDOB;
            }
            set
            {
                //allows data into property
                mCustDOB = value;
            }
        }
        private bool mOver18;
        public bool Over18
        {
            get
            {
                //sends data out of property
                return mOver18;
            }
            set
            {
                //allows data into property
                mOver18 = value;
            }
        }

        public bool Find(int CustId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustId);
            DB.Execute("sproc_tblCustomerManagement_FilterByCustId");
            if (DB.Count == 1)
            {
                mCustId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustUsername = Convert.ToString(DB.DataTable.Rows[0]["CustUsername"]);
                mCustPassword = Convert.ToString(DB.DataTable.Rows[0]["CustPassword"]);
                mCustEmail = Convert.ToString(DB.DataTable.Rows[0]["CustEmail"]);
                mCustDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                //Always return true
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}