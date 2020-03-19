using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class DisplayUsersList : System.Web.UI.Page
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
      if (Session["User_ID"] != null)
      {
        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));
          DataTable dtstoredata_YS = new DataTable();
          dtstoredata_YS = (CommanFile.GetDataTable_YS(dtstoredata_YS, $@"  SELECT First_Name+' '+Last_Name as CustomerName,Phone_No,Address
FROM Store_Customer_Request
Left outer JOIN Customers ON Customers.Customer_ID=Store_Customer_Request.Customer_ID 
 where Store_ID = '{storeid}' and CU_Request_Status = 'A'
"));

          gdDisplayUsers.DataSource = dtstoredata_YS.DefaultView;
          gdDisplayUsers.DataBind();
        }
        else
          Response.Redirect("pages/examples/LoginPage.aspx");
      }
    }
  }



