using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class clsStockCollection
    {
        
     
        List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;

            }
           set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            PopulateArray(DB);
        }


        public int Add()
        {
            //create an db connection instance 
            clsDataConnection DB = new clsDataConnection();
            //set attributes
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@StockLastAdded", mThisStock.StockLastAdded);
            DB.AddParameter("@StockAvailability", mThisStock.StockAvailability);
            //exacute the stored procedure
            return DB.Execute("sproc_tblStock_Insert");
        }


        public void Update()
        {
            //create an db connection instance 
            clsDataConnection DB = new clsDataConnection();
            //set attributes
            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@StockName", mThisStock.StockName);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@StockLastAdded", mThisStock.StockLastAdded);
            DB.AddParameter("@StockAvailability", mThisStock.StockAvailability);

            //exacute 
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //set parameter for stored procedure
            DB.AddParameter("@StockID", mThisStock.StockID);
            //excute storeed procedure
            DB.Execute("sproc_tblStock_Delete");
        }


        public void ReportByStockName(string StockName)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockName", StockName);

            DB.Execute("sproc_tblStock_FilterByStockName");

            PopulateArray(DB);

        }

        private void PopulateArray(clsDataConnection DB)
        {
            //variable store index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount;
            //get count record 
            RecordCount = DB.Count;
            //clear private array list 
            mStockList = new List<clsStock>();

            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();
                //read field from record
                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                AnStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AnStock.StockPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["StockPrice"]); ;
                AnStock.StockLastAdded = Convert.ToDateTime (DB.DataTable.Rows[Index]["StockLastAdded"]);
                AnStock.StockAvailability = Convert.ToBoolean (DB.DataTable.Rows[Index]["StockAvailability"]);

                mStockList.Add(AnStock);
                Index++;
            }
        }
    }
}