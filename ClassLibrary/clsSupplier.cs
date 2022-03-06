using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        //private data member for the address  no property
        private Int32 mSupplierId;
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
        public Int32 SupplierId {
            get 
            {
                //  send supplier data out
                return mSupplierId;
            } 
            set 
            {
                // allows data into supplier 
                mSupplierId = value;
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

        public bool Find(int supplierID)
        {
            //always return true
            mSupplierId = 2;
            mStartDateSupplier = Convert.ToDateTime("15/08/2008");
            mSupplierName = "Genshin";
            mSupplierEmail = "Genshin@outlook.com";
            mSupplierAddress = "28 Eastgate,Lincoln LN2 4AA";
            mSupplierDiscountPrice = true;
            return true;
        }
    }
}