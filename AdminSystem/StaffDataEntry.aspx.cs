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
        AStaff.StaffId = Convert.ToInt32(txtStaffId.Text);
        AStaff.StaffFullName = txtStaffFullName.Text;
        AStaff.StartDate = Convert.ToDateTime(txtStartDate.Text);
        AStaff.IsAdmin = chkIsAdmin.Checked;
        AStaff.StaffPassword = txtStaffPassword.Text;
        AStaff.StaffEmail = txtStaffEmail.Text;
        //Stores the staff in the session object
        Session["AStaff"] = AStaff;
        //Navigate to viweer page
        Response.Redirect("StaffViewer.aspx");
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