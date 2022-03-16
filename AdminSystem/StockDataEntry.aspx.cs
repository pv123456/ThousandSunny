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

}