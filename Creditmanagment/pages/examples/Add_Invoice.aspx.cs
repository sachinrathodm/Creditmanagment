using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Add_Invoice : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string userid = Session["User_Id"].ToString();
      if (Session["User_ID"] != null)
      {
        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }
  }
}
