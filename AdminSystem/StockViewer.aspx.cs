using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creates an instance
        clsStock AnStock = new clsStock();
        //get the data from the session object
        AnStock = (clsStock)Session["AnStock"];
        //Dispay the supplier Name
        Response.Write("Stock ID : " + AnStock.StockID + "<br />");
        Response.Write("Stock Name : " + AnStock.StockName + "<br />");
        Response.Write("Stock Description : " + AnStock.StockDescription + "<br />");
        Response.Write("Stock Price : " + AnStock.StockPrice + "<br />");
        Response.Write("Stock LastAdded : " + AnStock.StockLastAdded + "<br/>");
        Response.Write("Stock Availability : " + AnStock.StockAvailability + "<br />");
    }
}