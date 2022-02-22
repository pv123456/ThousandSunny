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
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //Dispay the supplier Name
        Response.Write(AnSupplier.SupplierId);
        Response.Write("<br>" + AnSupplier.SupplierName);
        Response.Write("<br>" + AnSupplier.SupplierEmail);
        Response.Write("<br>" + AnSupplier.SupplierAddress);
        Response.Write("<br>" + AnSupplier.StartDateSupplier);
        Response.Write("<br>" + AnSupplier.SupplierDiscountPrice);

    }
}