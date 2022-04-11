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

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable for primary key
        Int32 SupplierID;

        //if record is selected from list
        if (lstSupplierList.SelectedIndex != -1)
        {
            //get primary key value 
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            //store data in session
            Session["SupplierID"] = SupplierID;
            //redirect to delete page
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else 
        {
            lblError.Text = "Please select a record to delete";
        }
    }



    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instace of supplier collection
        clsSupplierCollection Supplier = new clsSupplierCollection();

        Supplier.ReportByAddress(txtFilterAddress.Text);
        lstSupplierList.DataSource = Supplier.SupplierList;

        //set primarky key 
        lstSupplierList.DataValueField = "SupplierID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierAddress";
        //bind data to list of data
        lstSupplierList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an list of supplier collection 
        clsSupplierCollection Supplier = new clsSupplierCollection();
        Supplier.ReportByAddress("");
        //clear an existing data written 
        txtFilterAddress.Text = "";
        lstSupplierList.DataSource = Supplier.SupplierList;


        //set primarky key 
        lstSupplierList.DataValueField = "SupplierID";
        //set the name of the field to display
        lstSupplierList.DataTextField = "SupplierAddress";
        //bind data to list of data
        lstSupplierList.DataBind();

    }
}