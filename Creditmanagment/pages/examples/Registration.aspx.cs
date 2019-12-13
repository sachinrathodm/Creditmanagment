using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class Registration : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void rdStoreKeeper_YS_CheckedChanged(object sender, EventArgs e)
    {
      if (rdCustomers_YS.Checked)
      {
        txtStorename_YS.Visible = false;
        txtStorecategory_YS.Visible = false;
        txtHelplineno_YS.Visible = false;
        ddtVouchermode_YS.Visible = false;
      }
      else
      {
        txtStorename_YS.Visible = true;
        txtStorecategory_YS.Visible = true;
        txtHelplineno_YS.Visible = true;
        ddtVouchermode_YS.Visible = true;
      }
    }
  }

}

