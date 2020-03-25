using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Change_Password : System.Web.UI.Page
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
      btnrequestpassword.Click += Btnrequestpassword_Click_YS;
    }

    private void Btnrequestpassword_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtEmail_YS.Text) || string.IsNullOrEmpty(txtpassword.Text))
      {
        lblCheckuserid.Text = "Please Fill The Details...";
        return;
      }
      int checkemail = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Count(*) From [dbo].[User] where Email_ID='{txtEmail_YS.Text}'"));
      if (checkemail > 0)
      {
        int checkpassword = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Count(*) From [dbo].[User] where Password='{CommanFile.encryptionpass(txtpassword.Text)}'"));
        if (checkpassword > 0)
        {
          Session["Recover_Paasword"] = userid;
          Response.Redirect("Recover_Password.aspx");
        }
      }
    }
  }
}
