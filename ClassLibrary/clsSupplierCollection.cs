using System.Collections.Generic;
using System;
namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        
      

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();
        public List<clsSupplier> SupplierList
        {
            
            get 
            {
                //return the data
                return mSupplierList;
            }
            
            set 
            {
                // set the data
                mSupplierList = value;
            } 
        }
        public int Count 
        {
            get 
            {
                return mSupplierList.Count;
            
            } 
            set 
            { 
            
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                //return the data
                return mThisSupplier;
            }

            set
            {
                // set the data
                mThisSupplier = value;
            }
        }

        public clsSupplierCollection() 
        {
            clsDataConnection DB = new clsDataConnection();
            //exacute stored procedure 
            DB.Execute("sproc_tblSupplier_SelectAll");
            //populate the array 
            PopulateArray(DB);

        }

        public int Add()
        {
            //create an db connection instance 
            clsDataConnection DB = new clsDataConnection();
            //set attributes
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@StartDateSupplier", mThisSupplier.StartDateSupplier);
            DB.AddParameter("@SupplierDiscountPrice", mThisSupplier.SupplierDiscountPrice);
            //exacute the stored procedure
            return DB.Execute("sproc_tblSupplier_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            //set attributes

            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.SupplierName);
            DB.AddParameter("@SupplierEmail", mThisSupplier.SupplierEmail);
            DB.AddParameter("@SupplierAddress", mThisSupplier.SupplierAddress);
            DB.AddParameter("@StartDateSupplier", mThisSupplier.StartDateSupplier);
            DB.AddParameter("@SupplierDiscountPrice", mThisSupplier.SupplierDiscountPrice);

            //execute
            DB.Execute("sproc_tblSupplier_Update");
        }

        public void Delete()
        {
            //instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //set parameter for stored procedure
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            //excute storeed procedure
            DB.Execute("sproc_tblSupplier_Delete");
        }

        

        public void ReportByAddress(string SupplierAddress)
        {
            //filter reciird by full address or partial address
            //connect database
            clsDataConnection DB = new clsDataConnection();
            //send address parameter to database
            DB.AddParameter("@SupplierAddress", SupplierAddress);
            //Exacute stored procedure
            DB.Execute("sproc_tblSupplier_FilterByAddress");
            //populate the array list data table
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB) 
        {
            //variable store index
            Int32 Index = 0;
            //variable to store record count
            Int32 RecordCount;
            //get count record 
            RecordCount = DB.Count;
            //clear private array list 
            mSupplierList = new List<clsSupplier>();

            while (Index < RecordCount) 
            {
                clsSupplier AnSupplier = new clsSupplier();
                //read field from record
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[Index]["SupplierEmail"]);
                AnSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                AnSupplier.StartDateSupplier = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDateSupplier"]);
                AnSupplier.SupplierDiscountPrice = Convert.ToBoolean(DB.DataTable.Rows[Index]["SupplierDiscountPrice"]);
                mSupplierList.Add(AnSupplier);

                Index++;
            }
        }
    }
}