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
      btnsubmit.Click += Btnsubmit_Click_YS;
    }

    private void Btnsubmit_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtpassword.Text) && string.IsNullOrEmpty(txtconfirmpassword.Text))
      {
        lblcheck_YS.Text = "Please Fill The Password..";
      }
      if (!txtpassword.Text.Equals(txtconfirmpassword.Text))
      {
        lblcheck_YS.Text = "Password Are Not Matched...";
      }
      else
      {
        CommanFile.ExcuteNonQuery_YS($@"UPDATE [dbo].[User] SET [Password] ='{CommanFile.encryptionpass(txtpassword.Text)}' WHERE User_ID='{Session["Recover_Paasword"]}';");
        lblcheck_YS.Text = "";
      }
    }
  }
}
