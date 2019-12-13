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
      txtStorecategory_YS.Visible = false;
      txtStorename_YS.Visible = false;
    }
  }

}

