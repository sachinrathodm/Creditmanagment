using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Add_Invoice : System.Web.UI.Page
  {
    public Guid Voucher_ID = Guid.NewGuid();
    DataTable dtCustomers, dtItems;
    protected void Page_Load(object sender, EventArgs e)
    {
      string userid = Session["User_Id"].ToString();
      if (Session["User_ID"] != null)
      {
        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

        int isquickmode = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"select Is_Voucher_QuickMode from Store where Store_ID='{storeid}'"));
        if (isquickmode > 0)
        {
          lblitems.Visible = false;
          lblqty.Visible = false;
          ddItemName_YS.Visible = false;
          txtQty_YS.Visible = false;
        }
        dtCustomers = new DataTable();
        CommanFile.GetDataTable_YS(dtCustomers, $@"SELECT First_Name+' '+Last_Name as Customer_Name,Customer_ID
  FROM[CreditManagement].[dbo].[Customers]");
        ddCustomerName_YS.DataTextField = "Customer_Name";
        ddCustomerName_YS.DataValueField = "Customer_ID";
        ddCustomerName_YS.DataSource = dtCustomers.DefaultView;
        ddCustomerName_YS.DataBind();

        dtItems = new DataTable();
        CommanFile.GetDataTable_YS(dtItems, $@"select * from Store_Item where Store_ID='{storeid}'");
        ddItemName_YS.DataTextField = "Item_Name";
        ddItemName_YS.DataValueField = "Store_Item_ID";
        ddItemName_YS.DataSource = dtItems.DefaultView;
        ddItemName_YS.DataBind();
      }
      else
        Response.Redirect("pages/examples/LoginPage.aspx");
    }
  }
}
