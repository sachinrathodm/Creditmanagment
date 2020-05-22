<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="Invoice.aspx.cs" Inherits="Creditmanagment.pages.examples.Invoice" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Invoice</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
                    <li class="breadcrumb-item active"><a href="Invoice.aspx">Invoice</a></li>
                </ol>
            </div>
        </div>
        <div class="col-sm-6">
            <div class="card card-info">
                <form class="form-horizontal" runat="server" id="form1">
                    <div class="card-header">
                        <h3 class="card-title">Display Invoice</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    <div class="card-body">
                        <div class="form-group row">
                            <label class="col-sm-4 col-form-label">Select &nbsp;Customer&nbsp; Name</label>
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                                <asp:DropDownList ID="ddCusomerName_YS" runat="server" class="form-control"></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
                    <div class="card-footer">
                        <%--<button id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>--%>
                        <asp:Button ID="btnCancel_YS" runat="server" Text="Cancel" class="btn btn-default float-right" />
                        <asp:Button ID="btnOk_YS" runat="server" type="submit" class="btn btn-info" Text="Ok" />
                    </div>
            </div>
        </div>

        <!-- /.card-footer -->
        <div class="content-wrapper col-lg-9">
            <!-- Main content -->
            <div class="row">
                <div class="col-10">
                    <div class="card">
                        <div class="card-header">
                            <h3 class="card-title">Invoic</h3>
                        </div>
                        <!-- /.card-header -->
                        <div class="card-body">
                            <label id="lblNullmessega" visible="false" runat="server" text="" class="col-sm-4 col-form-label"></label>
                             <asp:GridView ID="gdInvoic_YS" runat="server" DataKeyNames="Voucher_ID"  CellPadding="10" AutoPostBack="true" AutoGenerateColumns="false" OnRowCommand="SuppliersProducts_RowCommand">
                                <Columns>
                                  <asp:ButtonField ButtonType="Button" HeaderText="Create invoice" CommandName="Voucher_ID" Text="invoice" />
                                  <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                  <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                                  <asp:BoundField DataField="Voucher_Date" HeaderText="Voucher_Date" SortExpression="Voucher_Date" />
                                </Columns>
                            </asp:GridView>
                        </div>
                        <!-- /.card-body -->
                    </div>
                </div>
            </div>
        </div>
        </form>
    </div>
</asp:Content>
