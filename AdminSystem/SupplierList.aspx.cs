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


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary Key
        Int32 SupplierID;

        //by chance a record has been selected

        if (lstSupplierList.SelectedIndex != -1)
        {
            //get primary key value of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store the data into a session
            Session["SupplierID"] = SupplierID;
            //redirect to edit
            Response.Redirect("SupplierDataEntry.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;

        //direct to data entry
        Response.Redirect("SupplierDataEntry.aspx");
    }
}