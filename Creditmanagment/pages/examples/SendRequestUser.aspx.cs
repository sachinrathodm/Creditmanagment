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
          //Events

        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }

    }

    #region Events
    private void BtnSend_YS_Click_YS(object sender, EventArgs e)
    {

      string Customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Customer_ID from [dbo].[Customers]
Where 
[User_ID] = '{Userid}'
"));
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
    }
    #endregion
  }
}
