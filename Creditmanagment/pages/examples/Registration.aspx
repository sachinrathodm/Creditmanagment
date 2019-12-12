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
        <div class="register-box">
            <div class="register-logo">
                <a href="../../index.html"><b>Admin</b>LTE</a>
            </div>

            <div class="card">
                <div class="card-body register-card-body">
                    <p class="login-box-msg">Register a new membership</p>

                    <form action="../../index.html" runat="server">
                      
                      
                        <div class="input-group mb-3" >
                            <%--<input type="text" class="form-control" placeholder="First name">--%>
                            <asp:TextBox ID="txtFirstname_YS" class="form-control" placeholder="First name" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-user"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="text" class="form-control" placeholder="Last name">--%>
                            <asp:TextBox ID="txtLastname_YS" class="form-control" placeholder="Last name" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-user"></span>--%>
                                </div>
                            </div>
                        </div>
                       
                        <div class="input-group mb-3">
                            <%--<input type="text" class="form-control" placeholder="Store name">--%>
                            <asp:TextBox ID="txtStorename_YS" class="form-control" placeholder="Store name" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-user"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="text" class="form-control" placeholder="Store category">--%>
                            <asp:TextBox ID="txtStorecategory_YS" class="form-control" placeholder="Store category" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-user"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="text" class="form-control" placeholder="Mobile no">--%>
                            <asp:TextBox ID="txtMobileno_YS" class="form-control" placeholder="Mobile no" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-user"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="email" class="form-control" placeholder="Email">--%>
                            <asp:TextBox ID="txtEmail_YS" class="form-control" placeholder="Email" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-envelope"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="password" class="form-control" placeholder="Password">--%>
                            <asp:TextBox ID="txtPassword_YS" TextMode="Password" class="form-control" placeholder="Password" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-lock"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="password" class="form-control" placeholder="Retype password">--%>
                            <asp:TextBox ID="txtRetypepassword_YS" TextMode="Password" class="form-control" placeholder="Retype password" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-lock"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="password" class="form-control" placeholder="Retype password">--%>
                            <asp:TextBox ID="txtAddress_YS" class="form-control" placeholder="Address" TextMode="MultiLine" runat="server"></asp:TextBox>
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-lock"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="email" class="form-control" placeholder="Helpline no">--%>
                            <asp:TextBox ID="txtHelplineno_YS" class="form-control" placeholder="Helpline no" runat="server" />
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-envelope"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="input-group mb-3">
                            <%--<input type="email" class="form-control" placeholder="Helpline no">--%>
                            <asp:DropDownList ID="ddtVouchermode_YS" class="form-control" runat="server">
                                <asp:ListItem Value="SelectVouchermode">Select Voucher Mode</asp:ListItem>
                                <asp:ListItem Value="Quickmode">Quick mode</asp:ListItem>
                                <asp:ListItem Value="Detailmode">Detail mode</asp:ListItem>
                            </asp:DropDownList>
                            <div class="input-group-append">
                                <div class="input-group-text">
                                    <%--<span class="fas fa-envelope"></span>--%>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-8">
                                <div class="icheck-primary">
                                    <%--<input type="checkbox" id="agreeTerms" name="terms" value="agree">--%>
                                    <asp:CheckBox ID="chkagreeTerms_YS" runat="server" value="agree" />
                                   
                                  <label for="agreeTerms">
                                        I agree to the <a href="#">terms</a>
                                    </label>
                                </div>
                            </div>
                            <!-- /.col -->
                            <div class="col-4">
                                <%--<button type="submit" class="btn btn-primary btn-block">Register</button>--%>
                                <asp:Button ID="btnRegister_YS" EnableViewState="true" UseSubmitBehavior="false" runat="server" Text="Register" class="btn btn-primary btn-block" />
                            </div>
                            <!-- /.col -->
                        </div>
                    </form>

                    <div class="social-auth-links text-center">
                    </div>

                    <a href="login.html" class="text-center">I already have a membership</a>
                </div>
                <!-- /.form-box -->
            </div>
            <!-- /.card -->
        </div>
        <!-- /.register-box -->

        <!-- jQuery -->
        <script src="../../plugins/jquery/jquery.min.js"></script>
        <!-- Bootstrap 4 -->
        <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
        <!-- AdminLTE App -->
        <script src="../../dist/js/adminlte.min.js"></script>
    </body>
</html>

