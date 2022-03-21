using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the address  no property
        private Int32 mSupplierID;
        private DateTime mStartDateSupplier;
        private String mSupplierName;
        private String mSupplierEmail;
        private String mSupplierAddress;
        private Boolean mSupplierDiscountPrice;
        public bool SupplierDiscountPrice {
            get 
            {
                //get the value of Supplier Discount Price
                return mSupplierDiscountPrice;
            }
            set 
            {
                // allow data to be set in Supplier Discount Price
                mSupplierDiscountPrice = value;
            }
        }
        public DateTime StartDateSupplier {
            get
            {
                //get the value of Start Data Supplier
                return mStartDateSupplier;
            } 
            set 
            {
                //allows data to be set in Start Date Supplier
                mStartDateSupplier = value;
            } 
        }
        public Int32 SupplierID {
            get 
            {
                //  send supplier data out
                return mSupplierID;
            } 
            set 
            {
                // allows data into supplier 
                mSupplierID = value;
            } 
        }
        public string SupplierName { get 
            {
                //get the value of Supplier Name
                return mSupplierName;
            } 
            set 
            {
                //allow data to be set in Supplier Name
                mSupplierName = value;
            }
        }
        public string SupplierEmail { 
            get 
            {
                //get the value of supplier Email
                return mSupplierEmail;
            }
            set 
            {
                //allow data to be set in Supplier Email
                mSupplierEmail = value;
            }
        }
        public string SupplierAddress { 
            get 
            {
                //get the value of supplier Email
                return mSupplierAddress;
            } 
            set 
            {
                //allow data to be set in Supplier Address
                mSupplierAddress = value;
            } 
        }

        public bool Find(int SupplierID)
        {
            //make an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for supplier ID to search
            DB.AddParameter("@SupplierID", SupplierID);
            //exacture stored procedure
            DB.Execute("sproc_tblSupplierID_FilterBySupplierID");
            //if there one match or no match 
            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mSupplierName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mSupplierEmail = Convert.ToString(DB.DataTable.Rows[0]["SupplierEmail"]);
                mSupplierAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mStartDateSupplier = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDateSupplier"]);
                mSupplierDiscountPrice = Convert.ToBoolean(DB.DataTable.Rows[0]["SupplierDiscountPrice"]);
                //return true if everything worked
                return true;
            }
            else 
            {
            return false;
            }
        }

        public string Valid(string supplierName, string supplierEmail, string supplierAddress, string startDateSupplier)
        {
            //make string variable
            string Error = "";
            DateTime DateTemp;
            if (supplierName.Length == 0) 

            {
                Error = Error + "The Supplier Name may not be blank";
            }
            if (supplierName.Length > 50) 
            {
                Error = Error + "<br>" + "The Supplier Name must be less than 50";
            }
            if (supplierEmail.Length == 0) 
            {
                Error = Error + "<br>" + "The Supplier Email may not be blank";
            }
            if (supplierEmail.Length > 50) 
            {
                Error = Error + "<br>" + "The Supplier Email must be less than 50";
            }
            if (supplierAddress.Length == 0) 
            {
                Error = Error + "<br>" + "The Supplier Address may not be blank";
            }
            if (supplierAddress.Length > 50)
            {
                Error = Error + "<br>" + "The Supplier Address must be less than 50";
            }

            try
            {
                DateTemp = Convert.ToDateTime(startDateSupplier);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "<br>" + "The date cannot be in the past";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "<br>" + "The date cannot be in the future";
                }
            }
            catch 
            {
                    Error = Error + "<br>" + "The date was not valid date";
            }

            return Error;
        }

        
    }
}