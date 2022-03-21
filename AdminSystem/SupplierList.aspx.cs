using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) 
        {
            DisplaySupplier();
        }
    }

    void DisplaySupplier()
    {
        //create an instance
        clsSupplierCollection Supplier = new clsSupplierCollection();
        //set data source to list of supplier in collection
        lstSupplierList.DataSource = Supplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierAddress";
        lstSupplierList.DataBind();

    }
}