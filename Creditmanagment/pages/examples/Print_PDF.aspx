<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Print_PDF.aspx.cs" Inherits="Creditmanagment.pages.examples.Print_PDF" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Credit Management | Invoice Detail Mode Page</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">


    <!-- Font Awesome -->
    <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">
    <!-- Ionicons -->
    <link rel="stylesheet" href="https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css">
    <!-- overlayScrollbars -->
    <%--<link rel="stylesheet" href="../../dist/css/adminlte.min.css">--%>
    <!-- Google Font: Source Sans Pro -->
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700" rel="stylesheet">
</head>
<body class="hold-transition sidebar-mini" runat="server">
    <table>
        <tr>
            <td>
                <div class="wrapper">
                    <!-- Content Wrapper. Contains page content -->
                    <section class="content-header">
                        <div class="container-fluid">
                            <!-- Main content -->
                            <div class="invoice p-3 mb-3">
                                <!-- title row -->
                                <div class="row">
                                    <div class="col-12">
                                        <h4>
                                            <asp:Table HorizontalAlign="Center" runat="server" Font-Size="X-Large">
                                                <asp:TableRow>
                                                    <asp:TableCell HorizontalAlign="Left" Height="50" Width="600">
                                                        <i class="fas fa-globe"></i>
                                                        <asp:Label ID="lblStorename_YS" runat="server" Text=""></asp:Label>, Inc.
                                                    </asp:TableCell>
                                                    <asp:TableCell HorizontalAlign="Right" Height="50" Width="400">
                                                        <small class="float-right">Date:
                        <asp:Label ID="lblDate_YS" runat="server" Text=""></asp:Label></small>
                                                    </asp:TableCell>
                                                </asp:TableRow>
                                            </asp:Table>
                                        </h4>
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- info row -->
                                <div class="row invoice-info">
                                    <asp:Table HorizontalAlign="Left" runat="server">
                                        <asp:TableRow>
                                            <asp:TableCell Width="300">
                                                <div class="col-sm-4 invoice-col">
                                                    From
                                                      <address>
                                                          <strong>
                                                              <asp:Label ID="lblStorekeepname_YS" runat="server" Text=""></asp:Label>, Inc.</strong><br>
                                                          <asp:Label ID="lblAddress_YS" runat="server" Text=""></asp:Label>
                                                      </address>
                                                </div>
                                            </asp:TableCell>
                                            <asp:TableCell Width="300">
                                                <!-- /.col -->
                                                <div class="col-sm-4 invoice-col">
                                                    To
                                                     <address>
                                                         <strong>
                                                             <asp:Label ID="lblCustomername_YS" runat="server" Text=""></asp:Label></strong><br>
                                                         <asp:Label ID="lblCustomerAddress_YS" runat="server" Text=""></asp:Label>
                                                     </address>
                                                </div>
                                            </asp:TableCell>
                                            <asp:TableCell Width="510" VerticalAlign="Top" HorizontalAlign="Right">
                                                <!-- /.col -->
                                                <div class="col-sm-4 invoice-col">
                                                    <b>Invoice &nbsp;</b><asp:Label ID="lblInvoiceid_YS" runat="server" Text=""></asp:Label><br>
                                                    <br>
                                                </div>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                    <!-- /.col -->
                                </div>
                                <!-- /.row -->

                                <!-- Table row -->

                                <div class="row">
                                    <div class="col-12 table-responsive">
                                        <hr style="margin: 140px 20px 10px 20px;" />
                                        <asp:Literal ID="ltVoucherdetail_YS" runat="server"></asp:Literal>
                                    </div>
                                    <!-- /.col -->
                                </div>
                                <!-- /.row -->

                                <div class="row">
                                    <!-- accepted payments column -->
                                    <asp:Table runat="server">
                                        <asp:TableRow>
                                            <asp:TableCell Style="width: 50%; font-family: 'Source Sans Pro','-apple-system','BlinkMacSystemFont','Segoe UI','Roboto','Helvetica Neue','Arial','sans-serif','Apple Color Emoji','Segoe UI Emoji','Segoe UI Symbol';">
                                       <div class="col-6">
                                                    <p class="lead" style="font-size: 1.25rem; font-weight: 300;">Payment Methods:</p>
                                                    <img style="vertical-align: middle;   border-style: none;" src="../../dist/img/credit/visa.png" alt="Visa">
                                                    <img style="vertical-align: middle;   border-style: none;" src="../../dist/img/credit/mastercard.png" alt="Mastercard">
                                                    <img style="vertical-align: middle;   border-style: none;" src="../../dist/img/credit/american-express.png" alt="American Express">
                                                    <img style="vertical-align: middle;   border-style: none;" src="../../dist/img/credit/paypal2.png" alt="Paypal">

                                                    <p class="text-muted well well-sm shadow-none" style="margin-top: 10px; width:80%; color: #6c757d!important; box-shadow: none!important;">
                                                        Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles, weebly ning heekya handango imeem plugg dopplr jibjab, movity jajah plickers sifteo edmodo ifttt zimbra.
                                                    </p>
                                         </div>
                                            </asp:TableCell>
                                            <asp:TableCell Style="width: 50%;font-size: 1.25rem; margin-top: 0; box-sizing: border-box; margin-bottom: 1rem; vertical-align: top; font-weight: 300;">

                                                <div class="col-6">
                                                    <p class="lead" style="">Amount Due 2/22/2014</p>

                                                    <div class="table-responsive">
                                                      <table class="table">
                                                            <tr>
                                                                <th style=" padding: .75rem; vertical-align: top; border-top: 1px solid #dee2e6;border-right-width:0px">Total:</th>
                                                                <td>
                                                                    <asp:Label ID="lblTotalamount_YS" runat="server" Text=""></asp:Label></td>
                                                            </tr>
                                                        </table>
                                                    </div>
                                                </div>
                                            </asp:TableCell>
                                        </asp:TableRow>
                                    </asp:Table>
                                </div>
                                <!-- /.row -->

                                <!-- this row will not appear when printing -->
                                <div class="row no-print">
                                    <div class="col-12">
                                        <a href="Print_pdf.aspx" class="btn btn-default" style="background-color: #f8f9fa;
    border-color: #ddd;
    color: #444;display: inline-block;
    font-weight: 400;text-align: center;
    vertical-align: middle;border: 1px solid transparent;
    padding: .375rem .75rem;
    font-size: 1rem;
    line-height: 1.5;
    border-radius: .25rem;
    transition: color .15s ease-in-out,background-color .15s ease-in-out,border-color .15s ease-in-out,box-shadow .15s ease-in-out;"><i class="fas fa-print"></i>Print</a>
                                        
                                    </div>
                                </div>
                            </div>
                            <!-- /.invoice -->
                        </div>
                        <!-- /.col -->
                    </section>
                    <!-- /.content-wrapper -->
                </div>
            </td>
        </tr>
    </table>
    <!-- /.container-fluid -->
    <!-- /.content -->
    <script type="text/javascript"> 
        window.addEventListener("load", window.print("_blank"), "width=600,height=400");
    </script>
</body>
</html>
