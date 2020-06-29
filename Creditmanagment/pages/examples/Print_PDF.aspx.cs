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
  public partial class Print_PDF : System.Web.UI.Page
  {
    string userid, voucherid, storecustomerid;
    DataTable dtvoucher;
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
        Boolean isstorekeeper = Convert.ToBoolean(CommanFile.ExcuteScalar_YS($@"
select Is_Storekeeper From [User] 
where User_ID = '{userid}'
"));
        Session["isstorekeeper"] = isstorekeeper;

        if (isstorekeeper)
        {
          if (Session["User_ID"] != null && Session["Display_Name"] != null)
          {
            //lblName_YS.Text = Session["Display_Name"].ToString();
            //lblStorekeepername_YS.Text = Session["Display_Name"].ToString();
            //imgStoremg_YS.ImageUrl = $@"{"~/Images/" + userid + ".jpg"}";

            string storeid = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
SELECT[Store_ID]
  FROM [CreditManagement].[dbo].[Store]
  where User_ID = '{userid}'
"));

            if (isstorekeeper)
            {
              int countrequest = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) FRom Store_Customer_Request
where Store_ID ='{storeid}' and CU_Request_Status='p'"));

              int totalrequest = countrequest;

              if (totalrequest > 0)
              {
               // lbltotalrequest_YS.Text = Convert.ToString(totalrequest);
              }
              if (countrequest > 0)
              {
                //lblgetrequest_YS.Text = Convert.ToString(countrequest + " Cutomer requests");
              }
              else
              {
                //lblgetrequest_YS.Text = "No any Request";
              }
            }
          }
        }
        else
        {
          //if (Session["User_ID"] != null && Session["Display_Name"] != null)
          //{
          //  lblUsername_YS.Text = Session["Display_Name"].ToString();
          //  lblCustomername.Text = Session["Display_Name"].ToString();
          //}
          //imgUserImage_YS.ImageUrl = $@"{"~/Images/" + userid + ".jpg"}";
        }

        if (Session["User_ID"] != null && Session["Display_Name"] != null)
        {

          if (isstorekeeper)
          {
            dtvoucher = new DataTable();
            CommanFile.GetDataTable_YS(dtvoucher, $@"
Select Voucher_Date,Amount From Voucher
where Voucher_ID = '{voucherid}'");

            lblDate_YS.Text = Convert.ToDateTime(dtvoucher.Rows[0][0]).ToString("dd/MM/yyyy hh:mm tt");
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
            dtvoucher = new DataTable();
            CommanFile.GetDataTable_YS(dtvoucher, $@"
Select Store_ID,Amount,Voucher_Date From Voucher  where Voucher_ID = '{voucherid}'");

          string storeid = dtvoucher.Rows[0][0].ToString();
          lblDate_YS.Text = dtvoucher.Rows[0][2].ToString();

          DataTable dtstoredetail = new DataTable();
            CommanFile.GetDataTable_YS(dtstoredetail, $@"
select s.Store_Name,s.Address,u.Display_Name,u.Email_ID,u.Mobile_No from Store s 
left outer join [User] u on s.User_ID = u.User_ID
 where Store_ID = '{storeid}'");

          lblStorename_YS.Text = dtstoredetail.Rows[0][0].ToString();
          lblAddress_YS.Text = dtstoredetail.Rows[0][1].ToString()
                                + "<br> Phone: " + dtstoredetail.Rows[0][4].ToString()
                                + "<br> Email: " + dtstoredetail.Rows[0][3].ToString();
          lblStorekeepname_YS.Text = dtstoredetail.Rows[0][2].ToString();

          DataTable dtcousomerdetail = new DataTable();
            CommanFile.GetDataTable_YS(dtcousomerdetail, $@"select u.Display_Name,c.Address,u.Mobile_No,u.Email_ID from Customers c
 inner join [User] u on c.User_ID = u.User_ID
 where u.User_ID ='{userid}'");

            if (dtcousomerdetail != null && dtcousomerdetail.Rows.Count < 0)
            {

            }
            else
          {
            lblCustomername_YS.Text = dtcousomerdetail.Rows[0][0].ToString();
            lblCustomerAddress_YS.Text = dtcousomerdetail.Rows[0][1].ToString()
                                          + "<br> Phone: " + dtcousomerdetail.Rows[0][2].ToString()
                                          + "<br> Email: " + dtcousomerdetail.Rows[0][3].ToString();
            lblInvoiceid_YS.Text = voucherid;
          }
          }

          DataTable dtvoucherdetail = new DataTable();
          CommanFile.GetDataTable_YS(dtvoucherdetail, $@"
select 
	vd.Description_detai
	,si.Item_Name
	,vd.Rate
	,vd.QTY
	,vd.Amount 
From Voucher_Detail vd  
inner join Store_Item SI
	on SI.Store_Item_ID = vd.Store_Item_ID
 where vd.Voucher_ID = '{voucherid}'");

        int count = 0;

        StringBuilder sb = new StringBuilder();
          sb.Append(@"<table class="" table table-striped"" style=""width:100%;padding:.75rem;vertical-align: top"">");
          sb.Append(@"<tr style=""background-color:#dee2e6;    text-align: left"">");
          foreach (DataColumn column in dtvoucherdetail.Columns)
          {
            sb.Append(@"<th style=""padding: 15px"">" + column.ColumnName + "</th>");
          }
          sb.Append("</tr>");

          foreach (DataRow row in dtvoucherdetail.Rows)
          {
          count = count % 2;
          if (count==0)
          {
            sb.Append(@"<tr >");
            foreach (DataColumn column in dtvoucherdetail.Columns)
            {
              sb.Append(@"<td style=""padding: 15px"">" + row[column.ColumnName].ToString() + "</td>");
            }
            sb.Append("</tr>");
            count++;
          }
          else
          {
            sb.Append(@"<tr style=""background-color:#dee2e6"">");
            foreach (DataColumn column in dtvoucherdetail.Columns)
            {
              sb.Append(@"<td style=""padding: 15px"">" + row[column.ColumnName].ToString() + "</td>");
            }
            sb.Append("</tr>");
            count++;
          }
            
            ltVoucherdetail_YS.Text = sb.ToString();
          }
          sb.Append("</table>");
          lblTotalamount_YS.Text = dtvoucher.Rows[0][1].ToString();
        }
        else
        {

        }
      }
    }
  }
