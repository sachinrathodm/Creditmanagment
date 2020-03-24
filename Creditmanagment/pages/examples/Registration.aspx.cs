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
    Guid UserGUID = Guid.NewGuid();
    string encryptpassword;
    List<Control> _CommanControlList = new List<Control>();
    List<Control> _StoreKeeperControl = new List<Control>();
    List<Control> _CustomerControl = new List<Control>();

    protected void Page_Load(object sender, EventArgs e)
    {
        #region Controls
        //CommanControl
        _CommanControlList.Add(txtFirstname_YS);
        _CommanControlList.Add(txtLastname_YS);
        _CommanControlList.Add(txtEmail_YS);
        _CommanControlList.Add(txtPassword_YS);
        _CommanControlList.Add(txtRetypepassword_YS);
        _CommanControlList.Add(txtMobileno_YS);
        _CommanControlList.Add(InputFile_YS);
        _CommanControlList.Add(lblinputfile);
        //_CommanControlList.Add(lblUpload_YS);
        _CommanControlList.Add(ltrinputfile);
        _CommanControlList.Add(txtAddress_YS);
        _CommanControlList.Add(btnRegister_YS);
        _CommanControlList.Add(chkAgree);
        _CommanControlList.Add(lblismember_YS);
        _CommanControlList.Add(lblAgree);
        //StoreKeeperControl
        _StoreKeeperControl.Add(txtStorecategory_YS);
        _StoreKeeperControl.Add(txtStorename_YS);
        _StoreKeeperControl.Add(ddtVouchermode_YS);
        _StoreKeeperControl.Add(txtHelplineno_YS);
        //CustomerControl
        _CustomerControl.Add(lblBirthDate_YS);
        _CustomerControl.Add(txtBirthDate_YS);
        _CustomerControl.Add(ltrBirthdate_YS);
        _CustomerControl.Add(txtAdharcardno_YS);

        foreach (var control in _CommanControlList)
          control.Visible = false;
        foreach (var control in _CustomerControl)
          control.Visible = false;
        foreach (var control in _StoreKeeperControl)
          control.Visible = false;
        #endregion

        #region Events
        rdCustomers_YS.CheckedChanged += rdStoreKeeper_YS_CheckedChanged_YS;
        rdStoreKeeper_YS.CheckedChanged += rdStoreKeeper_YS_CheckedChanged_YS;
        btnRegister_YS.Click += BtnRegister_YS_Click_YS;
        #endregion
    }

    string _Sql;
    private void BtnRegister_YS_Click_YS(object sender, EventArgs e)
    {
      int IsEmail = Convert.ToInt32(CommanFile.ExcuteScalar_YS($@"
select count(*) from[dbo].[User] 
Where 
[Email_ID] = '{txtEmail_YS.Text}'
"));
      if (IsEmail > 0)
      {
        Response.Write("<script>alert('Please Select Another Emailid');</script>");
        return;
      }

      encryptpassword = CommanFile.encryptionpass(txtPassword_YS.Text);

      if (rdCustomers_YS.Checked)
      {

        if (string.IsNullOrEmpty(txtFirstname_YS.Text) ||
            string.IsNullOrEmpty(txtLastname_YS.Text) ||
            string.IsNullOrEmpty(txtMobileno_YS.Text) ||
            string.IsNullOrEmpty(txtEmail_YS.Text) ||
            string.IsNullOrEmpty(txtPassword_YS.Text) ||
            string.IsNullOrEmpty(txtRetypepassword_YS.Text) ||
            string.IsNullOrEmpty(txtAddress_YS.Text)||
            string.IsNullOrEmpty(txtAdharcardno_YS.Text))
        {
          Response.Write("<script>alert('Please Enter all fileds');</script>");
          return;
        }
        else
        {
          insert_in_user_table_YS();
          Guid CustomerGUID = Guid.NewGuid();
          _Sql = $@"
INSERT INTO [dbo].[Customers]
           ([Customer_ID]
           ,[User_ID]
           ,[First_Name]
           ,[Last_Name]
           ,[Birth_Date]
           ,[Phone_No]
           ,[Address]
           ,[Adhar_Card_Number])
     VALUES
('{CustomerGUID}'
,'{UserGUID}'
,'{txtFirstname_YS.Text}'
,'{txtLastname_YS.Text}'
,'{txtBirthDate_YS.Text}'
,'{txtMobileno_YS.Text}'
,'{txtAddress_YS.Text}'
,{txtAdharcardno_YS.Text})
";
          CommanFile.ExcuteNonQuery_YS(_Sql);

          ScriptManager.RegisterStartupScript(this, GetType(), "alertMessage", "alertMessage();", true);
          Response.Redirect("LoginPage.aspx");
        }
      }

      if (rdStoreKeeper_YS.Checked)
      {
        if (string.IsNullOrEmpty(txtFirstname_YS.Text) ||
           string.IsNullOrEmpty(txtLastname_YS.Text) ||
           string.IsNullOrEmpty(txtMobileno_YS.Text) ||
           string.IsNullOrEmpty(txtEmail_YS.Text) ||
           string.IsNullOrEmpty(txtPassword_YS.Text) ||
           string.IsNullOrEmpty(txtRetypepassword_YS.Text) ||
           string.IsNullOrEmpty(txtAddress_YS.Text) ||
           string.IsNullOrEmpty(txtStorename_YS.Text) ||
           string.IsNullOrEmpty(txtStorecategory_YS.Text) ||
           string.IsNullOrEmpty(txtHelplineno_YS.Text) ||
           string.IsNullOrEmpty(ddtVouchermode_YS.Text))
        {
          Response.Write("<script>alert('Please Enter all fileds');</script>");
          return;
        }
        else
        {
          insert_in_user_table_YS();
          Guid StoreGUID = Guid.NewGuid();

          _Sql = $@"
INSERT INTO [dbo].[Store]
           ([Store_ID]
           ,[User_ID]
           ,[Store_Name]
           ,[Store_Category]
           ,[First_Name]
           ,[Last_Name]
           ,[Helpline_No]
           ,[Address]
           ,[Is_Voucher_QuickMode])
     VALUES
('{StoreGUID}'
,'{UserGUID}'
,'{txtStorename_YS.Text}'
,'{txtStorecategory_YS.Text}'
,'{txtFirstname_YS.Text}'
,'{txtLastname_YS.Text}'
,'{txtHelplineno_YS.Text}'
,'{txtAddress_YS.Text}'
,{((Convert.ToInt32(ddtVouchermode_YS.SelectedValue) == 1) ? 1 : 0)})
";
          CommanFile.ExcuteNonQuery_YS(_Sql);
          //Response.Write("<script>alert('Register Succesfully');</script>");
          Response.Redirect("LoginPage.aspx");
        }
      }
    }

    private void insert_in_user_table_YS()
    {
      _Sql = $@"
INSERT INTO [dbo].[User](
       [User_ID]
      ,[Email_ID]
      ,[Password]
      ,[Mobile_No]
      ,[Photo]
      ,[Display_Name]
      ,[Is_Storekeeper]
)VALUES(
        '{UserGUID}'
        ,'{txtEmail_YS.Text}'
        ,'{encryptpassword}'
        ,{txtMobileno_YS.Text}
        ,'{UserGUID}'
        ,'{txtFirstname_YS.Text} {txtLastname_YS.Text}'
        , {((rdStoreKeeper_YS.Checked) ? 1 : 0)})
";

      InputFile_YS.SaveAs(Server.MapPath("/Images/" + UserGUID + ".jpg"));
      CommanFile.ExcuteNonQuery_YS(_Sql);
    }

    #region Events
    protected void rdStoreKeeper_YS_CheckedChanged_YS(object sender, EventArgs e)
    {
      #region Radio Button On OFF
      if (rdCustomers_YS.Checked)
      {
        foreach (var control in _CommanControlList)
          control.Visible = true;
        foreach (var control in _CustomerControl)
          control.Visible = true;
        foreach (var control in _StoreKeeperControl)
          control.Visible = false;
      }
      if (!rdCustomers_YS.Checked)
      {
        foreach (var control in _CommanControlList)
          control.Visible = true;
        foreach (var control in _CustomerControl)
          control.Visible = false;
        foreach (var control in _StoreKeeperControl)
          control.Visible = true;
      }
      //btnupload

      #endregion
    }

    #endregion
  }
}



