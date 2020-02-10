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
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["User_ID"] != null)
      {
        
      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }
  }
}
