using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) 
        {
            if (SupplierID != -1) 
            {
                DisplaySupplier();
            }
        }
    }

    private void DisplaySupplier()
    {
        //create an instance of supplier list
        clsSupplierCollection Supplier = new clsSupplierCollection();
        //find the recond to update
        Supplier.ThisSupplier.Find(SupplierID);
        //display data for this record
        txtSupplierID.Text = Supplier.ThisSupplier.SupplierID.ToString();
        txtSupplierName.Text = Supplier.ThisSupplier.SupplierName;
        txtSupplierEmail.Text = Supplier.ThisSupplier.SupplierEmail;
        txtSupplierAddress.Text = Supplier.ThisSupplier.SupplierAddress;
        txtStartDateSupplier.Text = Supplier.ThisSupplier.StartDateSupplier.ToString();
        chkSupplierDiscountPrice.Checked = Supplier.ThisSupplier.SupplierDiscountPrice;

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create an instance 
        clsSupplier AnSupplier = new clsSupplier();  
        //capture a supplier
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string StartDateSupplier = txtStartDateSupplier.Text;
         string Error = "";
        Error = AnSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, StartDateSupplier);
        if (Error == "")
        {
            //capture a supplier
            AnSupplier.SupplierID = SupplierID;
            AnSupplier.SupplierName = SupplierName;
            AnSupplier.SupplierEmail = SupplierEmail;
            AnSupplier.SupplierAddress = SupplierAddress;
            AnSupplier.StartDateSupplier = Convert.ToDateTime(StartDateSupplier);
            AnSupplier.SupplierDiscountPrice = chkSupplierDiscountPrice.Checked;

            //create an instacle of supplier collection 
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                //set attribute
                SupplierList.ThisSupplier = AnSupplier;

                //Add the data
                SupplierList.Add();
            }
            else 
            {
                    //find record
                SupplierList.ThisSupplier.Find(SupplierID);
                //set this supplier 
                SupplierList.ThisSupplier = AnSupplier;
                //Update record
                SupplierList.Add();
            }
            //Goes to the viewer page
            Response.Redirect("SupplierList.aspx");

        }
        else 
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier AnSupplier = new clsSupplier();
        
        Int32 SupplierID;
        Boolean Found = false;

        SupplierID = Convert.ToInt32(txtSupplierID.Text);
        Found = AnSupplier.Find(SupplierID);

        if (Found == true) 
        {
            txtSupplierName.Text = AnSupplier.SupplierName;
            txtSupplierEmail.Text = AnSupplier.SupplierEmail;
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtStartDateSupplier.Text = AnSupplier.StartDateSupplier.ToString();
            chkSupplierDiscountPrice.Checked = AnSupplier.SupplierDiscountPrice;

        }
    }
}