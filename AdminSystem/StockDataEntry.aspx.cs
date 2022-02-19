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
        clsStock AnStock = new clsStock();
        AnStock.StockID = txtStockID.Text;
        Session["AnStock"] = AnStock;
        //navigate to the Stock page
        Response.Redirect("StockViewer.aspx");

    }

}