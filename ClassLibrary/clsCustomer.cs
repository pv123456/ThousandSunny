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