using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StockID;
    

    protected void Page_Load(object sender, EventArgs e)
    {
       
        if (IsPostBack == false)
        {
            if (StockID != -1)
            {
                DisplayStock();
            }
        }
    }

    private void DisplayStock()
    {
        clsStockCollection Stock = new clsStockCollection();

        Stock.ThisStock.Find(StockID);

        txtStockID.Text = Stock.ThisStock.StockID.ToString();
        txtStockName.Text = Stock.ThisStock.StockName;
        txtStockDescription.Text = Stock.ThisStock.StockDescription;
        txtStockPrice.Text = Stock.ThisStock.StockPrice.ToString();
        txtStockLastAdded.Text = Stock.ThisStock.StockLastAdded.ToString();
        chkStockAvaliability.Checked = Stock.ThisStock.StockAvailability;
    }




    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();

        //capture the stock 
        string StockName = txtStockName.Text;
        string StockDescription = txtStockDescription.Text;
        string StockLastAdded = txtStockLastAdded.Text;
        string StockPrice = txtStockPrice.Text;
        string Error ="";
        Error = AnStock.Valid(StockName, StockDescription, StockLastAdded);
        if (Error == " ")
        {


            //capture the stock
            AnStock.StockID = StockID;
            AnStock.StockName = StockName;
            AnStock.StockDescription = StockDescription;
            AnStock.StockPrice = Convert.ToDecimal(StockPrice);
            AnStock.StockLastAdded = Convert.ToDateTime( StockLastAdded);
            AnStock.StockAvailability = chkStockAvaliability.Checked;

            //
            clsStockCollection StockList = new clsStockCollection();
            if (StockID == -1)
            {
                //
                StockList.ThisStock = AnStock;

                //
                StockList.Add();
            }
            else
            {

                //
                StockList.ThisStock.Find(StockID);
                //
                StockList.ThisStock = AnStock;

                //
                StockList.Add();

            }
            //
            Response.Redirect("StockList.aspx");

        }
        else
        {
            IblError.Text = Error;
        }

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsStock AnStock = new clsStock();

        Int32 StockID;

        Boolean Found = false;

        StockID = Convert.ToInt32( txtStockID.Text);

        Found = AnStock.Find(StockID);

        if (Found == true)
        {
            txtStockName.Text = AnStock.StockName;
            txtStockDescription.Text = AnStock.StockDescription;
            txtStockPrice.Text = AnStock.StockPrice.ToString();
            txtStockLastAdded.Text = AnStock.StockLastAdded.ToString();
            chkStockAvaliability.Checked = AnStock.StockAvailability;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}