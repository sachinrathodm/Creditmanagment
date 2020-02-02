using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class LoginPage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_YS_Click(object sender, EventArgs e)
    {
      if (rdStoreKeeper_YS.Checked)
      {
        string _sql = @"SELECT [User_ID]
      ,[Email_ID]
      ,[Password]
      ,[Is_Storekeeper]
  FROM[dbo].[User] where Email_Id = '" + txtEmail_YS.Text + "'And Password = '" + txtPassword_YS.Text + "'";

        CommanFile.SqlDataAdapter_YS(_sql);
        if (true)
        {

        }
        Response.Redirect("/indexhome.aspx");
      }
      if (rdCustomers_YS.Checked)
      {
        string _sql = @"SELECT [User_ID]
      ,[Email_ID]
      ,[Password]
      ,[Is_Storekeeper]
  FROM[dbo].[User] where Email_Id = '"+txtEmail_YS.Text+"'And Password = '"+txtPassword_YS.Text+"'";

        CommanFile.SqlDataAdapter_YS(_sql);
        if (true)
        {

        }
        Response.Redirect("/indexhome.aspx");
      }
    }
  }
}
