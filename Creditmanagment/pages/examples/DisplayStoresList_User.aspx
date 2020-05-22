<%@ Page Title="" Language="C#" MasterPageFile="~/UserBlankPage.Master" AutoEventWireup="true" CodeBehind="DisplayStoresList_User.aspx.cs" Inherits="Creditmanagment.pages.examples.DisplayStoresList_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Stores List</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage_User.aspx">Home</a></li>
                    <li class="breadcrumb-item active">Stores List</li>
                </ol>
            </div>
        </div>
        <div class="col-lg-6">
            <div class="card card-info">
                <div class="card-header">
                    <h3 class="card-title">Stores List</h3>
                </div>
                <!-- /.card-header -->
                <!-- form start -->
                <form class="form-horizontal" runat="server" id="form1">
                    <div class="card-body">
                        <div class="form-group row">
                            <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                               <asp:GridView ID="gdDisplayStores" style="text-align:center;width: 557px;" runat="server" CellPadding="7" AutoGenerateColumns="false">
                                  <Columns>
                                  <asp:BoundField HeaderText="Store Name" ItemStyle-Width="100px" DataField="Store_Name" />
                                  <asp:BoundField HeaderText="Keeper Name" DataField="StoreKeeperName" />
                                  <asp:BoundField HeaderText="Helpline No" DataField="Helpline_No" />
                                  <asp:BoundField HeaderText="Address" DataField="Address" />
                                </Columns>
                               </asp:GridView>
                            </div>
                        </div>
                    </div>
                    <!-- /.card-body -->
            </div>
        </div>
        </form>
    </div>
</asp:Content>
