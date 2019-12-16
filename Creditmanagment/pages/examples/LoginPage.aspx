<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Creditmanagment.pages.examples.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Credit Management | Log in</title>
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
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="../../index.html"><b>Credit </b>Managment</a>
        </div>
        <!-- /.login-logo -->
        <div class="card mr-5 ml-5">
            <div class="card-body login-card-body">
                <p class="login-box-msg">Sign in to start your session</p>

                <form runat="server" method="post">
                    <div class="input-group mb-3">
                        <asp:TextBox ID="txtEmail_YS" runat="server" type="email" class="form-control" placeholder="Email"></asp:TextBox>
                        <%--<input type="email" class="form-control" placeholder="Email">--%>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>
                            </div>
                        </div>
                    </div>
                    <div class="input-group mb-3">
                        <asp:TextBox ID="TextBox1" runat="server" type="password" class="form-control" placeholder="Password"></asp:TextBox>
                        <%--<input type="password" class="form-control" placeholder="Password">--%>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-8">
                            <%--<div class="icheck-primary">
              <input type="checkbox" id="remember">
              <label for="remember">
                Remember Me
              </label>
            </div>--%>
                            <div class="input-group-append col-15">
                                <div class="icheck-primary d-inline m-2">
                                    <asp:CheckBox ID="chkAgree_YS" runat="server" value="agree" />
                                    <label for="chkAgree_YS" id="lblAgree" runat="server">
                                        Remember Me 
                                    </label>
                                </div>
                            </div>
                        </div>
                        <!-- /.col -->
                        <div class="col-4">
                            <%--<button type="submit" class="btn btn-primary btn-block">Sign In</button>--%>
                            <asp:Button ID="btnLogin_YS" class="btn btn-primary btn-block" UseSubmitBehavior="false" runat="server" Text="Sign In" />

                        </div>
                        <!-- /.col -->
                    </div>
                </form>

                <!-- /.social-auth-links -->

                <p class="mb-1">
                    <a href="ForgotPasswordPage.aspx">I forgot my password</a>
                </p>
                <p class="mb-0">
                    <a href="Registration.aspx" class="text-center">Register a new membership</a>
                </p>
            </div>
            <!-- /.login-card-body -->
        </div>
    </div>
    <!-- /.login-box -->

    <!-- jQuery -->
    <script src="../../plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>

</body>
</html>

