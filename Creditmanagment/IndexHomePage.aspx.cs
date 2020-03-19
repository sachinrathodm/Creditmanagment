using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment
{
  public partial class IndexHomePage : System.Web.UI.Page
  {
    string userid;
    protected void Page_Load(object sender, EventArgs e)
    {
      
      try
      {
        userid = Session["User_Id"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("pages/examples/LoginPage.aspx");
      }
      if (Session["User_ID"] != null)
        {
          string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

          string totalcoustomers = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
Select count(*) from [Store_Customers] 
where Store_ID = '{storeid}'
"));

          lblNumberofuser_YS.Text = totalcoustomers;

        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      

    }
  }
}
