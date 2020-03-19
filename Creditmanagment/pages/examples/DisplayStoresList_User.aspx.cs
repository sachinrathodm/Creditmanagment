using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class DisplayStoresList_User : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(Session["User_ID"].ToString()))
      {
        Response.Redirect("LoginPage.aspx");
      }
      else
      {


        string userid = Session["User_Id"].ToString();
        if (Session["User_ID"] != null)
        {
          string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Customer_ID]
  FROM [CreditManagement].[dbo].[Customers]
  where User_ID = '{userid}'
"));
          DataTable dtstoredata_YS = new DataTable();
          dtstoredata_YS = (CommanFile.GetDataTable_YS(dtstoredata_YS, $@"SELECT Store_Name,First_Name+Last_Name as StoreKeeperName,Helpline_No,Address
FROM Store_Customer_Request
Left outer JOIN Store ON Store.Store_ID =Store_Customer_Request.Store_ID 
 where Customer_ID = '{customerid}' and CU_Request_Status = 'A'
"));

          gdDisplayStores.DataSource = dtstoredata_YS.DefaultView;
          gdDisplayStores.DataBind();
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
    }
  }
}
