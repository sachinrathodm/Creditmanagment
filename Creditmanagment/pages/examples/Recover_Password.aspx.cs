using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Recover_Password : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        string Recover_Password = Session["Recover_Paasword"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }
      btnsubmit_Click_YS.Click += Btnsubmit_Click_YS_Click_YS;
    }

    private void Btnsubmit_Click_YS_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtPassword_YS.Text) && string.IsNullOrEmpty(txtRetypepassword_YS.Text))
      {
        lblcheck_YS.Text = "Please Fill The Password..";
      }
      if (!txtPassword_YS.Text.Equals(txtRetypepassword_YS.Text))
      {
        lblcheck_YS.Text = "Password Are Not Matched...";
      }
      else
      {
        CommanFile.ExcuteNonQuery_YS($@"UPDATE [dbo].[User] SET [Password] ='{CommanFile.encryptionpass(txtPassword_YS.Text)}' WHERE User_ID='{Session["Recover_Paasword"]}';");
        lblcheck_YS.Text = "";
        Response.Write("<script>alert('Password is successfully change');</script>");
        Response.Redirect("LoginPage.aspx");
      }
    }
  }
}
