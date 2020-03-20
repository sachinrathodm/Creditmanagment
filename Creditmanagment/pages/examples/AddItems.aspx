<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="AddItems.aspx.cs" Inherits="Creditmanagment.pages.examples.AddItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Add Items</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
                    <li class="breadcrumb-item active"><a href="AddItems.aspx">Add Items</a></li>
                </ol>
            </div>
        </div>
        <div class="col-lg-5">
            <div class="card card-info">
                <div class="card-header">
                    <h3 class="card-title">Add Item Form</h3>
                </div>
                <!-- /.card-header -->
                <!-- form start -->
                <form class="form-horizontal" runat="server" id="form1">
                    <div class="card-body">
                        <div class="form-group row">
                            <label class="col-sm-4 col-form-label">Item Name</label>
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                <asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label class="col-sm-4 col-form-label">Rate</label>
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                <%--<input type="text" class="form-control" id="inputPassword3" placeholder="Rate">--%>
                                <asp:TextBox ID="txtRate_YS" class="form-control" placeholder="Rate" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
                    <div class="card-footer">
                        <%--<button id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>--%>
                        <asp:Button ID="btnCancel_YS" type="submit" runat="server" Text="Cancel" class="btn btn-default float-right" AutoPostBack="True" />
                        <asp:Button ID="btnAddItem_YS" runat="server" type="submit" class="btn btn-info" Text="ADD" />

                    </div>
                    <!-- /.card-footer -->
                </form>
            </div>
        </div>
    </div>
    <!-- /.card -->
</asp:Content>
