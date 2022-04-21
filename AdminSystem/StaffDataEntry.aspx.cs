using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //Vatiable to store the primary key with page levele scope
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {

        //Get the numbet of the staff to be processed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            //If this is not a new record
            if(StaffId != -1)
            {
                //Display the current data for the record
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        clsStaffCollection StaffBook = new clsStaffCollection();
        //Find the record to update
        txtStaffId.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtStaffFullName.Text = StaffBook.ThisStaff.StaffFullName;
        txtStaffEmail.Text = StaffBook.ThisStaff.StaffEmail;
        txtStaffPassword.Text = StaffBook.ThisStaff.StaffPassword;
        txtStartDate.Text = StaffBook.ThisStaff.StartDate.ToString();
        chkIsAdmin.Checked = StaffBook.ThisStaff.IsAdmin;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //Creates a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //Captures the data
       // AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        string StaffFullName = txtStaffFullName.Text;
        string StartDate = txtStartDate.Text;
        string StaffPassword = txtStaffPassword.Text;
        string StaffEmail = txtStaffEmail.Text;
        //Variable to store any error message
        string Error = "";
        //validate data
        Error = AStaff.Valid(StaffFullName, StartDate, StaffEmail, StaffPassword);
        if (Error == "")
        {
            AStaff.StaffId = StaffId;
            AStaff.StaffFullName = StaffFullName;
            AStaff.StartDate = Convert.ToDateTime(StartDate);
            AStaff.StaffEmail = StaffEmail;
            AStaff.StaffPassword = StaffPassword;
            AStaff.IsAdmin = chkIsAdmin.Checked;
            //Create a new instance of the Staff collection
            clsStaffCollection StaffList = new clsStaffCollection();


            //If this is a new record
            if (StaffId == -1)
            {
                //Set thisStaff property
                StaffList.ThisStaff = AStaff;
                //AddThe new record
                StaffList.add();
            }
            //Otherwise it must update
            else
            {
                //Find the record to update
                StaffList.ThisStaff.Find(StaffId);
                //Set the thisStaff property
                StaffList.ThisStaff = AStaff;
                //Update the record
                StaffList.Update();
            }
            //Redirect back to the list page
            Response.Redirect("StaffList.aspx");

        }
        else
        {
            //Display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = AStaff.Find(StaffId);
        if(Found == true)
        {
            txtStaffFullName.Text = AStaff.StaffFullName;
            txtStartDate.Text = AStaff.StartDate.ToString();
            chkIsAdmin.Checked = AStaff.IsAdmin;
            txtStaffPassword.Text = AStaff.StaffPassword;
            txtStaffEmail.Text = AStaff.StaffEmail;
        }
    }
}