using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Invoice_User : System.Web.UI.Page
  {
    string userid, storeid;
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        userid = Session["User_ID"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }
      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
        string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Customer_ID from [dbo].[Customers]
Where 
[User_ID] = '{userid}'
"));
        if (!Page.IsPostBack)
        {
          if (Session["User_ID"] != null)
          {
            DataTable dtStoreDetails = new DataTable();
            CommanFile.GetDataTable_YS(dtStoreDetails, $@"SELECT *
FROM Store_Customers
INNER JOIN Store ON Store.Store_ID = Store_Customers.Store_ID where Store_Customers.Customer_ID = '{customerid}'");
            Session["storecustomerid"] = dtStoreDetails.Rows[0][0].ToString();
            ddStoreName_YS.DataTextField = "Store_Name";
            ddStoreName_YS.DataValueField = "Store_ID";
            ddStoreName_YS.DataSource = dtStoreDetails.DefaultView;
            ddStoreName_YS.DataBind();
            ddStoreName_YS.Items.Insert(0, "--Please Select--");
          }
          else
            Response.Redirect("LoginPage.aspx");


        }
        btnOk_YS.Click += BtnOk_YS_Click_YS;
      }
    }

    private void BtnOk_YS_Click_YS(object sender, EventArgs e)
    {
      if (!ddStoreName_YS.SelectedItem.Text.Equals("--Please Select--"))
      {

        DataTable dtUserRequest = new DataTable();
        CommanFile.GetDataTable_YS(dtUserRequest, $@"select Voucher_ID,Description,Amount,Voucher_Date from Voucher
where Store_ID = '{ddStoreName_YS.SelectedValue}'
");
        gdInvoic_YS.DataSource = dtUserRequest.DefaultView;
        gdInvoic_YS.DataBind();
      }
    }
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

        string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
   select Customer_ID From Customers c  
   inner join [User] u on c.User_ID = u.User_ID
   where u.User_ID='{userid}'
"));

        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Store_ID From Customers c  
   inner join Store_Customers sc on c.Customer_ID = sc.Customer_ID
   where c.Customer_ID='{customerid}'
"));
        Boolean isquickmode = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Voucher_QuickMode From [Store] 
where Store_ID = '{storeid}'
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
