using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages
{
  public partial class AcceptRequest : System.Web.UI.Page
  {
    string Userid;
    string Storeid;
    DataTable dtStoreDetails = new DataTable();
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        Userid = Session["User_ID"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }
      //Event
      btnAccept_YS.Click += BtnAccept_YS_Click_YS;
      btnReject_YS.Click += BtnReject_YS_Click_YS;

      if (!Page.IsPostBack)
      {
        if (Session["User_ID"] != null)
        {
          Storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Store_ID from [dbo].[Store]
Where 
[User_ID] = '{Userid}'
"));

          CommanFile.GetDataTable_YS(dtStoreDetails, $@"SELECT Store_ID,r.Customer_ID,Store_Customer_Request_ID, First_Name+' '+Last_Name as DisplayName 
FROM dbo.Store_Customer_Request r 
INNER JOIN Customers c ON r.Customer_ID=c.Customer_ID where r.Store_ID='{Storeid}' And CU_Request_Status='p'");
          ddCustomerRequest.DataTextField = "DisplayName";
          ddCustomerRequest.DataValueField = "Store_Customer_Request_ID";
          ddCustomerRequest.DataSource = dtStoreDetails.DefaultView;
          ddCustomerRequest.DataBind();
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
    }

    #region Events
    private void BtnReject_YS_Click_YS(object sender, EventArgs e)
    {
      Storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Store_ID from [dbo].[Store] where User_ID='{Userid}'"));
      string _sql = $@"UPDATE [dbo].[Store_Customer_Request]
       SET 
       [CU_Request_Status] = 'R'
       WHERE Store_Customer_Request_ID='{ddCustomerRequest.SelectedValue.ToString()}'";

      CommanFile.ExcuteNonQuery_YS(_sql);

      #region ComboboxReset
      CommanFile.GetDataTable_YS(dtStoreDetails, $@"SELECT Store_ID,r.Customer_ID,Store_Customer_Request_ID, First_Name+' '+Last_Name as DisplayName 
FROM dbo.Store_Customer_Request r 
INNER JOIN Customers c ON r.Customer_ID=c.Customer_ID where r.Store_ID='{Storeid}' And CU_Request_Status='p'");
      ddCustomerRequest.DataTextField = "DisplayName";
      ddCustomerRequest.DataValueField = "Store_Customer_Request_ID";
      ddCustomerRequest.DataSource = dtStoreDetails.DefaultView;
      ddCustomerRequest.DataBind();
      #endregion
    }

    private void BtnAccept_YS_Click_YS(object sender, EventArgs e)
    {
      Storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Store_ID from [dbo].[Store] where User_ID='{Userid}'"));
      string _sql = $@"UPDATE [dbo].[Store_Customer_Request]
          SET 
          [CU_Request_Status] = 'A'
          WHERE Store_Customer_Request_ID='{ddCustomerRequest.SelectedValue.ToString()}'";
      CommanFile.ExcuteNonQuery_YS(_sql);
      Guid Store_Customers_ID = Guid.NewGuid();
      string Customer_ID = Convert.ToString(CommanFile.ExcuteScalar_YS($@"select Customer_ID from Store_Customer_Request where Store_Customer_Request_ID='{ddCustomerRequest.SelectedValue.ToString()}'"));


      _sql = $@"INSERT INTO [dbo].[Store_Customers]
           ([Store_Customers_ID]
           ,[Customer_ID]
           ,[Store_ID]
           ,[Credit]
           ,[Date_Approval]
           ,[Credit_Used]
           ,[Status])
     VALUES
           ('{Store_Customers_ID}'
,'{Customer_ID}'
,'{Storeid}'
,500
,GETDATE()
,0
,'N')";
      CommanFile.ExcuteNonQuery_YS(_sql);

      #region ComboboxReset
      CommanFile.GetDataTable_YS(dtStoreDetails, $@"SELECT Store_ID,r.Customer_ID,Store_Customer_Request_ID, First_Name+' '+Last_Name as DisplayName 
FROM dbo.Store_Customer_Request r 
INNER JOIN Customers c ON r.Customer_ID=c.Customer_ID where r.Store_ID='{Storeid}' And CU_Request_Status='p'");
      ddCustomerRequest.DataTextField = "DisplayName";
      ddCustomerRequest.DataValueField = "Store_Customer_Request_ID";
      ddCustomerRequest.DataSource = dtStoreDetails.DefaultView;
      ddCustomerRequest.DataBind();
      #endregion
    }

    #endregion
  }
}
