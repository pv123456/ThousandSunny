using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        
     
        List<clsStock> mStockList = new List<clsStock>();
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
        public clsStock ThisStock { get; set; }

        public clsStockCollection()
        {
            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.StockAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["StockAvailability"]);
                AnStock.StockName = Convert.ToString(DB.DataTable.Rows[Index]["StockName"]);
                AnStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AnStock.StockLastAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["StockLastAdded"]);
                AnStock.StockPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["StockPrice"]);

                mStockList.Add(AnStock);

                Index++;
            }


            
            
        }

        
    }
}