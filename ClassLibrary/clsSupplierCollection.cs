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
            //var for index
            Int32 index = 0;
            //var to stor record count
            Int32 RecordCount = 0;
            //instance to create data connection
            clsDataConnection DB = new clsDataConnection();
            //carry out stored procedure 
            DB.Execute("sproc_tblSupplier_SelectAll");
            //get the count record
            RecordCount = DB.Count;
            //while in process 
            while (index < RecordCount) 
            {
                //create supplier instance 
                clsSupplier AnSupplier = new clsSupplier();
                //read field current record
                AnSupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[index]["SupplierID"]);
                AnSupplier.SupplierName = Convert.ToString(DB.DataTable.Rows[index]["SupplierName"]);
                AnSupplier.SupplierEmail = Convert.ToString(DB.DataTable.Rows[index]["SupplierEmail"]);
                AnSupplier.SupplierAddress = Convert.ToString(DB.DataTable.Rows[index]["SupplierAddress"]);
                AnSupplier.StartDateSupplier = Convert.ToDateTime(DB.DataTable.Rows[index]["StartDateSupplier"]);
                AnSupplier.SupplierDiscountPrice = Convert.ToBoolean(DB.DataTable.Rows[index]["SupplierDiscountPrice"]);
                //add data to list 
                mSupplierList.Add(AnSupplier);
                //increment to next 
                index++;
            }


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
    }
}