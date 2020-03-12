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
          string totaluser = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
Select count(*) from [User] 
where Is_Storekeeper = 0
"));

        lblNumberofuser_YS.Text = totaluser;
      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }
  }
}
