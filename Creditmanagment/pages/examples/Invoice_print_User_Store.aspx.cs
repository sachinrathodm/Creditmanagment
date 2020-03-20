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
  public partial class Invoice_print_User_Store : System.Web.UI.Page
  {
    string userid, voucherid, storecustomerid;
    protected void Page_Load(object sender, EventArgs e)
    {
      try
      {
        storecustomerid = Session["storecustomerid"].ToString();
        voucherid = Session["voucherid"].ToString();
        userid = Session["User_ID"].ToString();
      }
      catch (Exception)
      {
        Response.Redirect("SessionErrorMessage.aspx");
      }

      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {
        lblName_YS.Text = Session["Display_Name"].ToString();
        login_YS.Visible = false;
        imgStoremg_YS.ImageUrl = $@"{"~/Images/" + userid + ".jpg"}";

        string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

        int countrequest = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) FRom Store_Customer_Request
where Store_ID ='{storeid}' and CU_Request_Status='p'"));

        int totalrequest = countrequest;

        if (totalrequest > 0)
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


      if (Session["User_ID"] != null && Session["Display_Name"] != null)
      {

        Boolean isstorekeeper = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Storekeeper From [User] 
where User_ID = '{userid}'
"));
        if (isstorekeeper)
        {
          string voucherdate = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
Select Voucher_Date From Voucher  
where Voucher_ID = '{voucherid}'"));

          lblDate_YS.Text = voucherdate;
          lblInvoiceid_YS.Text = voucherid;

          DataTable dtstoredetail = new DataTable();
          CommanFile.GetDataTable_YS(dtstoredetail, $@"
select Store_Name,Display_Name,Address,Mobile_No,Email_ID from [User]
   inner join Store on [User].User_ID = Store.User_ID
    Where [User].User_ID = '{userid}'");

          lblStorename_YS.Text = dtstoredetail.Rows[0][0].ToString();
          lblStorekeepname_YS.Text = dtstoredetail.Rows[0][1].ToString();
          lblAddress_YS.Text = dtstoredetail.Rows[0][2].ToString()
                                + "<br> Phone:" + dtstoredetail.Rows[0][3].ToString()
                                + "<br> Email :" + dtstoredetail.Rows[0][4].ToString();

          string customerid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Customer_ID From Store_Customers
where Store_Customers_ID = '{storecustomerid}'
"));

          DataTable dtcustomerdetail = new DataTable();
          CommanFile.GetDataTable_YS(dtcustomerdetail, $@"
select Display_Name,Address,Mobile_No,Email_ID From [User]
   inner join Customers on [User].User_ID = Customers.User_ID
   where Customer_ID ='{customerid}'
");
          lblCustomername_YS.Text = dtcustomerdetail.Rows[0][0].ToString();
          lblCustomerAddress_YS.Text = dtcustomerdetail.Rows[0][1].ToString()
                                + "<br> Phone: " + dtcustomerdetail.Rows[0][2].ToString()
                                + "<br> Email:" + dtcustomerdetail.Rows[0][3].ToString();
        }
        else
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
          lblAddress_YS.Text = storedetail.Rows[0][1].ToString()
                                + "<br> Phone: " + storedetail.Rows[0][4].ToString()
                                + "<br> Email: " + storedetail.Rows[0][3].ToString();
          lblStorekeepname_YS.Text = storedetail.Rows[0][2].ToString();

          DataTable ddcousomerdetail = new DataTable();
          CommanFile.GetDataTable_YS(ddcousomerdetail, $@"select u.Display_Name,c.Address,u.Mobile_No,u.Email_ID from Customers c
 inner join [User] u on c.User_ID = u.User_ID
 where u.User_ID ='{userid}'");

          if (ddcousomerdetail != null && ddcousomerdetail.Rows.Count < 0)
          {

          }
          else
          {
            lblCustomername_YS.Text = ddcousomerdetail.Rows[0][0].ToString();
            lblCustomerAddress_YS.Text = ddcousomerdetail.Rows[0][1].ToString()
                                          + "<br> Phone: " + ddcousomerdetail.Rows[0][2].ToString()
                                          + "<br> Email: " + ddcousomerdetail.Rows[0][3].ToString();
            lblInvoiceid_YS.Text = voucherid;
          }
          //string[] yash = voucherdetail.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
          //Session["yash1"] = yash;
        }

        DataTable voucherdetail = new DataTable();
        CommanFile.GetDataTable_YS(voucherdetail, $@"
 select Description,Amount from Voucher
where Voucher_ID = '{voucherid}'");
        StringBuilder sb = new StringBuilder();
        sb.Append(@"<table class= ""table table-striped"">");
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
          ltVoucherdetail_YS.Text = sb.ToString();
        }
        sb.Append("</table>");
      }
      else
      {

      }
    }
  }
}
