using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Edit_Profile_User : System.Web.UI.Page
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

      if (string.IsNullOrEmpty(Session["User_ID"].ToString()))
      {
        Response.Redirect("LoginPage.aspx");
      }
      else
      {
        DataTable dtcustomerinfo = (DataTable)Session["dtcustomerinfo"];

        txtFirstname_YS.Text = dtcustomerinfo.Rows[0][1].ToString();
        txtLastname_YS.Text = dtcustomerinfo.Rows[0][2].ToString();
        txtMobileno_YS.Text = dtcustomerinfo.Rows[0][3].ToString();
        txtEmail_YS.Text = dtcustomerinfo.Rows[0][4].ToString();
        txtBirthDate_YS.Text = dtcustomerinfo.Rows[0][5].ToString();
        txtAddress_YS.Text = dtcustomerinfo.Rows[0][6].ToString();
        txtAdharcardno_YS.Text = dtcustomerinfo.Rows[0][7].ToString();
      }
    }
  }
}
