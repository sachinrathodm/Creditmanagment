using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Creditmanagment.pages.examples
{
  public partial class Invoice_print_User : System.Web.UI.Page
  {
    string userid, voucherid;
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        voucherid = Session["voucherid"].ToString();
        userid = Session["User_ID"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }
     

      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        DataTable dt = new DataTable();
        CommanFile.GetDataTable_YS(dt, $@"
Select Store_ID,Voucher_Date From Voucher  where Voucher_ID = '{voucherid}'");

        string storeid = dt.Rows[0][0].ToString();
        lblDate_YS.Text = dt.Rows[0][1].ToString();

        DataTable storedetail = new DataTable();
        CommanFile.GetDataTable_YS(storedetail, $@"
select s.Store_Name,s.Address,u.Display_Name,u.Email_ID,u.Mobile_No from Store s 
left outer join [User] u on s.User_ID = u.User_ID
 where Store_ID = '{storeid}'");

        lblStorename_YS.Text = storedetail.Rows[0][0].ToString();
        lblAddress_YS.Text = storedetail.Rows[0][1].ToString() + "<br> Email: " + storedetail.Rows[0][3].ToString() + "<br> Phone: " + storedetail.Rows[0][4].ToString();
        lblStorekeepname_YS.Text = storedetail.Rows[0][2].ToString();

        DataTable cousomerdetail = new DataTable();
        CommanFile.GetDataTable_YS(cousomerdetail, $@"select u.Display_Name,c.Address,u.Mobile_No,u.Email_ID from Customers c
 inner join [User] u on c.User_ID = u.User_ID
 where u.User_ID ='{userid}'");

        lblCustomername_YS.Text = cousomerdetail.Rows[0][0].ToString();
        lblCustomerAddress_YS.Text = cousomerdetail.Rows[0][1].ToString() + "<br> Phone: " + cousomerdetail.Rows[0][2].ToString() + "<br> Email: " + cousomerdetail.Rows[0][3].ToString();
        lblInvoiceid_YS.Text = voucherid;

        DataTable voucherdetail = new DataTable();

        CommanFile.GetDataTable_YS(voucherdetail, $@"
 select Description,Amount from Voucher
where Voucher_ID = '{voucherid}'");

        //string[] yash = voucherdetail.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
        //Session["yash1"] = yash;

        StringBuilder sb = new StringBuilder();
        sb.Append("<table class=table table-striped>");
        sb.Append("<tr>");
        foreach (DataColumn column in voucherdetail.Columns)
        {
          sb.Append("<th>" + column.ColumnName + "</th>");
        }
        sb.Append("</tr>");

        foreach (DataRow row in voucherdetail.Rows)
        {
          sb.Append("<tr>");
          foreach (DataColumn column in voucherdetail.Columns)
          {
            sb.Append("<td>" + row[column.ColumnName].ToString() + "</td>");
          }
          sb.Append("</tr>");
          sb.Append("</table>");
          ltVoucherdetail_YS.Text = sb.ToString();
        }


      }
      else
      {

      }
    }

    
  }
}
