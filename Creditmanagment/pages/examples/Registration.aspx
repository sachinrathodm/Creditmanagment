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

            <div class="card ml-5 mr-5 aspNetHidden">
                <div class="card-body register-card-body">
                    <p class="login-box-msg">Register a new membership</p>

                    <div class="input-group mb-3">
                        <%--<asp:RadioButton ID="rdStoreKeeper_YS" GroupName="a" AutoPostback="true" Checked="true" UseSubmitBehavior="false"  value="StoreKeeper" runat="server" OnCheckedChanged="rdStoreKeeper_YS_CheckedChanged" />
                                    StoreKeeper
                            <asp:RadioButton ID="rdCustomers_YS" GroupName="a" value="Cusomers" runat="server" />

                         Customers  --%>

                        <div class="ml-5 mr-5">
                            <asp:Label runat="server" class="btn bg-olive active" ID="hello">
                                <asp:RadioButton ID="rdStoreKeeper_YS" GroupName="a" AutoPostBack="true" value="StoreKeeper" runat="server" />
                                StoreKeeper
                            </asp:Label>
                            <asp:Label runat="server" class="btn bg-olive active" ID="Label1">
                                <asp:RadioButton ID="rdCustomers_YS" GroupName="a" AutoPostBack="true" value="Cusomers" runat="server" />
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

                    <div class="m-2">
                        <asp:Label ID="lblinputfile" runat="server" for="InputFile_YS">File input</asp:Label>
                        <div class="input-group">
                            <div class="custom-file">
                                <asp:FileUpload ID="InputFile_YS" class="custom-file-input" runat="server" />
                                <asp:Label ID="ltrinputfile" runat="server" class="custom-file-label" for="InputFile_YS">Choose Photo</asp:Label>
                                <%--<label class="custom-file-label" for="exampleInputFile">Choose file</label>--%>
                            </div>
                            <div class="input-group-append">
                                <asp:Label ID="lblUpload_YS" runat="server" class="input-group-text">Upload</asp:Label>
                                <%--<span class="input-group-text" id="">Upload</span>--%>
                            </div>
                        </div>
                    </div>

                    <div class="input-group-append">
                        <div style="width: 360px;" class="m-2">
                            <asp:TextBox ID="txtAddress_YS" class="form-control" placeholder="Address" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </div>
                    </div>

                    <div class="input-group-append">
                        <div style="width: 360px;" class="ml-2 mr-2 mt-2 mb-0">
                            <asp:TextBox ID="txtAdharcardno_YS" class="form-control" placeholder="Adhar card number" runat="server" />
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

                    <div class="ml-2 mr-2 mb-2 mt-0">
                        <!-- Date dd/mm/yyyy -->
                        <%--<div class="form-group">--%>
                        <asp:Label ID="lblBirthDate_YS" runat="server" Text="Label">Date Of Birth</asp:Label>
                        <%--<label>Date Of Birth</label>--%>
                        <div class="input-group">
                            <div class="input-group-prepend">
                                <asp:Label ID="ltrBirthdate_YS" runat="server" class="input-group-text"><i class="far fa-calendar-alt"></i></asp:Label>
                                <%--<span class="input-group-text"><i class="far fa-calendar-alt"></i></span>--%>
                            </div>
                            <asp:TextBox ID="txtBirthDate_YS" runat="server" class="form-control" data-inputmask-alias="datetime" data-inputmask-inputformat="dd/mm/yyyy" data-mask> </asp:TextBox>
                            <%--<input type="text" class="form-control" data-inputmask-alias="datetime" data-inputmask-inputformat="dd/mm/yyyy" data-mask>--%>
                        </div>
                        <!-- /.input group -->
                    </div>
                </div>
                <div class="row">
                    <div class="input-group-append col-7">
                        <div class="icheck-primary d-inline m-2">
                            <asp:CheckBox ID="chkAgree" runat="server" value="agree" />
                            <label for="chkAgree">
                                I agree to the <a href="#">terms</a>
                            </label>
                        </div>
                    </div>
                    <div class="col-4">
                        <asp:Button ID="btnRegister_YS" class="btn btn-primary btn-block" UseSubmitBehavior="false" runat="server" Text="Register" />
                    </div>
                </div>

            </div>

            <div class="social-auth-links text-center">
                <asp:Label ID="lblismember_YS" runat="server">
                  <a href="LoginPage.aspx" class="text-center">I already have a membership</a>
                </asp:Label>
            </div>


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
    <!-- Control Sidebar -->
    <aside class="control-sidebar control-sidebar-dark">
        <!-- Control sidebar content goes here -->
    </aside>
    <!-- /.control-sidebar -->
    </div>
    <!-- ./wrapper -->

    <!-- jQuery -->
    <script src="../../plugins/jquery/jquery.min.js"></script>
    <!-- Bootstrap 4 -->
    <script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Select2 -->
    <script src="../../plugins/select2/js/select2.full.min.js"></script>
    <!-- Bootstrap4 Duallistbox -->
    <script src="../../plugins/bootstrap4-duallistbox/jquery.bootstrap-duallistbox.min.js"></script>
    <!-- InputMask -->
    <script src="../../plugins/moment/moment.min.js"></script>
    <script src="../../plugins/inputmask/min/jquery.inputmask.bundle.min.js"></script>
    <!-- date-range-picker -->
    <script src="../../plugins/daterangepicker/daterangepicker.js"></script>
    <!-- bootstrap color picker -->
    <script src="../../plugins/bootstrap-colorpicker/js/bootstrap-colorpicker.min.js"></script>
    <!-- Tempusdominus Bootstrap 4 -->
    <script src="../../plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"></script>
    <!-- Bootstrap Switch -->
    <script src="../../plugins/bootstrap-switch/js/bootstrap-switch.min.js"></script>
    <!-- AdminLTE App -->
    <script src="../../dist/js/adminlte.min.js"></script>
    <!-- AdminLTE for demo purposes -->
    <script src="../../dist/js/demo.js"></script>
    <!-- Page script -->
    <script>
        $(function () {
            //Initialize Select2 Elements
            $('.select2').select2()

            //Initialize Select2 Elements
            $('.select2bs4').select2({
                theme: 'bootstrap4'
            })

            //Datemask dd/mm/yyyy
            $('#datemask').inputmask('dd/mm/yyyy', { 'placeholder': 'dd/mm/yyyy' })
            //Datemask2 mm/dd/yyyy
            $('#datemask2').inputmask('mm/dd/yyyy', { 'placeholder': 'mm/dd/yyyy' })
            //Money Euro
            $('[data-mask]').inputmask()

            //Date range picker
            $('#reservation').daterangepicker()
            //Date range picker with time picker
            $('#reservationtime').daterangepicker({
                timePicker: true,
                timePickerIncrement: 30,
                locale: {
                    format: 'MM/DD/YYYY hh:mm A'
                }
            })
            //Date range as a button
            $('#daterange-btn').daterangepicker(
                {
                    ranges: {
                        'Today': [moment(), moment()],
                        'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                        'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                        'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                        'This Month': [moment().startOf('month'), moment().endOf('month')],
                        'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
                    },
                    startDate: moment().subtract(29, 'days'),
                    endDate: moment()
                },
                function (start, end) {
                    $('#reportrange span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'))
                }
            )



            //Bootstrap Duallistbox
            $('.duallistbox').bootstrapDualListbox()



            $("input[data-bootstrap-switch]").each(function () {
                $(this).bootstrapSwitch('state', $(this).prop('checked'));
            });

        })
    </script>
</body>
</html>
