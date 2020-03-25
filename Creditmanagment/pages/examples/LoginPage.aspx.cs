using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class LoginPage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      
        if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
        {
          txtEmail_YS.Text = Request.Cookies["UserName"].Value;
          txtPassword_YS.Attributes["value"] = Request.Cookies["Password"].Value;
        }
      

      //Events
      txtEmail_YS.TextChanged += TxtEmail_YS_TextChanged_YS;
      txtPassword_YS.TextChanged += TxtPassword_YS_TextChanged_YS;
      Form.DefaultButton = btnLogin_YS.UniqueID;
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
            string passwordenc = CommanFile.encryptionpass(txtPassword_YS.Text);
            int CountPassword = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
AND 
[Password]='{passwordenc}'
"));

            if (CountPassword > 0)
            {
              string user_id = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select User_ID,Display_Name from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
"));
              string display_name = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Display_Name from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
"));
              bool isstorekeeper = (bool)(CommanFile.ExcuteScalar_YS($@"
select Is_Storekeeper from[dbo].[User] 
Where 
[User_ID] = '{user_id}'
"));
              Session["User_ID"] = user_id;
              Session["Display_Name"] = display_name;
              if (chkAgree_YS.Checked)
              {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(30);
              }
              else
              {
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);

              }
              Response.Cookies["UserName"].Value = txtEmail_YS.Text.Trim();
              Response.Cookies["Password"].Value = txtPassword_YS.Text.Trim();
              if (isstorekeeper)
              {
                Response.Redirect("../../IndexHomePage.aspx");
              }
              else
              {
                Response.Redirect("../../IndexHomePage_User.aspx");
              }


            }
            else
            {
              lblIncorrect_ps_YS.Text = "Please Enter Valid Password";
            }
          }
          else
          {
            lblIncorrect_ps_YS.Text = "Please Enter Valid Email Address";
          }
        }
      }

      catch (ThreadAbortException ex)
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
