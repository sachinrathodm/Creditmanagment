using System;
using System.Collections.Generic;
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
      // string connetionString;
      // SqlConnection cnn;
      // connetionString = @"Data Source=.\DE_17;Initial Catalog=test;User ID=sa;Password=sqladmin";
      // cnn = new SqlConnection(connetionString);
      // cnn.Open();
      // SqlCommand cmd = new SqlCommand($@"INSERT INTO [dbo].[register]
      //      ([firstname]
      //      ,[lastname])
      //VALUES
      //      ('{txtfirstname.Text}','{txtEmail.Text}')", cnn);
      // cmd.ExecuteNonQuery();
      // Response.Write("<script>alert('Sucessfully Connected');</script>");
      // cnn.Close();
    }
  }
}
