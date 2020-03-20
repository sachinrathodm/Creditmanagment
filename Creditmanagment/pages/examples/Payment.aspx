<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="Creditmanagment.pages.examples.Payment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-6">
        <h1>Payment</h1>
    </div>
    <div class="col-sm-6">
        <ol class="breadcrumb float-sm-right">
            <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
            <li class="breadcrumb-item active"><a href="Payment.aspx">Payment</a></li>
        </ol>
    </div>

    <div class="col-lg-5">
        <div class="card card-info">
            <div class="card-header">
                <h3 class="card-title">Payment</h3>
            </div>
            <!-- /.card-header -->
            <!-- form start -->
            <form class="form-horizontal" runat="server" id="form1">
                <div class="card-body">
                    <div class="form-group row">
                        <label class="col-sm-4 col-form-label">Select Customer Name</label>
                        <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                            <asp:DropDownList ID="ddCustomerName_YS" runat="server" class="form-control" ToolTip="Select Customer Name" AutoPostBack="true" ></asp:DropDownList><br />
                        </div>

                        <label class="col-sm-4 col-form-label">Pay RS. </label>
                        <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                            <asp:TextBox ID="txtPayrs_YS" runat="server" class="form-control" ToolTip="Enter Rupees" TextMode="Number"></asp:TextBox><br />
                        </div>
                    </div>
                  </div>
                    <!-- /.card-body -->
                    <div class="card-footer">
                        <asp:Button ID="btnCancle_YS" runat="server" class="btn btn-default float-right" Text="Cancle"/>
                        <asp:Button ID="btnPayment_YS" runat="server" type="submit" class="btn btn-info" Text="Payment" />
                    </div>
                    <!-- /.card-footer -->
                </div>
        </div>
    </div>
    <%-- <div class="content-wrapper col-lg-4">
                    <!-- Main content -->
                    <section class="content">
                        <div class="row">
                            <div class="col-10">
                                <div class="card">
                                    <div class="card-header">
                                        <h3 class="card-title">Items</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class="card-body">
                                       <asp:Label ID="lblnullmessage"  runat="server" Visible="false"  class="col-sm-4 col-form-label">Qty</asp:Label>
                                        <asp:GridView ID="gdUserRequest" runat="server" CellPadding="10" AutoPostBack="true"></asp:GridView>
                                    </div>
                                    <!-- /.card-body -->
                                </div>
                            </div>
                        </div>
                      </section>
                </div>
    --%>
    <!-- /.card -->

    <!-- /.card -->
    </form>
</asp:Content>
