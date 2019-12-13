<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Creditmanagment.pages.examples.Registration" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>AdminLTE 3 | Registration Page</title>

    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Font Awesome -->
    <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- icheck bootstrap -->
    <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">
    <!-- Theme style -->
    <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
    <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition register-page">
    <form id="f1" runat="server">
        <div class="register-box">
            <div class="register-logo">
                <a href="../../index.html"><b>Credit Managment</b></a>
            </div>

            <div class="card ml-5 mr-5">
                <div class="card-body register-card-body">
                    <p class="login-box-msg">Register a new membership</p>


                    <div class="input-group mb-3">
                        <%--<asp:RadioButton ID="rdStoreKeeper_YS" GroupName="a" AutoPostback="true" Checked="true" UseSubmitBehavior="false"  value="StoreKeeper" runat="server" OnCheckedChanged="rdStoreKeeper_YS_CheckedChanged" />
                                    StoreKeeper
                            <asp:RadioButton ID="rdCustomers_YS" GroupName="a" value="Cusomers" runat="server" />

                         Customers  --%>

                        <div class="ml-5 mr-5">
                            <asp:Label runat="server" class="btn bg-olive active" ID="hello">
                                <asp:RadioButton ID="rdStoreKeeper_YS" GroupName="a" AutoPostBack="true" value="StoreKeeper" runat="server" OnCheckedChanged="rdStoreKeeper_YS_CheckedChanged" />
                                StoreKeepers
                            </asp:Label>
                            <asp:Label runat="server" class="btn bg-olive active" ID="Label1">
                                <asp:RadioButton ID="rdCustomers_YS" GroupName="a" AutoPostBack="true" value="Cusomers" runat="server" OnCheckedChanged="rdStoreKeeper_YS_CheckedChanged" />
                                Customers 
                            </asp:Label>

                            <%-- <asp:RadioButtonList CausesValidation="false"  ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">
                                 <asp:ListItem></asp:ListItem>
                                 <asp:ListItem></asp:ListItem>
                              </asp:RadioButtonList>--%>
                        </div>

                    </div>

                    <div class="input-group-append">
                        <div class="m-2" style="text-align: left; width: 200px">
                            <asp:TextBox ID="txtFirstname_YS" class="form-control" placeholder="First name" runat="server" />
                        </div>
                        <div class="m-2" style="width: 200px;">
                            <asp:TextBox ID="txtLastname_YS" class="form-control" placeholder="Last name" runat="server" />
                        </div>
                    </div>


                    <div class="input-group-append">
                        <div class="m-2" style="text-align: left; width: 200px">
                            <asp:TextBox ID="txtMobileno_YS" class="form-control" placeholder="Mobile no" runat="server" />
                        </div>
                        <div style="width: 200px;" class="m-2">
                            <asp:TextBox ID="txtEmail_YS" class="form-control" placeholder="Email" runat="server" />
                        </div>
                    </div>
                    <div class="input-group-append">
                        <div class="m-2" style="text-align: left; width: 200px">
                            <asp:TextBox ID="txtPassword_YS" TextMode="Password" class="form-control" placeholder="Password" runat="server" />
                        </div>
                        <div style="width: 200px;" class="m-2">
                            <asp:TextBox ID="txtRetypepassword_YS" TextMode="Password" class="form-control" placeholder="Retype password" runat="server" />
                        </div>
                    </div>

                    <div class="form-group">
                      <asp:Label runat="server" for="exampleInputFile">File input</asp:Label>
                        <div class="input-group">
                            <div class="custom-file">
                                <asp:FileUpload ID="exampleInputFile" name="exampleInputFile" class="custom-file-input" runat="server" />
                                <asp:Label ID="Label2" runat="server" class="custom-file-label" for="exampleInputFile">Choose file</asp:Label>
                                <%--<label class="custom-file-label" for="exampleInputFile">Choose file</label>--%>
                            </div>
                            <div class="input-group-append">
                                <span class="input-group-text" id="">Upload</span>
                            </div>
                        </div>
                    </div>





                    <div class="input-group-append">
                        <div style="width: 200px;" class="m-2">
                            <asp:TextBox ID="TextBox2" TextMode="Password" class="form-control" placeholder="Retype password" runat="server" />
                        </div>
                    </div>


                    <div class="input-group-append">
                        <div class="m-2" style="text-align: left; width: 200px">
                            <asp:TextBox ID="txtStorename_YS" class="form-control" placeholder="Store name" runat="server" />
                        </div>
                        <div style="width: 200px;" class="m-2">
                            <asp:TextBox ID="txtStorecategory_YS" class="form-control" placeholder="Store category" runat="server" />
                        </div>
                    </div>

                    <div class="input-group-append">
                        <div class="m-2" style="text-align: left; width: 200px">
                            <asp:TextBox ID="txtHelplineno_YS" class="form-control" placeholder="Helpline no" runat="server" />
                        </div>
                        <div style="width: 200px;" class="m-2">
                            <asp:DropDownList ID="ddtVouchermode_YS" class="form-control" runat="server">
                                <asp:ListItem Value="SelectVouchermode">Select Voucher Mode</asp:ListItem>
                                <asp:ListItem Value="Quickmode">Quick mode</asp:ListItem>
                                <asp:ListItem Value="Detailmode">Detail mode</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="input-group-append col-7">
                            <div class="icheck-primary d-inline m-2">
                                <asp:CheckBox ID="checkboxPrimary3" runat="server" value="agree" />

                                <label for="checkboxPrimary3">
                                    I agree to the <a href="#">terms</a>
                                </label>
                            </div>
                        </div>
                        <div class="col-4">
                            <asp:Button ID="btnRegister_YS" class="btn btn-primary btn-block" UseSubmitBehavior="false" runat="server" Text="Register" />
                        </div>
                    </div>


                    <div class="social-auth-links text-center">
                    </div>

                    <a href="login.html" class="text-center">I already have a membership</a>
                </div>
                <!-- /.form-box -->
            </div>
            <!-- /.card -->
        </div>
    </form>
    <!-- /.register-box -->
<!-- jQuery -->
<script src="../../plugins/jquery/jquery.min.js"></script>
<!-- Bootstrap 4 -->
<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<!-- bs-custom-file-input -->
<script src="../../plugins/bs-custom-file-input/bs-custom-file-input.min.js"></script>
<!-- AdminLTE App -->
<script src="../../dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="../../dist/js/demo.js"></script>
<script type="text/javascript">
    $(document).ready(function () {
        bsCustomFileInput.init();
    });
</script>
    <!-- Bootstrap 4 -->
    <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>
</body>
</html>
