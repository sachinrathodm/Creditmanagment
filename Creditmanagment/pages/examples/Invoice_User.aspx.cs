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
    string userid;
    protected void Page_Load(object sender, EventArgs e)
    {
      btnOk_YS.Click += BtnOk_YS_Click_YS;
      
      try
      {
        userid = Session["User_ID"].ToString();
      }
      catch (Exception ex)
      {
          Response.Redirect("SessionErrorMessage.aspx");
      }
      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
//        storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
//SELECT[Store_ID]
//  FROM [CreditManagement].[dbo].[Store]
//  where User_ID = '{userid}'
//"));
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
            ddStoreName_YS.DataTextField = "Store_Name";
            ddStoreName_YS.DataValueField = "Store_ID";
            ddStoreName_YS.DataSource = dtStoreDetails.DefaultView;
            ddStoreName_YS.DataBind();
          }
          else
            Response.Redirect("LoginPage.aspx");
        }
      }
    }

    protected void btnInvoice_YS_Click(object sender, EventArgs e)
    {
      Button btn = (Button)sender;
      Session["voucherid"] = btn.CommandArgument;
      Response.Redirect("Invoice_print_User_Store.aspx");
    }

    private void BtnOk_YS_Click_YS(object sender, EventArgs e)
    {

      if (string.IsNullOrEmpty(ddStoreName_YS.SelectedValue))
      {

      }
      else
      {
        DataTable dtUserRequest = new DataTable();
        CommanFile.GetDataTable_YS(dtUserRequest, $@"select Voucher_ID,Description,Amount,Voucher_Date from Voucher
where Store_ID = '{ddStoreName_YS.SelectedValue}'
");
        gdInvoic_YS.DataSource = dtUserRequest.DefaultView;
        gdInvoic_YS.DataBind();
      }
    }
  }
}
