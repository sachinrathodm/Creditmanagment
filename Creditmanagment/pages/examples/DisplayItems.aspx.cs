using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class DisplayItems : System.Web.UI.Page
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
          string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
          DataTable dtstoredata_YS = new DataTable();
          dtstoredata_YS = (CommanFile.GetDataTable_YS(dtstoredata_YS, $@"
SELECT Item_Name,Rate
FROM Store_Item
Left outer JOIN Store ON Store.Store_ID=Store_Item.Store_ID 
where store.Store_ID = '{storeid}'
"));

          gdDisplayUsers.DataSource = dtstoredata_YS.DefaultView;
          gdDisplayUsers.DataBind();
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
    }
  }
}
