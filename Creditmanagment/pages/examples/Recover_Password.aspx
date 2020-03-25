<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recover_Password.aspx.cs" Inherits="Creditmanagment.pages.examples.Recover_Password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<!DOCTYPE html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Credit Management | Recover Passwors</title>
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
                <b>Credit </b>Managment
            </div>
            <!-- /.login-logo -->
            <div class="card mr-5 ml-5 aspNetHidden">
                <div class="card-body login-card-body">
                    <p class="login-box-msg">You forgot your password? Here you can easily retrieve a new password.</p>

                    <div class="input-group-append">
                        <div style="width: 360px;" class="m-2 form-group">
                            <asp:TextBox ID="txtPassword_YS" TextMode="Password" class="form-control" placeholder="New Password" runat="server"></asp:TextBox>
                        </div>
                    </div>
                    <div class="input-group mb-3">
                        <div style="width: 360px;" class="m-2 form-group">
                            <asp:TextBox ID="txtRetypepassword_YS" TextMode="Password" class="form-control" placeholder="Confirm Password" runat="server"></asp:TextBox>
                      
                          <asp:Label ID="lblcheck_YS" runat="server" ForeColor="PaleVioletRed" ClientIDMode="Static" Visible="true"></asp:Label>
                        </div>
                    </div>
                    <div class="row-1">
                        <div class="row">
                            <div class="col-12">
                                <asp:Button ID="btnsubmit" runat="server" Text="Change password" type="submit" class="btn btn-primary btn-block" />
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.col -->
                    </div>

                    <!-- /.social-auth-links -->
    <p class="mt-3 mb-1">
        <a href="LoginPage.aspx">Login</a>
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
