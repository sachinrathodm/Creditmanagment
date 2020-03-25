<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="DisplayUsersList.aspx.cs" Inherits="Creditmanagment.pages.examples.DisplayUsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Customres List</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
                    <li class="breadcrumb-item active"><a href="DisplayUsersList.aspx">Customres List</a></li>
                </ol>
            </div>
        </div>
        <div class="col-lg-4">
            <div class="card card-info">
                <div class="card-header">
                    <h3 class="card-title">Customres List</h3>
                </div>
                <!-- /.card-header -->
                <!-- form start -->
                <form class="form-horizontal" runat="server" id="form1">
                    <div class="card-body">
                        <div class="form-group row">
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 100%;">
                                <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                              <asp:GridView ID="gdDisplayUsers" runat="server" CellPadding="10"></asp:GridView>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
            </div>
        </div>
        </form>
    </div>
</asp:Content>
