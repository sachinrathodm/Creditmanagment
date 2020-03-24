<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Invoice_print_User_Store.aspx.cs" Inherits="Creditmanagment.pages.examples.Invoice_print_User_Store" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Credit Management | Blank Page</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">


    <!-- Font Awesome -->
    <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- overlayScrollbars -->
    <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
    <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">


    <link rel="stylesheet" href="../../dist/css/textboxvalidation.css">

    <link rel="stylesheet" href="/path/to/dist/css/bootstrapValidator.min.css" />

    <script type="text/javascript" src="../../plugins/jquery/jquery.min.js"></script>
    <script type="text/javascript" src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript">  
        function alertMessage() {
            alert('Register Succesfully');
        }
    </script>

    <%--    <asp:ContentPlaceHolder ID="head" runat="server">
    </asp:ContentPlaceHolder>--%>
</head>
<body class="hold-transition sidebar-mini">

    <!-- Site wrapper -->
    <div class="wrapper">
        <!-- Navbar -->
        <nav class="main-header navbar navbar-expand navbar-white navbar-light">
            <!-- Left navbar links -->
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" data-widget="pushmenu" href="#"><i class="fas fa-bars"></i></a>
                </li>
                <li class="nav-item d-none d-sm-inline-block">
                    <a href="../../IndexHomePage.aspx" class="nav-link">Home</a>
                </li>
                <li class="nav-item d-none d-sm-inline-block">
                    <a href="#" class="nav-link">Contact</a>
                </li>
            </ul>

            <!-- SEARCH FORM -->
            <form class="form-inline ml-2">
                <div class="input-group input-group-sm">
                    <input class="form-control form-control-navbar" type="search" placeholder="Search" aria-label="Search">
                    <div class="input-group-append">
                        <button class="btn btn-navbar" type="submit">
                            <i class="fas fa-search"></i>
                        </button>
                    </div>
                </div>
            </form>

            <!-- Right navbar links -->
            <ul class="navbar-nav ml-auto">
                <li>
                    <%if (Session["User_ID"] != null)
                        {%>

                    <a href="../../pages/examples/LogoutPage.aspx">
                        <label id="logout_YS" runat="server">Logout</label>
                    </a>
                    <%} %>
                    <%else
                        {%>
                    <a href="pages/examples/LoginPage.aspx">
                        <label id="login_YS" runat="server">Login</label>
                    </a>
                    <%} %>
                </li>

                <!-- Notifications Dropdown Menu -->
                <li class="nav-item dropdown">
                    <a class="nav-link" data-toggle="dropdown" href="#">
                        <i class="far fa-bell"></i>
                        <asp:Label ID="lbltotalrequest_YS" runat="server" class="badge badge-warning navbar-badge"></asp:Label>
                        <%--<span class="badge badge-warning navbar-badge">15</span>--%>
                    </a>
                    <div class="dropdown-menu dropdown-menu-lg dropdown-menu-right">
                        <span class="dropdown-item dropdown-header">15 Notifications</span>
                        <div class="dropdown-divider"></div>
                        <a href="#" class="dropdown-item">
                            <i class="fas fa-envelope mr-2"></i>4 new messages
           
                                    <span class="float-right text-muted text-sm">3 mins</span>
                        </a>
                        <div class="dropdown-divider"></div>
                        <a href="../../pages/examples/AcceptRequest.aspx" class="dropdown-item">
                            <i class="fas fa-users mr-2"></i>
                            <asp:Label ID="lblgetrequest_YS" runat="server"></asp:Label>
                            <%--<span class="float-right text-muted text-sm">12 hours</span>--%>
                        </a>
                        <div class="dropdown-divider"></div>
                        <a href="#" class="dropdown-item">
                            <i class="fas fa-file mr-2"></i>3 new reports
                                    <span class="float-right text-muted text-sm">2 days</span>
                        </a>
                        <div class="dropdown-divider"></div>
                        <a href="#" class="dropdown-item dropdown-footer">See All Notifications</a>
                    </div>
                </li>

                <li class="nav-item">
                    <a class="nav-link" data-widget="control-sidebar" data-slide="true" href="#">
                        <i class="fas fa-th-large"></i>
                    </a>
                </li>
            </ul>
        </nav>
        <!-- /.navbar -->

        <!-- Main Sidebar Container -->
        <aside class="main-sidebar sidebar-dark-primary elevation-4">
            <!-- Brand Logo -->

            <a href="../../IndexHomePage.aspx" class="brand-link">
                <img src="../../dist/img/CM_LOGO.png"
                    alt="Credit Management Logo"
                    class="brand-image img-circle elevation-3"
                    style="opacity: .8">
                <span class="brand-text font-weight-light">Credit Management</span>
            </a>

            <!-- Sidebar -->
            <div class="sidebar">
                <!-- Sidebar user (optional) -->
                <div class="user-panel mt-3 pb-3 mb-3 d-flex">
                    <div class="image">
                        <asp:Image ID="imgStoremg_YS" runat="server" class="img-circle elevation-2" alt="Store Image" />
                        <%--<img src="../../dist/img/user2-160x160.jpg" runat="server" id="imgStoremg_YS" class="img-circle elevation-2" alt="Store Image">--%>
                    </div>
                    <div class="info">
                        <a href="#" class="d-block">
                            <asp:Label ID="lblName_YS" runat="server"></asp:Label></a>
                    </div>
                </div>

                <!-- Sidebar Menu -->
                <nav class="mt-2">
                    <ul class="nav nav-pills nav-sidebar flex-column" data-widget="treeview" role="menu" data-accordion="false">
                        <!-- Add icons to the links using the .nav-icon class
               with font-awesome or any other icon font library -->
                        <li class="nav-item has-treeview">
                            <a href="../../IndexHomePage.aspx" class="nav-link">
                                <i class="nav-icon fas fa-tachometer-alt"></i>
                                <p>
                                    Dashboard
               
                                            <i class="right fas fa-angle-left"></i>
                                </p>
                            </a>
                            <ul class="nav nav-treeview">
                                <li class="nav-item">
                                    <a href="../../IndexHomePage.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Home</p>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class="nav-header">EXAMPLES</li>
                        <li class="nav-item has-treeview">
                            <a href="#" class="nav-link">
                                <i class="nav-icon fas fa-book"></i>
                                <p>
                                    Pages
                <i class="fas fa-angle-left right"></i>
                                </p>
                            </a>
                            <ul class="nav nav-treeview">
                                <% Boolean iss = Convert.ToBoolean(Session["isstorekeeper"].ToString());
                                    if (iss)
                                    {%>
                                <li class="nav-item">
                                    <a href="../../pages/examples/Invoice.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Invoice</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../examples/contacts.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Contacts</p>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class="nav-item has-treeview menu-open">
                            <a href="#" class="nav-link active">
                                <i class="nav-icon far fa-plus-square"></i>
                                <p>
                                    Extras
                                   
                                    <i class="fas fa-angle-left right"></i>
                                </p>
                            </a>
                            <ul class="nav nav-treeview">
                                <% Boolean a = Convert.ToBoolean(Session["isquickmode"].ToString());
                                    if (!a)
                                    {%>
                                <li class="nav-item">
                                    <a href="../../pages/examples/AddItems.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Add Item</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/DisplayItems.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Display Items</p>
                                    </a>
                                </li>
                                <%}%>
                                <li class="nav-item">
                                    <a href="../../pages/examples/Invoice.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Invoice</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/Add_Invoice.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Add Invoice</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/Payment.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Payment</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/AcceptRequest.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Accept Request</p>
                                    </a>
                                </li>
                                <% }%>
                                <%else
                                    {%>
                                <li class="nav-item">
                                    <a href="../../pages/examples/SendRequestUser.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Send Request</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/invoice_User.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Invoice</p>
                                    </a>
                                </li>
                                <%} %>

                                <% if (Session["User_ID"] != null)
                                    {%>
                                <li class="nav-item">
                                    <a href="../../pages/examples/LoginPage.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Logout</p>
                                    </a>
                                </li>
                                <%} %>
                                <%else
                                    { %>
                                <li class="nav-item">
                                    <a href="../../pages/examples/LoginPage.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Login</p>
                                    </a>
                                </li>
                                <%} %>
                                <li class="nav-item">
                                    <a href="../../pages/examples/Registration.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Register</p>
                                    </a>
                                </li>
                                <li class="nav-item">
                                    <a href="../../pages/examples/ForgotPasswordPage.aspx" class="nav-link">
                                        <i class="far fa-circle nav-icon"></i>
                                        <p>Forgot Password</p>
                                    </a>
                                </li>
                            </ul>
                </nav>
                <!-- /.sidebar-menu -->
            </div>
            <!-- /.sidebar -->
        </aside>

        <!-- Content Wrapper. Contains page content -->
        <div class="content-wrapper">

            <!-- Content Header (Page header) -->
            <section class="content-header">
                <div class="container-fluid">
                    <div class="row mb-2">
                        <div class="col-sm-6">
                            <h1>Invoice</h1>
                        </div>
                        <div class="col-sm-6">
                            <ol class="breadcrumb float-sm-right">
                                <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
                                <li class="breadcrumb-item active"><a href="Invoice.aspx">Invoice</a></li>
                                <li class="breadcrumb-item active"><a href="Invoice_print_User_Store.aspx">Invoice print</a></li>
                            </ol>
                        </div>
                    </div>

                    <!-- Main content -->
                    <div class="invoice p-3 mb-3">
                        <!-- title row -->
                        <div class="row">
                            <div class="col-12">
                                <h4>
                                    <i class="fas fa-globe"></i>
                                    <asp:Label ID="lblStorename_YS" runat="server" Text=""></asp:Label>, Inc.
                    <small class="float-right">Date:
                        <asp:Label ID="lblDate_YS" runat="server" Text=""></asp:Label></small>
                                </h4>
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- info row -->
                        <div class="row invoice-info">
                            <div class="col-sm-4 invoice-col">
                                From
                  <address>
                      <strong>
                          <asp:Label ID="lblStorekeepname_YS" runat="server" Text=""></asp:Label>, Inc.</strong><br>
                      <asp:Label ID="lblAddress_YS" runat="server" Text=""></asp:Label>
                  </address>
                            </div>
                            <!-- /.col -->
                            <div class="col-sm-4 invoice-col">
                                To
                  <address>
                      <strong>
                          <asp:Label ID="lblCustomername_YS" runat="server" Text=""></asp:Label></strong><br>
                      <asp:Label ID="lblCustomerAddress_YS" runat="server" Text=""></asp:Label>
                  </address>
                            </div>
                            <!-- /.col -->
                            <div class="col-sm-4 invoice-col">
                                <b>Invoice &nbsp;</b><asp:Label ID="lblInvoiceid_YS" runat="server" Text=""></asp:Label><br>
                                <br>
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.row -->

                        <!-- Table row -->
                        <div class="row">
                            <div class="col-12 table-responsive">
                                <table class="table">
                                    <tr>
                                        <td>
                                            <asp:Literal ID="ltVoucherdetail_YS" runat="server"></asp:Literal></td>
                                    </tr>
                                </table>
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.row -->

                        <div class="row">
                            <!-- accepted payments column -->
                            <div class="col-6">
                                <p class="lead">Payment Methods:</p>
                                <img src="../../dist/img/credit/visa.png" alt="Visa">
                                <img src="../../dist/img/credit/mastercard.png" alt="Mastercard">
                                <img src="../../dist/img/credit/american-express.png" alt="American Express">
                                <img src="../../dist/img/credit/paypal2.png" alt="Paypal">

                                <p class="text-muted well well-sm shadow-none" style="margin-top: 10px;">
                                    Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles, weebly ning heekya handango imeem
                    plugg
                    dopplr jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.
                                </p>
                            </div>
                            <!-- /.col -->
                            <div class="col-6">
                                <p class="lead">Amount Due 2/22/2014</p>

                                <div class="table-responsive">
                                    <table class="table">
                                        <tr>
                                            <th>Total:</th>
                                            <td>
                                                <asp:Label ID="lblTotalamount_YS" runat="server" Text=""></asp:Label></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                            <!-- /.col -->
                        </div>
                        <!-- /.row -->

                        <!-- this row will not appear when printing -->
                        <div class="row no-print">
                            <div class="col-12">
                                <a href="Invoice_Print_Click_User.aspx" target="_blank" class="btn btn-default"><i class="fas fa-print"></i>Print</a>
                                <button type="button" class="btn btn-success float-right">
                                    <i class="far fa-credit-card"></i>Submit
                    Payment
                                </button>
                                <button type="button" class="btn btn-primary float-right" style="margin-right: 5px;">
                                    <i class="fas fa-download"></i>Generate PDF
                                </button>
                            </div>
                        </div>
                    </div>
                    <!-- /.invoice -->
                </div>
                <!-- /.col -->
            </section>
        </div>
        <!-- /.row -->
    </div>
    <!-- /.container-fluid -->
    <!-- /.content -->

    <!-- /.content-wrapper -->
    <footer class="main-footer no-print">
        <div class="float-right d-none d-sm-block">
            <b>Version</b> 3.0.1
        </div>
        <strong>Copyright &copy; 2014-2019 <a href="http://CreditManagement">Credit Management</a>.</strong> All rights
    reserved.
    </footer>

    <!-- Control Sidebar -->
    <aside class="control-sidebar control-sidebar-dark">
        <!-- Control sidebar content goes here -->
    </aside>
    <!-- /.control-sidebar -->
    <!-- ./wrapper -->

    <!-- jQuery -->
    <script src="../../plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="../../dist/js/demo.js"></script>
</body>
</html>

