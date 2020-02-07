<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="AddItems.aspx.cs" Inherits="Creditmanagment.pages.examples.AddItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                    <button type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>
                </div>
                <!-- /.card-footer -->
            </form>
        </div>
    </div>
    <!-- /.card -->
</asp:Content>
