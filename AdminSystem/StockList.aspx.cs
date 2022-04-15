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
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        lstStockList.DataSource = Stock.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockName";
        lstStockList.DataBind();
    }




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store primary Key
        Int32 StockID;

        //by chance a record has been selected

        if (lstStockList.SelectedIndex != -1)
        {
            //get primary key value of the record to edit
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data into a session
            Session["StockID"] = StockID;
            //redirect to edit
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }

    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {

        Session["StockID"] = -1;

        Response.Redirect("StockDataEntry.aspx");

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;


        if (lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["StockID"] = StockID;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a name to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();

        Stock.ReportByStockName(txtFilterName.Text);
        lstStockList.DataSource = Stock.StockList;

        lstStockList.DataValueField = "StockID";

        lstStockList.DataTextField = "StockName";

        lstStockList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stock = new clsStockCollection();
        Stock.ReportByStockName("");

        txtFilterName.Text = "";
        lstStockList.DataSource = Stock.StockList;


        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockName";

        lstStockList.DataBind();
    }

}
