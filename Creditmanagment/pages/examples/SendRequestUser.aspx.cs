using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class SendRequestUser : System.Web.UI.Page
  {
    string Userid;
    Guid Store_Customer_Request_ID = Guid.NewGuid();

    protected void Page_Load(object sender, EventArgs e)
    {
      Userid = Session["User_ID"].ToString();
      //Events
      btnSend_YS.Click += BtnSend_YS_Click_YS;

      if (!Page.IsPostBack)
      {
        if (Session["User_ID"] != null)
        {
          DataTable dtStoreDetails = new DataTable();
          CommanFile.GetDataTable_YS(dtStoreDetails, "select * from [dbo].[Store]");
          ddStoreName_YS.DataTextField = "Store_Name";
          ddStoreName_YS.DataValueField = "Store_ID";
          ddStoreName_YS.DataSource = dtStoreDetails.DefaultView;
          ddStoreName_YS.DataBind();  
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
      get_Request_Details_YS();
    }

    #region Get Request Details Method
    protected void get_Request_Details_YS()
    {
      string Customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Customer_ID from [dbo].[Customers]
Where 
[User_Id] = '{Userid}'
"));
      DataTable dtUserRequest = new DataTable();
      CommanFile.GetDataTable_YS(dtUserRequest, $@"SELECT s.Store_Name,r.Store_Request_Date,r.CU_Request_Status
FROM Store_Customer_Request r
INNER JOIN Store s ON r.Store_ID=s.Store_ID where r.CU_Request_Status='p' and r.Customer_ID='{Customerid}'");

      gdUserRequest.DataSource = dtUserRequest.DefaultView;
      gdUserRequest.DataBind();
    }
    #endregion

    #region Events
    private void BtnSend_YS_Click_YS(object sender, EventArgs e)
     {
      string Customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Customer_ID from [dbo].[Customers]
Where 
[User_ID] = '{Userid}'
"));

//      string Storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
//select Store_ID from [dbo].[Store_Customer_Request]
//Where 
//[Customer_ID] = '{Customerid}'"));

//      string a = ddStoreName_YS.SelectedValue;

      string _sql = $@"
            INSERT INTO [dbo].[Store_Customer_Request]
           ([Store_Customer_Request_ID]
           ,[Customer_ID]
           ,[Store_ID]
           ,[CU_Request_Status]
           ,[Store_Request_Date])
     VALUES
           ('{Store_Customer_Request_ID}'
           ,'{Customerid}'
           ,'{ddStoreName_YS.SelectedValue}'
           ,'p'
           ,'{DateTime.Now}')
";
      CommanFile.ExcuteNonQuery_YS(_sql);
      get_Request_Details_YS();
    }
    #endregion
  }
}
