using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Creditmanagment
{
  public static class CommanFile
  {
   // public static string connetionString = @"Data Source=DESKTOP-M7QNTA0\SQLEXPRESS;Initial Catalog=CreditManagement;User ID=sa;Password=sqladmin";
    public static string connetionString = @"Data Source=DESKTOP-A5UKIHU\DE_17;Initial Catalog=CreditManagement;User ID=sa;Password=sqladmin";

    public static int ExcuteNonQuery_YS(string Query)
    {
      SqlConnection con;
      con = new SqlConnection(connetionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(Query, con);
      int i = cmd.ExecuteNonQuery();
      con.Close();
      return i;
    }

    public static Object ExcuteScalar_YS(string Query)
    {
      SqlConnection con;
      con = new SqlConnection(connetionString);
      con.Open();
      SqlCommand cmd = new SqlCommand(Query, con);
      object i = cmd.ExecuteScalar();
      con.Close();
      return i;
    }

    public static DataTable SqlDataAdapter_YS(string Query)
    {
      SqlConnection con;
      con = new SqlConnection(connetionString);
      con.Open();
      SqlDataAdapter adpt = new SqlDataAdapter(Query, con);
      DataTable dt = new DataTable();
      adpt.Fill(dt);
      return dt;
    }

    public static DataTable GetDataTable_YS(DataTable dt, string Query)
    {
      SqlConnection conn = new SqlConnection(connetionString);
      conn.Open();
      SqlCommand cmd = new SqlCommand(Query, conn);
      dt.Load(cmd.ExecuteReader());
      conn.Close();
      return dt;
    }

    public static string encryptionpass(string password)
    {
      string msg = "";
      byte[] encode = new byte[password.Length];
      encode = Encoding.UTF8.GetBytes(password);
      msg = Convert.ToBase64String(encode);
      return msg;
    }
  }
}
