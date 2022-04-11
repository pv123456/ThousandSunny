using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{


    Int32 StockID;

    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }


    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the supplier list class
        clsStockCollection StockList = new clsStockCollection();
        //find the recond to delete
        StockList.ThisStock.Find(StockID);
        //delete the record
        StockList.Delete();
        //redirect back to main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }

   
}