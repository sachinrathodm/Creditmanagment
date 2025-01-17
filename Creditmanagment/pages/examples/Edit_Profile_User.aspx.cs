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
    string userid, _sql;
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
          btnSave_YS.Click += btnSave_YS_Click_YS;
        btnCancel_YS.Click += btnCancel_Click_YS;

        if (!Page.IsPostBack)
        {
          DataTable dtcustomerinfo = (DataTable)Session["dtcustomerinfo"];

          txtE_Firstname_YS.Text = dtcustomerinfo.Rows[0][1].ToString();
          txtE_Lastname_YS.Text = dtcustomerinfo.Rows[0][2].ToString();
          txtE_Mobileno_YS.Text = dtcustomerinfo.Rows[0][3].ToString();
          txtE_Email_YS.Text = dtcustomerinfo.Rows[0][4].ToString();
          txtE_BirthDate_YS.Text = Convert.ToDateTime(dtcustomerinfo.Rows[0][5]).ToString("dd-MM-yyyy");
          txtE_Address_YS.Text = dtcustomerinfo.Rows[0][6].ToString();
          txtE_Adharcardno_YS.Text = dtcustomerinfo.Rows[0][7].ToString();
        }
      }
    }

    private void btnCancel_Click_YS(object sender, EventArgs e)
    {
      Response.Redirect("Profile_User.aspx");
    }

    private void btnSave_YS_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtE_Firstname_YS.Text) ||
          string.IsNullOrEmpty(txtE_Lastname_YS.Text) ||
          string.IsNullOrEmpty(txtE_Mobileno_YS.Text) ||
          string.IsNullOrEmpty(txtE_Email_YS.Text) ||
          string.IsNullOrEmpty(txtE_BirthDate_YS.Text) ||
          string.IsNullOrEmpty(txtE_Address_YS.Text) ||
          string.IsNullOrEmpty(txtE_Adharcardno_YS.Text))
      {
        Response.Write("<script>alert('Please Enter all fileds');</script>");
        return;
      }
      else
      {
        insert_in_user_table_YS();
        _sql = $@"
Update [dbo].[Customers] set
           [First_Name] ='{txtE_Firstname_YS.Text}'
           ,[Last_Name] = '{txtE_Lastname_YS.Text}'
           ,[Birth_Date] ='{txtE_BirthDate_YS.Text}'
           ,[Phone_No] = '{txtE_Mobileno_YS.Text}'
           ,[Address] = '{txtE_Address_YS.Text}'
           ,[Adhar_Card_Number] = '{txtE_Adharcardno_YS.Text}'
     where [User_ID] ='{userid}'
";
        CommanFile.ExcuteNonQuery_YS(_sql);

        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true);
        Response.Redirect("Profile_User.aspx");
      }
    }
    private void insert_in_user_table_YS()
    {
      _sql = $@"
Update [dbo].[User] set
       [Email_ID] = '{txtE_Email_YS.Text}'
      ,[Mobile_No] = '{txtE_Mobileno_YS.Text}'
      ,[Photo]='{userid}'
      ,[Display_Name] = '{txtE_Firstname_YS.Text} {txtE_Lastname_YS.Text}'
where [User_ID] ='{userid}'
";

      InputFile_YS.SaveAs(Server.MapPath("/Images/" + userid + ".jpg"));
      CommanFile.ExcuteNonQuery_YS(_sql);
    }

  }
}
