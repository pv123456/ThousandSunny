using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for Stock Availability
        private Boolean mStockAvailability;
        //public property for Stock Availability
        public bool StockAvailability
        {
            get
            {
                //return the private data
                return mStockAvailability;
            }
            set
            {
                //set the private data
                mStockAvailability = value;
            }
        }

        //private date added data member 
        private DateTime mStockLastAdded;
        //public property for date added
        public DateTime StockLastAdded
        {
            get
            {
                //return the private data 
                return mStockLastAdded;
            }
            set
            {
                //set the private data 
                mStockLastAdded = value;
            }
        }

        //private data member for the stockID property
        private Int32 mStockID;
        //public property for the address number 
        public int StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the value of the private data member 
                mStockID = value;
            }
        }

        //private data member for Stock price
        private decimal mStockPrice;
        //public property for stock price 
        public decimal StockPrice
        {
            get
            {
                //return the private data 
                return mStockPrice;
            }
            set
            {
                //set the private data 
                mStockPrice = value;
            }
        }

        //private data member for stock name
        private string mStockName;
        //public property for stock name 
        public string StockName
        {
            get
            {
                //return private data 
                return mStockName;
            }
            set
            {
                //set the private data
                mStockName = value;
            }
        }

        //private data member for Stock description
        private string mStockDescription;
        //public property for post code
        public string StockDescription
        {
            get
            {
                //return the private data 
                return mStockDescription;
            }
            set
            {
                //set the private data 
                mStockDescription = value;
            }
        }

        public bool Find(int StockID)
        {
            {
                //create an instance of the data connection 
                clsDataConnection DB = new clsDataConnection();
                //add the parameter for the address no to search for 
                DB.AddParameter("@StockID", StockID);
                //execute the stored procedure 
                DB.Execute("sproc_tblStock_FilterByStockID");
                //if one record is found 
                if (DB.Count == 1)
                {
                    //copy the data from the database to the private data members 
                    mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                    mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                    mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                    mStockLastAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StockLastAdded"]);
                    mStockPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
                    mStockAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailability"]);
                    //always return true 
                    return true;
                }
                //if no record was found 
                else
                {
                    //return false indicating a problem 
                    return false;
                }
            }
        }

        public string Valid(string StockName, string StockLastAdded, string StockDescription)
        {
            string Error = "";

            DateTime DateTemp;

            if (StockName.Length == 0)
            {
                Error = Error + "The stock name may be blank : ";
            }
            if (StockName.Length > 30)
            {
                Error = Error + "The Stock Name should be less then 30 charcters : ";
            }
            try
            {

                DateTemp = Convert.ToDateTime(StockLastAdded);

                if (DateTemp < DateTime.Now.Date)
                {

                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)

                {

                    Error = Error + "The date cannot be in the future : ";
                }
            }


            catch

            {

                Error = Error + "The date was not a valid date : ";
            }

            if (StockDescription.Length == 0)
            {

                Error = Error + " The description may be blank : ";
            }

            if (StockDescription.Length > 50)
            {
                Error = Error + " The stock description must be less then 50 charcters : ";

            }
            return Error;
        }

        public static implicit operator clsStock(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator int(clsStock v)
        {
            throw new NotImplementedException();
        }
    }
}

    

    