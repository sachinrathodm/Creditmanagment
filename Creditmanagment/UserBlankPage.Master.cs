using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment
{
  public partial class UserBlankPage : System.Web.UI.MasterPage
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
        lblName_YS.Text = Session["Display_Name"].ToString();
        lblcustomername_YS.Text = Session["Display_Name"].ToString();
      }
      imgUserImage_YS.ImageUrl = $@"{("~/Images/" + userid + ".jpg")}";

      Boolean isstorekeeper = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Storekeeper From [User] 
where User_ID = '{userid}'
"));
      Session["isstorekeeper"] = isstorekeeper;

      int storenotification = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) FRom Store_Customer_Request
where Customer_ID ='{userid}' and CU_Request_Status='A' or CU_Request_Status='R'
"));

      int totalrequest = storenotification;

      if (totalrequest > 0)
      {
        lbltotalrequest_YS.Text = Convert.ToString(totalrequest);
      }
      if (storenotification > 0)
      {
        lblgetrequest_YS.Text = Convert.ToString(storenotification + " Store Notification");
      }
      else
      {
        lblgetrequest_YS.Text = "No any Request";
      }
    }
  }
}
