using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        if(Error == "")
        {
            AStaff.StaffFullName = StaffFullName;
            AStaff.StartDate = Convert.ToDateTime(StartDate);
            AStaff.StaffEmail = StaffEmail;
            AStaff.StaffPassword = StaffPassword;
            AStaff.IsAdmin = chkIsAdmin.Checked;
        //Stores the staff in the session object
        Session["AStaff"] = AStaff;
        //Navigate to viweer page
        Response.Redirect("StaffViewer.aspx");

        }
        else
        {
            //Displays text error message
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