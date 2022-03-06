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
    }
}