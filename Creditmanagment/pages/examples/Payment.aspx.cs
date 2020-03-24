using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Payment : System.Web.UI.Page
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
      btnPayment_YS.Click += BtnPayment_YS_Click_YS;

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
          ddCustomerName_YS.DataTextField = "Customer_Name";
          ddCustomerName_YS.DataValueField = "Customer_ID";
          ddCustomerName_YS.DataSource = dtCustomerDetails.DefaultView;
          ddCustomerName_YS.DataBind();
        }
        else
          Response.Redirect("LoginPage.aspx");
      }
    }

    private void BtnPayment_YS_Click_YS(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(ddCustomerName_YS.SelectedValue)&&!string.IsNullOrEmpty( txtPayrs_YS.Text))
      {
        string storecustomerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select * From Store_Customers
where Customer_ID = '{ddCustomerName_YS.SelectedValue}' and Store_ID='{storeid}'"));
        Guid Voucherid = Guid.NewGuid();
        CommanFile.ExcuteScalar_YS($@"INSERT INTO [dbo].[Voucher]
           ([Voucher_ID]
           ,[Store_Customers_ID]
           ,[Store_ID]
           ,[Amount]
           ,[Voucher_Date]
           ,[Description]
           ,[Voucher_Type]
           ,[Amount_Effect])
     VALUES
           ('{Voucherid}'
,'{storecustomerid}'
,'{storeid}'
,'{txtPayrs_YS.Text}'
,GETDATE()
,'{txtDescription.Text}'
,'R'
,'-{txtPayrs_YS.Text}')");
         string currentcredit=Convert.ToString(CommanFile.ExcuteScalar_YS($@"select SUM(Amount_Effect) from Voucher Where [Store_Customers_ID]='{storecustomerid}' and store_id='{storeid}'"));
        CommanFile.ExcuteNonQuery_YS($@"
UPDATE [dbo].[Store_Customers]
   SET
      [Credit_Used] = '{currentcredit}'
 WHERE Store_Customers_ID = '{storecustomerid}'");
        txtPayrs_YS.Text = "";
        ddCustomerName_YS_SelectedIndexChanged(null, null);
      }
     
    }

    protected void ddCustomerName_YS_SelectedIndexChanged(object sender, EventArgs e)
    {
      lblCredit.Text = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Credit_Used from Store_Customers 
where Store_ID='{storeid}' 
and Customer_ID='{ddCustomerName_YS.SelectedValue}'"));
    }

  }
}
