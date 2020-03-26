using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Profile_User : System.Web.UI.Page
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

        DataTable dtcustomerinfo = new DataTable();
        CommanFile.GetDataTable_YS(dtcustomerinfo, $@"
select Display_Name,First_Name,Last_Name,Mobile_No,Email_ID,Birth_Date,Address,Adhar_Card_Number from [User] u   
inner join Customers c on u.User_ID = c.User_ID      
Where u.User_ID = '{userid}'"     );

        Session["dtcustomerinfo"] = dtcustomerinfo;


        lblDisplayname_YS.Text = dtcustomerinfo.Rows[0][0].ToString();
        lblFirstname_YS.Text = dtcustomerinfo.Rows[0][1].ToString();
        lblLastname_YS.Text = dtcustomerinfo.Rows[0][2].ToString();
        lblMobileno_YS.Text = dtcustomerinfo.Rows[0][3].ToString();
        lblEmail_YS.Text = dtcustomerinfo.Rows[0][4].ToString();
        lblBirtdate_YS.Text =Convert.ToDateTime(dtcustomerinfo.Rows[0][5]).ToString("dd/MM/yyyy");
        lblAddress_YS.Text = dtcustomerinfo.Rows[0][6].ToString();
        lblAdharno_YS.Text = dtcustomerinfo.Rows[0][7].ToString();
      }
      else
        Response.Redirect("LoginPage.aspx");
    }
  }
}
