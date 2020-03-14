using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Add_Invoice : System.Web.UI.Page
  {
    public Guid Voucher_ID = Guid.NewGuid();
    DataTable dtCustomers, dtItems;
    string storeid;
    protected void Page_Load(object sender, EventArgs e)
    {
      btnAdd_YS.Click += BtnAdd_YS_Click_YS;
      
      string userid = Session["User_Id"].ToString();
      if (Session["User_ID"] != null)
      {
        storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

        int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));
        if (isquickmode > 0)
        {
          lblitems.Visible = false;
          lblqty.Visible = false;
          ddItemName_YS.Visible = false;
          txtQty_YS.Visible = false;
        }

        dtCustomers = new DataTable();
        CommanFile.GetDataTable_YS(dtCustomers, $@"SELECT First_Name+' '+Last_Name as Customer_Name,Customer_ID
  FROM[CreditManagement].[dbo].[Customers]");
        ddCustomerName_YS.DataTextField = "Customer_Name";
        ddCustomerName_YS.DataValueField = "Customer_ID";
        ddCustomerName_YS.DataSource = dtCustomers.DefaultView;
        ddCustomerName_YS.DataBind();

        dtItems = new DataTable();
        CommanFile.GetDataTable_YS(dtItems, $@"select * from Store_Item where Store_ID='{storeid}'");
        ddItemName_YS.DataTextField = "Item_Name";
        ddItemName_YS.DataValueField = "Store_Item_ID";
        ddItemName_YS.DataSource = dtItems.DefaultView;
        ddItemName_YS.DataBind();
      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }

    protected void ddItemName_YS_SelectedIndexChanged(object sender, EventArgs e)
    {

    }



    #region Event
    //private void DdItemName_YS_SelectedIndexChanged_YS(object sender, EventArgs e)
    //{
    //  decimal rate = Convert.ToDecimal(CommanFile.ExcuteScalar_YS($@"select rate from Store_Item where Store_Item_ID={ddItemName_YS.SelectedValue}"));
    //  txtValue_YS.Text = rate.ToString();
    //}
    private void BtnAdd_YS_Click_YS(object sender, EventArgs e)
    {
      int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));
      if (isquickmode > 0)
      {
        if (string.IsNullOrEmpty(ddCustomerName_YS.Text) || string.IsNullOrEmpty(txtValue_YS.Text) || string.IsNullOrEmpty(txtQty_YS.Text) || string.IsNullOrEmpty(txtDescription.Text))
        {
          Response.Write("<script>alert('please Select All Fields');</script>");
          return;
        }
        string sql_de = $@"INSERT INTO [dbo].[Voucher]
           ([Voucher_ID]
           ,[Store_Customers_ID]
           ,[Store_ID]
           ,[Amount]
           ,[Voucher_Date]
           ,[Description]
           ,[Voucher_Type]
           ,[Amount_Effect])
     VALUES
           ('{Voucher_ID}'
,'{ddCustomerName_YS.SelectedValue}'
,'{storeid}'
,{txtValue_YS.Text}
,GETDATE()
,'{txtDescription.Text}'
,'S'
,+{txtValue_YS.Text})";
        CommanFile.ExcuteNonQuery_YS(sql_de);
      }
      else
      {

        Guid Voucher_Detail_ID = Guid.NewGuid();
        if (string.IsNullOrEmpty(ddCustomerName_YS.Text)
          || string.IsNullOrEmpty(txtValue_YS.Text)
          || string.IsNullOrEmpty(txtQty_YS.Text)
          || string.IsNullOrEmpty(txtDescription.Text)
          || string.IsNullOrEmpty(ddItemName_YS.Text))
        {
          Response.Write("<script>alert('please Select All Fields');</script>");
          return;
        }
        string Storecustomerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
where Customer_ID = '{ddCustomerName_YS.SelectedValue}'
and Store_ID = '{storeid}'"));
        decimal rate = Convert.ToDecimal(CommanFile.ExcuteScalar_YS($@"select rate from Store_Item where Store_Item_ID={ddItemName_YS.SelectedValue}"));
        string sql_de = $@"INSERT INTO [dbo].[Voucher_Detail]
           ([Voucher_Detail_ID]
           ,[Voucher_ID]
           ,[Store_Customers_ID]
           ,[QTY]
           ,[Rate]
           ,[Amount]
           ,[Store_Item_ID])
     VALUES
           ('{Voucher_Detail_ID}'
,'{Voucher_ID}'
,'{Storecustomerid}'
,'{txtQty_YS.Text}'
,'{rate}'
,{Convert.ToInt32(txtQty_YS) * Convert.ToInt32(rate)}
,{ddItemName_YS.SelectedValue})";
        CommanFile.ExcuteNonQuery_YS(sql_de);
      }
    }
    #endregion
  }
}
