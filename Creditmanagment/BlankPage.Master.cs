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
    
    protected void Page_Load(object sender, EventArgs e)
    {
      string UserGUID = Session["User_ID"].ToString();
      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {

        lblName_YS.Text = Session["Display_Name"].ToString();
        login_YS.Visible = false;
        imgStoremg_YS.ImageUrl = $@"{"~/Images/" + UserGUID + ".jpg"}";

        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{UserGUID}'
"));

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
          lblgetrequest_YS.Text = Convert.ToString(countrequest + "Cutomer requests");
        }
        else
        {
          lblgetrequest_YS.Text = "No any Request";
        }

      }
    }
  }
}
