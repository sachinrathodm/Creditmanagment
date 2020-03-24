using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class ForgotPasswordPage : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {

      btnrequestpassword.Click += Btnrequestpassword_Click_YS;
    }

    private void Btnrequestpassword_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtEmail_YS.Text) && string.IsNullOrEmpty(txtUserid_YS.Text))
      {
        lblCheckuserid.Text = "Please Enter Email Or User id..";
      }
      int checkemail = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Count(*) from [dbo].[User] where Email_id='{txtEmail_YS.Text}'"));
      if (checkemail > 0)
      {
        Guid g;
        bool a = Guid.TryParse(txtUserid_YS.Text, out g);
        if (!a)
        {
          lblCheckuserid.Text = "Please Enter Valid Userid";
          return;
        }

        int chkuserid = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Count(*) from [dbo].[User] where User_id='{g}'"));
        if (chkuserid > 0)
        {
          Session["Recover_Paasword"] = $@"{txtUserid_YS.Text}";
          Response.Redirect("Recover_Password.aspx");
        }
      }
      else
      {
        lblCheckuserid.Text = "Please Enter Valid Email Address";
      }
    }
  }
}
