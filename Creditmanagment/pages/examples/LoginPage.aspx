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
    <link rel="stylesheet" href="../../dist/css/textboxvalidation.css">
   <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">

    <link rel="stylesheet" href="../../dist/css/textboxvalidation.css">

    <link rel="stylesheet" href="/path/to/dist/css/bootstrapValidator.min.css" />

    <script type="text/javascript" src="../../plugins/jquery/jquery.min.js"></script>
    <script type="text/javascript" src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>

</head>
<body class="hold-transition login-page">
    <form runat="server" method="post" id="form1">
        <div class="login-box">
            <div class="login-logo">
                <a href="../../indexhome.aspx"><b>Credit </b>Managment</a>
            </div>
            <!-- /.login-logo -->
            <div class="card mr-5 ml-5 aspNetHidden">
                <div class="card-body login-card-body">
                    <p class="login-box-msg">Sign in to start your session</p>

                    <div class="input-group-append">
                        <div style="width: 360px;" class="m-2 form-group">
                            <asp:TextBox ID="txtEmail_YS" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="input-group-append">
                        <div style="width: 360px;" class="m-2 form-group">
                            <asp:TextBox ID="txtPassword_YS" class="form-control" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
                        </div>
                    </div>
                    <div>
                        <asp:Label ID="lblIncorrect_ps_YS" runat="server" class="form-control" ClientIDMode="Static" Visible="false">Hello</asp:Label>
                        <br />
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
                            <asp:Button ID="btnLogin_YS" class="btn btn-primary btn-block" UseSubmitBehavior="false" runat="server" Text="Sign In" OnClick="btnLogin_YS_Click" />

                        </div>
                        <!-- /.col -->
                    </div>


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
    </form>
    <!-- /.login-box -->

    
 


    <!-- jQuery -->
    <script src="../../plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>


    <!-- jQuery validator -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-validator/0.5.3/js/bootstrapValidator.js"></script>
    <script src="../../validator.js"></script>

</body>
</html>

