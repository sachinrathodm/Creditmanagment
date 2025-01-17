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
    DataTable dtCustomers, dtItems;
    string storeid;
    string userid;
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
      if (string.IsNullOrEmpty(Session["User_ID"].ToString()))
      {
        Response.Redirect("LoginPage.aspx");
      }
      else
      {
        btnAdd_YS.Click += BtnAdd_YS_Click_YS;
        btnAddNewItem_YS.Click += BtnAddNewItem_YS_Click_YS;


        storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
        if (!Page.IsPostBack)
        {
          Session["Voucher_ID"] = Guid.NewGuid();

          if (Session["User_ID"] != null)
          {
            int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));
            if (isquickmode > 0)
            {
              lblitems.Visible = false;
              lblqty.Visible = false;
              ddItemName_YS.Visible = false;
              txtQty_YS.Visible = false;
              btnAddNewItem_YS.Visible = false;
            }

            dtCustomers = new DataTable();
            CommanFile.GetDataTable_YS(dtCustomers, $@"SELECT  c.First_Name+ ' '+c.Last_Name as Customer_Name,*
FROM Store_Customers sc
INNER JOIN Customers c ON c.Customer_ID=sc.Customer_ID where sc.Store_ID='{storeid}' ");
            ddCustomerName_YS.DataTextField = "Customer_Name";
            ddCustomerName_YS.DataValueField = "Customer_ID";
            ddCustomerName_YS.DataSource = dtCustomers.DefaultView;
            ddCustomerName_YS.DataBind();
            ddCustomerName_YS.Items.Insert(0, "--Please Select--");

            dtItems = new DataTable();
            CommanFile.GetDataTable_YS(dtItems, $@"select * from Store_Item where Store_ID='{storeid}'");
            ddItemName_YS.DataTextField = "Item_Name";
            ddItemName_YS.DataValueField = "Store_Item_ID";
            ddItemName_YS.DataSource = dtItems.DefaultView;
            ddItemName_YS.DataBind();
            ddItemName_YS.Items.Insert(0, "--Please Select--");
            get_Customer_Invoice_YS();
          }
          else
            Response.Redirect("pages/examples/LoginPage.aspx");
        }
      }
    }

    private void BtnAddNewItem_YS_Click_YS(object sender, EventArgs e)
    {
      Response.Redirect("AddItems.aspx");
    }

    protected void ddItemName_YS_SelectedIndexChanged(object sender, EventArgs e)
    {
      // gdUserRequest.Visible = false;
      
        if (!ddCustomerName_YS.SelectedItem.Text.Equals("--Please Select--") && !ddItemName_YS.SelectedItem.Text.Equals("--Please Select--"))
        {
          string store_Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
where Store_ID='{storeid}' and Customer_ID='{ddCustomerName_YS.SelectedValue}'"));
          DataTable dtUserRequest = new DataTable();
          CommanFile.GetDataTable_YS(dtUserRequest, $@"select Description,Amount,Voucher_Date from Voucher
where Store_ID = '{storeid}' and Store_Customers_ID='{store_Customer_ID}'
");

          decimal rate = Convert.ToDecimal(CommanFile.ExcuteScalar_YS($@"select rate from Store_Item where Store_Item_ID='{ddItemName_YS.SelectedValue}'"));
          txtValue_YS.Text = rate.ToString();
          // gdUserRequest.Visible = true;
          gdUserRequest.DataSource = dtUserRequest.DefaultView;
          gdUserRequest.DataBind();
        }
    }

    #region Event
    private void BtnAdd_YS_Click_YS(object sender, EventArgs e)
    {
      if (!ddCustomerName_YS.SelectedItem.Text.Equals("--Please Select--"))
      {
        int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));
        if (isquickmode > 0)
        {
          if (string.IsNullOrEmpty(ddCustomerName_YS.Text) ||
            string.IsNullOrEmpty(txtValue_YS.Text) ||
            string.IsNullOrEmpty(txtDescription.Text))
          {
            Response.Write("<script>alert('please Select All Fields');</script>");
            return;
          }
          string store_Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers where Store_ID='{storeid}' and Customer_ID='{ddCustomerName_YS.SelectedValue}';"));
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
           ('{(Guid)Session["Voucher_ID"]}'
,'{store_Customer_ID}'
,'{storeid}'
,{txtValue_YS.Text}
,GETDATE()
,'{txtDescription.Text}'
,'S'
,+{txtValue_YS.Text})";
          CommanFile.ExcuteNonQuery_YS(sql_de);
          get_Customer_Invoice_YS();

          txtDescription.Text = null;
          txtValue_YS.Text = null;
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
          int count = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Count(*) from Voucher where Voucher_ID='{(Guid)Session["Voucher_ID"]}'"));
          if (count <= 0)
          {
            string store_Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers where Store_ID='{storeid}' and Customer_ID='{ddCustomerName_YS.SelectedValue}';"));

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
           ('{(Guid)Session["Voucher_ID"]}'
,'{store_Customer_ID}'
,'{storeid}'
,{0}
,GETDATE()
,'{txtDescription.Text}'
,'S'
,+{0})";
            CommanFile.ExcuteNonQuery_YS(sql_de);
          }

          string Storecustomerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
where Customer_ID = '{ddCustomerName_YS.SelectedValue}'
and Store_ID = '{storeid}'"));
          decimal rate = Convert.ToDecimal(CommanFile.ExcuteScalar_YS($@"select rate from Store_Item where Store_Item_ID='{ddItemName_YS.SelectedValue}'"));
          string sql = $@"INSERT INTO [dbo].[Voucher_Detail]
           ([Voucher_Detail_ID]
           ,[Voucher_ID]
           ,[Store_Customers_ID]
           ,[QTY]
           ,[Rate]
           ,[Amount]
           ,[Store_Item_ID]
           ,[Description_detai])
     VALUES
           ('{Voucher_Detail_ID}'
,'{(Guid)Session["Voucher_ID"]}'
,'{Storecustomerid}'
,{txtQty_YS.Text}
,'{rate}'
,{Convert.ToInt32(txtQty_YS.Text) * Convert.ToInt32(rate)}
,'{ddItemName_YS.SelectedValue}'
,'{txtDescription.Text}')";
          CommanFile.ExcuteNonQuery_YS(sql);
          int sumofvoucher = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select SUM(Amount) from Voucher_Detail where Voucher_ID='{(Guid)Session["Voucher_ID"]}'"));
          string description = Convert.ToString(CommanFile.ExcuteScalar_YS($@"DECLARE @dec VARCHAR(8000)   SELECT @dec = COALESCE(@dec + ', ', '') + Description_detai FROM Voucher_Detail where Voucher_ID='{(Guid)Session["Voucher_ID"]}' select @dec"));
          string updatequery = $@"UPDATE Voucher
SET Amount = {sumofvoucher}
, Amount_Effect={sumofvoucher}
, Description='{description}'
WHERE Voucher_ID ='{(Guid)Session["Voucher_ID"]}'";
          CommanFile.ExcuteNonQuery_YS(updatequery);
          get_Customer_Invoice_YS();
        }
        string store_CustomerID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers where Store_ID='{storeid}' and Customer_ID='{ddCustomerName_YS.SelectedValue}';"));

        string customerstoreid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
where Customer_ID = '{ddCustomerName_YS.SelectedValue}'
and Store_ID = '{storeid}'"));
        decimal Creditused = Convert.ToDecimal(CommanFile.ExcuteScalar_YS($@"select Sum(Amount_Effect) from Voucher Where Store_Customers_ID='{customerstoreid}'"));
        string updatecreditused = $@"
UPDATE Store_Customers
SET Credit_Used ={Creditused}
WHERE Store_Customers_ID = '{store_CustomerID}'";
        CommanFile.ExcuteNonQuery_YS(updatecreditused);

      }
    }
    #endregion

    private void get_Customer_Invoice_YS()
    {
      if (!ddCustomerName_YS.SelectedItem.Text.Equals("--Please Select--"))
      {
        string store_Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Store_Customers_ID from Store_Customers 
where Store_ID='{storeid}' and Customer_ID='{ddCustomerName_YS.SelectedValue}';"));
        DataTable dtUserRequest = new DataTable();
        CommanFile.GetDataTable_YS(dtUserRequest, $@"select Description,Amount,Voucher_Date from Voucher
where Store_ID = '{storeid}' and Store_Customers_ID='{store_Customer_ID}'
");
        gdUserRequest.DataSource = dtUserRequest.DefaultView;
        gdUserRequest.DataBind();
      }
    }
  }
}
