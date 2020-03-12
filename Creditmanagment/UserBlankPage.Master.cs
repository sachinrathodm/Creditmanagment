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
    protected void Page_Load(object sender, EventArgs e)
    {
      string UserGUID = Session["User_ID"].ToString();
      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        lblName_YS.Text = Session["Display_Name"].ToString();

      }
      imgUserImage_YS.ImageUrl = $@"{("~/Images/" + UserGUID + ".jpg")}";
    }
  }
}
