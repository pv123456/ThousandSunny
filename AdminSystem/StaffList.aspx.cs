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
        lsbStaffList.DataSource = Staff.StaffList;
        //Set the name of hte primary key
        lsbStaffList.DataValueField = "StaffId";
        //Set the datafield to display
        lsbStaffList.DataTextField = "StaffFullName";
        //Bind the data to the list
        lsbStaffList.DataBind();

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Stores -1 into the session object to indicate that this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");

    }
}