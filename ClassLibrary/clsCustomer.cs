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
                return mCustId;
            }
            set
            {
                //sends data out of property
                mCustId = value;
            }
        }
        private String mCustUsername;
        public string CustUsername
        {
            get
            {
                return mCustUsername;
            }
            set
            {
                mCustUsername = value;
            }
        }
        private String mCustPassword;
        public string CustPassword
        {
            get
            {
                return mCustPassword;
            }
            set
            {
                mCustPassword = value;
            }
        }
        private String mCustEmail;
        public string CustEmail
        {
            get
            {
                return mCustEmail;
            }
            set
            {
                mCustEmail = value;
            }
        }
        private DateTime mCustDOB;
        public DateTime CustDOB
        {
            get
            {
                return mCustDOB;
            }
            set
            {
                mCustDOB = value;
            }
        }
        private Boolean mOver18;
        public bool Over18
        {
            get
            {
                return mOver18;
            }
            set
            {
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
                return true;
            }
            else
            { 
                return false;
            }
                //allows data into property
                mCustId = value;
            }
        }
        public string CustUsername { get; set; }
        public string CustPassword { get; set; }
        public string CustEmail { get; set; }
        public DateTime CustDOB { get; set; }
        public bool Over18 { get; set; }

        public bool Find(int custId)
        {
            mCustId = 21;
            return true;
        }
    }
}
