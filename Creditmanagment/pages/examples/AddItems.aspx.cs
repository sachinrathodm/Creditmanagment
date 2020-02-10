using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Creditmanagment.pages.examples
{
  public partial class AddItems : System.Web.UI.Page
  {
    public Guid Storeitemid = Guid.NewGuid();
    protected void Page_Load(object sender, EventArgs e)
    {
      //Events
      btnAddItem_YS.Click += BtnAddItem_YS_Click_YS;
    }

    private void BtnAddItem_YS_Click_YS(object sender, EventArgs e)
    {
      //tstring insertQuery = $@"
    ////INSERT INTO [dbo].[Store_Item]
    ////           ([Store_Item_ID]
    ////           ,[Store_ID]
    ////           ,[Item_Name]
    ////           ,[Rate])
    ////     VALUES
    ////           ('{Storeitemid}'
    ////,'{Storeitemid}'
    ////,'{}')
    ////";
    }
  }
}
