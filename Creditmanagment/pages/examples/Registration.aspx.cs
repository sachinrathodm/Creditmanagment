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
      _CommanControlList.Add(lblUpload_YS);
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

    private void BtnRegister_YS_Click_YS(object sender, EventArgs e)
    {

      string _Sql = $@"
INSERT INTO [dbo].[User]
           ([User_ID]
           ,[Email_ID]
           ,[Password]
           ,[Mobile_No]
           ,[Photo]
           ,[Display_Name]
           ,[Is_Storekeeper])
     VALUES
           ({Guid.NewGuid()}
,'{txtEmail_YS.Text}'
,'{txtPassword_YS.Text}'
,{txtMobileno_YS.Text}
,'{Guid.NewGuid()}'
,'{txtFirstname_YS.Text} {txtLastname_YS.Text}', {((rdStoreKeeper_YS.Checked) ? 1 : 0)})
";
    //  CommanFile.ExcuteNonQuery_YS(_Sql);
      if (rdStoreKeeper_YS.Checked)
      {

      }
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
      #endregion
    }
    #endregion
  }
}



