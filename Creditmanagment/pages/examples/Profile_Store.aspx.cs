using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Profile_Store : System.Web.UI.Page
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

      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        imgUserImage_YS.ImageUrl = $@"{("../../Images/" + userid + ".jpg")}";

        DataTable dtstorekeeperinfo = new DataTable();
        CommanFile.GetDataTable_YS(dtstorekeeperinfo, $@"
select Display_Name,First_Name,Last_Name,Mobile_No,Store_Name,Store_Category,Email_ID,Helpline_No,Address from [User] u   
			  inner join Store s on u.User_ID = s.User_ID      
			  Where u.User_ID = '{userid}'");

        Session["dtstorekeeperinfo"] = dtstorekeeperinfo;


        lblDisplayname_YS.Text = dtstorekeeperinfo.Rows[0][0].ToString();
        lblFirstname_YS.Text = dtstorekeeperinfo.Rows[0][1].ToString();
        lblLastname_YS.Text = dtstorekeeperinfo.Rows[0][2].ToString();
        lblMobileno_YS.Text = dtstorekeeperinfo.Rows[0][3].ToString();
        lblStorename_YS.Text = dtstorekeeperinfo.Rows[0][4].ToString();
        lblStorecategory_YS.Text = dtstorekeeperinfo.Rows[0][5].ToString();
        lblEmail_YS.Text = dtstorekeeperinfo.Rows[0][6].ToString();
        lblHelplineno_YS.Text = dtstorekeeperinfo.Rows[0][7].ToString();
        lblAddress_YS.Text = dtstorekeeperinfo.Rows[0][8].ToString();
       // lblAdharno_YS.Text = dtstorekeeperinfo.Rows[0][7].ToString();
      }
      else
        Response.Redirect("LoginPage.aspx");
    }
  }
}
