using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Invoice : System.Web.UI.Page
  {
    string userid, storeid;
    protected void Page_Load(object sender, EventArgs e)
    {
      lblNullmessega.Visible = true;
      lblNullmessega.InnerText = "No any recode";
      btnOk_YS.Click += BtnOk_YS_Click_YS;
      
      try
      {
        userid = Session["User_ID"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }
      storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
      if (!Page.IsPostBack)
      {
        if (Session["User_ID"] != null)
        {


          DataTable dtCustomerDetails = new DataTable();
          CommanFile.GetDataTable_YS(dtCustomerDetails, $@"
SELECT First_Name+' '+Last_Name as Customer_Name,Store_Customers.Customer_ID FROM Store_Customers  
INNER JOIN Customers ON Customers.Customer_ID = Store_Customers.Customer_ID 
where Store_Customers.Store_ID = '{storeid}'
 ");
          ddCusomerName_YS.DataTextField = "Customer_Name";
          ddCusomerName_YS.DataValueField = "Customer_ID";
          ddCusomerName_YS.DataSource = dtCustomerDetails.DefaultView;
          ddCusomerName_YS.DataBind();
          ddCusomerName_YS.Items.Insert(0, "--Please Select--");
        }
        else
          Response.Redirect("LoginPage.aspx");
      }
    }

   
    private void BtnOk_YS_Click_YS(object sender, EventArgs e)
    {
      //gdInvoic_YS.DataSource = new string[] { };
      if (!ddCusomerName_YS.SelectedItem.Text.Equals("--Please Select--"))
      {
        string storecustomerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select * From Store_Customers
where Customer_ID = '{ddCusomerName_YS.SelectedValue}' and Store_ID='{storeid}'"));

        Session["storecustomerid"] = storecustomerid;

        //        string store_Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
        //where Store_ID='{storeid}' and Customer_ID='{ddCusomerName_YS.SelectedValue}'"));

        DataTable dtCustomerinvoice = new DataTable();
        CommanFile.GetDataTable_YS(dtCustomerinvoice, $@"
select Voucher_ID,Description,Amount,Voucher_Date from Voucher Where Store_Customers_ID='{storecustomerid}' and Store_ID='{storeid}'
");
        if (dtCustomerinvoice != null && dtCustomerinvoice.Rows.Count > 0)
        {
          //gdInvoic_YS.RowDataBound += GdInvoic_YS_RowDataBound;
          gdInvoic_YS.Visible = true;
          lblNullmessega.Visible = false;
          gdInvoic_YS.DataSource =dtCustomerinvoice.DefaultView;
          gdInvoic_YS.DataBind();
        }
        else
        {
          gdInvoic_YS.Visible = false;
          lblNullmessega.Visible = true;
          lblNullmessega.InnerText = "No any recode";
        }
      }
    }

    //private void GdInvoic_YS_RowDataBound(object sender, GridViewRowEventArgs e)
    //{
    //  e.Row.Cells[1].Visible = false;
    //}

    protected void SuppliersProducts_RowCommand(object sender, GridViewCommandEventArgs e)
    {
      if (e.CommandName.CompareTo("Voucher_ID") == 0)
      {
        // The Increase Price or Decrease Price Button has been clicked
        // Determine the ID of the product whose price was adjusted
        Guid productID =
            (Guid)gdInvoic_YS.DataKeys[Convert.ToInt32(e.CommandArgument)].Value;

        //Button btn = (Button)sender;
        Session["voucherid"] = productID;

        Boolean isquickmode = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Voucher_QuickMode From [Store] 
where User_ID = '{userid}'
"));
        if (isquickmode)
        {
          Response.Redirect("Invoice_print_User_Store.aspx");
        }
        else
        {
          Response.Redirect("Invoice_DetailMode_print_User_Store_.aspx");
        }
      }
    }
  }

}

