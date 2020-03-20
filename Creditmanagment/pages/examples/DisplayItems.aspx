<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="DisplayItems.aspx.cs" Inherits="Creditmanagment.pages.examples.DisplayItems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row mb-3">
            <div class="col-sm-6">
                <h1>Display Items</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage.aspx">Home</a></li>
                    <li class="breadcrumb-item active"><a href="DisplayItems.aspx">Display Items</a></li>
                </ol>
            </div>
        </div>

        <div class="col-md-3">
            <div class="card card-info">
                <div class="card-header">
                    <h3 class="card-title">Display Items</h3>
                </div>
                <!-- /.card-header -->
                <!-- form start -->
                <form class="form-horizontal" runat="server" id="form1">
                    <div class="card-body">
                        <div class="form-group row">
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%; padding:10px 0px 0px 30px">
                                <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                                <asp:GridView ID="gdDisplayUsers" runat="server" CellPadding="20" >
                                </asp:GridView>
                                <br />
                            </div>
                        </div>
                    </div>
            </div>
        </div>
        <!-- /.card -->
        </form>
    </div>
</asp:Content>
