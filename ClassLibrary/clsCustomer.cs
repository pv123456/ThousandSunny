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
            DB.AddParameter("@CustID", CustId);
            DB.Execute("sproc_tblCustomerManagement_FilterByCustId");
            if (DB.Count == 1)
            {
                mCustId = Convert.ToInt32(DB.DataTable.Rows[0]["CustID"]);
                mCustUsername = Convert.ToString(DB.DataTable.Rows[0]["CustUsername"]);
                mCustPassword = Convert.ToString(DB.DataTable.Rows[0]["CustPassword"]);
                mCustEmail = Convert.ToString(DB.DataTable.Rows[0]["CustEmail"]);
                mCustDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustDOB"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                //Always return true
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string custUsername, string custPassword, string custEmail, string custDOB)
        {
            String Error = "";
            DateTime DateTemp;
            DateTime CurDate = DateTime.Now.Date;
            if (custUsername.Length == 0)
            {
                Error = Error + "The username may not be blank : ";
            }
            if (custUsername.Length > 15)
            {
                Error = Error + "The username must be less that 15 characters : ";
            }
            if (custPassword.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }
            if (custPassword.Length > 25)
            {
                Error = Error + "The password must be less that 25 characters : ";
            }

            if (custEmail.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (custEmail.Length > 25)
            {
                Error = Error + "The email must be less that 25 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(custDOB);
                if (DateTemp < CurDate.AddYears(-100))
                {
                    Error = Error + "The DOB cannot be over 100 years in the past : ";
                }
                if (DateTemp > CurDate)
                {
                    Error = Error + "The DOB cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date is not a valid date : ";
            }
            return Error;

        }
    }
}