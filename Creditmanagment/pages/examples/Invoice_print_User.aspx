<%@ Page Title="" Language="C#" MasterPageFile="~/UserBlankPage.Master" AutoEventWireup="true" CodeBehind="Invoice_print_User.aspx.cs" Inherits="Creditmanagment.pages.examples.Invoice_print_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <form runat="server">
  <!-- Content Header (Page header) -->
      <div class="container-fluid">
        <div class="row mb-2">
          <div class="col-sm-6">
            <h1>Invoice</h1>
          </div>
          <div class="col-sm-6">
            <ol class="breadcrumb float-sm-right">
              <li class="breadcrumb-item"><a href="../../IndexHomePage_User.aspx">Home</a></li>
              <li class="breadcrumb-item active"><a href="Invoice_User.aspx">Invoice</a></li>
              <li class="breadcrumb-item active"><a href="Invoice_print_User.aspx">Invoice print</a></li>
            </ol>
          </div>
        </div>

         <!-- Main content -->
            <div class="invoice p-3 mb-3">
              <!-- title row -->
              <div class="row">
                <div class="col-12">
                  <h4>
                    <i class="fas fa-globe"></i> <asp:Label ID="lblStorename_YS" runat="server" Text=""></asp:Label>, Inc.
                    <small class="float-right">
                      Date: <asp:Label ID="lblDate_YS" runat="server" Text=""></asp:Label></small>
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
                    <strong><asp:Label ID="lblCustomername_YS" runat="server" Text=""></asp:Label></strong><br>
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
                  <table class="table table-striped">
                    <tr>
                      <td><asp:Literal ID="ltVoucherdetail_YS" runat="server" ></asp:Literal></td>
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
                        <td><asp:Label ID="lblTotalamount_YS" runat="server" Text=""></asp:Label></td>
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
                  <a href="Invoice_Print_Click_User.aspx" target="_blank" class="btn btn-default"><i class="fas fa-print"></i> Print</a>
                  <button type="button" class="btn btn-success float-right"><i class="far fa-credit-card"></i> Submit
                    Payment
                  </button>
                  <asp:Button  runat="server" ID="btnGenratePDF"  class="btn btn-primary float-right" Text="Generate PDF" style="margin-right: 5px;"/>
                    
                  
                </div>
              </div>
            </div>
            <!-- /.invoice -->
          </div>
   </form>
  <!-- /.col -->
  <%--<script type="text/javascript"> 
  window.addEventListener("load", window.print());
</script>--%>
</asp:Content>
