using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;
        private Decimal mStockPrice;
        private Boolean mStockAvailability;
        private DateTime mStockLastAdded;
        private String mStockName;
        private String mStockDescription;



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

        public string Valid(string StockName, string StockLastAdded, string StockDescription)
        {
            string Error = "";
            DateTime DateTemp;
            if (StockName.Length == 0)
            {
                Error = Error + "<br>" + "The stock name may be blank : ";
            }
            if (StockName.Length > 30)
            {
                Error = Error + "<br>" + "The Stock Name should be less then 30 charcters : ";
            }

            if (StockDescription.Length == 0)
            {

                Error = Error + "<br>" + " The description may be blank : ";
            }

            if (StockDescription.Length > 50)
            {
                Error = Error + "<br>" + " The stock description must be less then 50 charcters : ";

            }

            try
            {

                DateTemp = Convert.ToDateTime(StockLastAdded);

                if (DateTemp < DateTime.Now.Date)
                {

                    Error = Error + "<br>" + "The date cannot be in the past : ";
                }

                if (DateTemp > DateTime.Now.Date)

                {

                    Error = Error + "<br>" + "<br>" + "The date cannot be in the future : ";
                }
            }
            catch

            {

                Error = Error +  "<br>" + "The date was not a valid date ";
            }

            return Error;
        }

       
    }
}

    

    