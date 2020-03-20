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
    public string userid;
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
      if (string.IsNullOrEmpty(Session["User_ID"].ToString()))
      {
        Response.Redirect("LoginPage.aspx");
      }
      else
      {
        //Events
        btnAddItem_YS.Click += BtnAddItem_YS_Click_YS;
      }
    }

    private void BtnAddItem_YS_Click_YS(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtItemname_YS.Text) ||
            string.IsNullOrEmpty(txtRate_YS.Text))
      {
        Response.Write("<script>alert('Please Enter all fileds');</script>");
        return;
      }
      else
      {
        string Strore_ID_YS = Convert.ToString(CommanFile.ExcuteScalar_YS($@"
select Store_ID from [dbo].[Store] 
Where 
[User_ID] = '{userid}'
"));
        string insertItem = $@"
INSERT INTO [dbo].[Store_Item]
           ([Store_Item_ID]
           ,[Store_ID]
           ,[Item_Name]
           ,[Rate])
     VALUES
           ('{Storeitemid}'
,'{Strore_ID_YS}'
,'{txtItemname_YS.Text}'
,'{txtRate_YS.Text}')
";
        CommanFile.ExcuteNonQuery_YS(insertItem);
        txtItemname_YS.Text = null;
        txtRate_YS.Text = null;
      }
      }
    }
  }
