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
      //Events
      txtEmail_YS.TextChanged += TxtEmail_YS_TextChanged_YS;
      txtPassword_YS.TextChanged += TxtPassword_YS_TextChanged_YS;
    }
    #region Events
    private void TxtEmail_YS_TextChanged_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtEmail_YS.Text))
      {
        lblIncorrect_ps_YS.Visible = true;
        lblIncorrect_ps_YS.Text = "Please Enter Details";
      }
     

    }

    protected void btnLogin_YS_Click(object sender, EventArgs e)
    {
      try
      {

       TxtEmail_YS_TextChanged_YS(null, null);
       TxtPassword_YS_TextChanged_YS(null, null);
        if (!string.IsNullOrEmpty(txtEmail_YS.Text))
        {
          int CountEmail = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
"));
          if (CountEmail > 0)
          {
            int CountPassword = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
AND 
[Password]='{txtPassword_YS.Text}'
"));
            if (CountPassword > 0)
              Response.Redirect("/indexhome.aspx");
            else
              lblIncorrect_ps_YS.Text = "Please Enter Valid Password";
          }
          else
          {
            lblIncorrect_ps_YS.Text = "Please Enter Valid Email Address";
          }
        }
      }

      catch (Exception ex)
      {


      }
    }

    private void TxtPassword_YS_TextChanged_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtPassword_YS.Text))
      {
        lblIncorrect_ps_YS.Visible = true;
        lblIncorrect_ps_YS.Text = "Please Enter Details";
      }
     
    }
    #endregion
  }
}
