using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
      try
      {
        int Count = Convert.ToInt32( CommanFile.ExcuteScalar_YS($@"
select count(*) from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
AND 
[Password]='{txtPassword_YS.Text}'
"));
        if (Count>0)
        {
          Response.Redirect("/indexhome.aspx");
        }
        else
        {
          Response.Redirect("/pages/examples/LoginPage.aspx");
        }
        
      }
      catch (Exception ex)
      {

        
      }
    }
  }
}
