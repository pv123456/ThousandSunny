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
        //If this if the first time the page is displayed
        if(IsPostBack == false)
        {
            //Update the list box
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //Set the data tolist of staff in collection
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of hte primary key
        lstStaffList.DataValueField = "StaffId";
        //Set the datafield to display
        lstStaffList.DataTextField = "StaffFullName";
        //Bind the data to the list
        lstStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Stores -1 into the session object to indicate that this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primart key value of the record to be edited
        Int32 StaffId;
        //If a record has been selected from the list
        if(lstStaffList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //Store the data in the session object
            Session["StaffId"] = StaffId;
            //Redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key of the record to be edited
        Int32 StaffId;
        //If a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //Get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            //Store the data in the session object
            Session["StaffId"] = StaffId;
            //Redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }

    }
}