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
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff)Session["AStaff"];
        Response.Write(AStaff.StaffId);
        Response.Write(AStaff.StaffFullName);
        Response.Write(AStaff.StartDate);
        Response.Write(AStaff.IsAdmin);
        Response.Write(AStaff.StaffEmail);
        Response.Write(AStaff.StaffPassword);
    }
}