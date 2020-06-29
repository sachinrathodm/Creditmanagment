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
      if (Session["User_ID"] != null)
      {
        string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Customer_ID]
  FROM [CreditManagement].[dbo].[Customers]
  where User_ID = '{userid}'
"));
          DataTable dtstoredata_YS = new DataTable();
          dtstoredata_YS = (CommanFile.GetDataTable_YS(dtstoredata_YS, $@"SELECT Store_Name,First_Name+ ' ' +Last_Name as StoreKeeperName,Mobile_No,Address  
FROM Store_Customer_Request  Left outer JOIN Store 
ON Store.Store_ID =Store_Customer_Request.Store_ID Left outer Join [User]
ON Store.User_ID = [User].User_ID 
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

