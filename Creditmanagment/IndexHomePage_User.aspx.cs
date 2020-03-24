using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment
{
  public partial class IndexHomePage_User : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      string customerid;
      if (string.IsNullOrEmpty(Session["User_ID"].ToString()))
      {
        Response.Redirect("LoginPage.aspx");
      }
      else
      {
        string userid = Session["User_ID"].ToString();
        if (Session["User_ID"] != null)
        {
          customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Customer_ID]
      ,[User_ID]
    FROM[CreditManagement].[dbo].[Customers]
    where User_ID = '{userid}'
"));
          string totaluser = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT Count([CU_Request_Status])
  FROM [CreditManagement].[dbo].[Store_Customer_Request]
  where Customer_ID = '{customerid}' and CU_Request_Status = 'A'
"));
          string customercredit = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Credit From Store_Customers 
where Customer_ID = '{customerid}'
"));
          lblNumberofuser_YS.Text = totaluser;
          lblCustomerCredit.Text = customercredit; 
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
    }
  }
}
