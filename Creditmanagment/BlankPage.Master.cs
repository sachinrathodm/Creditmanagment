using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class BlankPage : System.Web.UI.MasterPage
  {
    string userid;
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      { 
        userid = Session["User_ID"].ToString();
      }
     catch(Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }

      Boolean isquickmode = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Voucher_QuickMode From [Store] 
where User_ID = '{userid}'
"));
      Session["isquickmode"] = isquickmode;

      Boolean isstorekeeper = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Storekeeper From [User] 
where User_ID = '{userid}'
"));
      Session["isstorekeeper"] = isstorekeeper;

      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        lblName_YS.Text = Session["Display_Name"].ToString();
        lblStorekeepername_YS.Text = Session["Display_Name"].ToString();

        imgStoremg_YS.ImageUrl = $@"{"~/Images/" + userid + ".jpg"}";

        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
        //int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));

        //Session["isquickmode"] = isquickmode.ToString();

        int countrequest = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) FRom Store_Customer_Request
where Store_ID ='{storeid}' and CU_Request_Status='p'"));

        int totalrequest = countrequest;

        if (totalrequest>0)
        {
          lbltotalrequest_YS.Text = Convert.ToString(totalrequest);
        }
        if (countrequest > 0)
        {
          lblgetrequest_YS.Text = Convert.ToString(countrequest + " Cutomer requests");
        }
        else
        {
          lblgetrequest_YS.Text = "No any Request";
        }

      }
    }
  }
}
