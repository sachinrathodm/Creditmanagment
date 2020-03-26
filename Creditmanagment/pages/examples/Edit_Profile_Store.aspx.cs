using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Edit_Profile_Store : System.Web.UI.Page
  {
    string userid,_sql;
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
        btnSave_YS.Click += btnSave_Click_YS;
        btnCancel_YS.Click += btnCancel_Click_YS;
        if (!Page.IsPostBack)
        {
          DataTable dtstorekeeperinfo = (DataTable)Session["dtstorekeeperinfo"];

          txtE_Firstname_YS.Text = dtstorekeeperinfo.Rows[0][1].ToString();
          txtE_Lastname_YS.Text = dtstorekeeperinfo.Rows[0][2].ToString();
          txtE_Mobileno_YS.Text = dtstorekeeperinfo.Rows[0][3].ToString();
          txtE_Storename_YS.Text = dtstorekeeperinfo.Rows[0][4].ToString();
          txtE_Storecategory_YS.Text = dtstorekeeperinfo.Rows[0][5].ToString();
          txtE_Email_YS.Text = dtstorekeeperinfo.Rows[0][6].ToString();
          txtE_Helplineno.Text = dtstorekeeperinfo.Rows[0][7].ToString();
          txtE_Address_YS.Text = dtstorekeeperinfo.Rows[0][8].ToString();
        }
      }
    }

    private void btnCancel_Click_YS(object sender, EventArgs e)
    {
      Response.Redirect("Profile_Store.aspx");
    }

    private void btnSave_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtE_Firstname_YS.Text) ||
         string.IsNullOrEmpty(txtE_Lastname_YS.Text) ||
         string.IsNullOrEmpty(txtE_Mobileno_YS.Text) ||
         string.IsNullOrEmpty(txtE_Email_YS.Text) ||
         string.IsNullOrEmpty(txtE_Storename_YS.Text) ||
         string.IsNullOrEmpty(txtE_Address_YS.Text) ||
         string.IsNullOrEmpty(txtE_Helplineno.Text) ||
         string.IsNullOrEmpty(txtE_Storecategory_YS.Text))
      {
        Response.Write("<script>alert('Please Enter all fileds');</script>");
        return;
      }
      else
      {
        insert_in_user_table_YS();
        _sql = $@"
Update [dbo].[Store] set
            [Store_Name] = '{txtE_Storename_YS.Text}'
           ,[Store_Category] = '{txtE_Storecategory_YS.Text}'
           ,[First_Name] ='{txtE_Firstname_YS.Text}'
           ,[Last_Name] = '{txtE_Lastname_YS.Text}'
           ,[Helpline_No] = '{txtE_Helplineno.Text}'
           ,[Address] = '{txtE_Address_YS.Text}'
     where [User_ID] ='{userid}'
";
        CommanFile.ExcuteNonQuery_YS(_sql);

        ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true);
        Response.Redirect("Profile_Store.aspx");
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
