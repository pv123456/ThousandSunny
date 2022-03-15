using System;


namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the StockID property
        private Int32 mStockID;
        //StockID public property
        public Int32 StockID
        {
            get
            {
                //this line of code sends data out of the property 
                return mStockID;
            }
            set
            {
                //this line of code allows data into the property 
                mStockID = value;
            }

        }


        //private data member for Availability
        private Boolean mStockAvailability;
        //public property for Availability
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

        //private data added data member 
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

        //private data member for Stock Price 
        private decimal mStockPrice;
        //public property for Stock Price 
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

        //private data member for Stock Name
        private string mStockName;
        //public data member for street
        public string StockName
        {
            get
            {
                //return the private data 
                return mStockName;
            }
            set
            {
                //set the private data 
                mStockName = value;
            }
        }

        //private data member for Stock Description
        private string mStockDescription;
        //public data member for Stock Description
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



        public bool Find(int stockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock ID to search for 
            DB.AddParameter("@StockID", stockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mStockPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
                mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                mStockLastAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StockLastAdded"]);
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailability"]);
                //return that everything worked OK
                return true;
            }
            // if no record was found 
            else
            {
                //return false indication a problem 
                return false;
            }
        }
    }
}
    

    