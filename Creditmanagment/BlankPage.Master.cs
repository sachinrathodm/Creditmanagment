using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class BlankPage : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["User_ID"] != null)
      {
        login_YS.Visible = false;
      }
    }
  }
}
