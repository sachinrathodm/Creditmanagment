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
    string a;
    protected void Page_Load(object sender, EventArgs e)
    {
      //Events
      btnAddItem_YS.Click += BtnAddItem_YS_Click_YS;
      
      if (Session["User_Id"] != null)
      {
         a = Session["User_Id"].ToString();
      }
    }

    private void BtnAddItem_YS_Click_YS(object sender, EventArgs e)
    {

      string insertItem = $@"
INSERT INTO [dbo].[Store_Item]
           ([Store_Item_ID]
           ,[Store_ID]
           ,[Item_Name]
           ,[Rate])
     VALUES
           ('{a}'
,'{Storeitemid}'
,'{txtItemname_YS.Text}'
,'{txtRate_YS.Text}')
";
      CommanFile.ExcuteNonQuery_YS(insertItem);

    }
  }
}
