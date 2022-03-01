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
        Response.Write("Supplier ID : "+AnSupplier.SupplierId + "<br />");
        Response.Write("Supplier Name : " + AnSupplier.SupplierName + "<br />");
        Response.Write("Supplier Email : " + AnSupplier.SupplierEmail + "<br />");
        Response.Write("Supplier Address : " + AnSupplier.SupplierAddress + "<br />");
        Response.Write("Supplier Start Date : " + AnSupplier.StartDateSupplier + "<br />");
        Response.Write("Discount : " + AnSupplier.SupplierDiscountPrice + "<br />");

    }
}