using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the stockID
        AnStock.StockID = Convert.ToInt32(txtStockID.Text);
        AnStock.StockPrice = Convert.ToDecimal(txtStockPrice.Text);
        AnStock.StockName = Convert.ToString(txtStockName.Text);
        AnStock.StockLastAdded = Convert.ToDateTime(txtStockLastAdded.Text);
        AnStock.StockDescription = Convert.ToString(txtStockDescription.Text);
       
        //store the stock in the session object
        Session["AnStock"] = AnStock;
        //navigate to the Stock page
        Response.Redirect("StockViewer.aspx");

       
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock AnStock = new clsStock();
        //variable to store the primary key
        Int32 StockID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockID = Convert.ToInt32( txtStockID.Text);
        //Find the record
        Found = AnStock.Find(StockID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockDescription.Text = AnStock.StockDescription;
            txtStockName.Text = AnStock.StockName;
        }

    }
}