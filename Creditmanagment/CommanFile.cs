using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Creditmanagment
{
  public static class CommanFile
  {
    public static void ExcuteNonQuery_YS(string Query)
    {
      string connetionString;
      SqlConnection con;
      connetionString = @"Data Source=DESKTOP-M7QNTA0\SQLEXPRESS;Initial Catalog=CreditManagement;User ID=sa;Password=sqladmin";
      con = new SqlConnection(connetionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(Query,con);
      cmd.ExecuteNonQuery();
      con.Close();
    }
  }
}
