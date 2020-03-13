using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class DisplayStoresList_User : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
             string userid = Session["User_Id"].ToString();
      if (Session["User_ID"] != null)
      {
        string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Customer_ID]
  FROM [CreditManagement].[dbo].[Customers]
  where User_ID = '{userid}'
"));
        DataTable dtstoredata1 = new DataTable();
         dtstoredata1 = (CommanFile.GetDataTable_YS(dtstoredata1,$@"
SELECT *
  FROM [CreditManagement].[dbo].[Store_Customer_Request]
  where Customer_ID = '{customerid}' and CU_Request_Status = 'A'
"));
        
        foreach (DataRow item in dtstoredata1.Rows)
        {
          string a;

        }
        DataTable dtstoredata = new DataTable();
        Convert.ToString(CommanFile.GetDataTable_YS(dtstoredata, $@"select * from [dbo].[Store]
        where Store_ID = '{dtstoredata1}'
"));
        gdDisplayStores.DataSource = dtstoredata.DefaultView;
        gdDisplayStores.DataBind();

      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }
  }
}
