<%@ Page Title="" Language="C#" MasterPageFile="~/UserBlankPage.Master" AutoEventWireup="true" CodeBehind="DisplayStoresList_User.aspx.cs" Inherits="Creditmanagment.pages.examples.DisplayStoresList_User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-lg-5">
                <div class="card card-info">
                    <div class="card-header">
                        <h3 class="card-title">Stores List</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    <form class="form-horizontal" runat="server" id="form1">
                </div>
                    <!-- Main content -->
                        <div class="row">
                            <div class="col-10">
                                <div class="card">
                                    
                                    <!-- /.card-header -->
                                    <div class="card-body">
                                        <asp:GridView ID="gdDisplayStores" runat="server"></asp:GridView>
                                    </div>
                                    <!-- /.card-body -->
                                </div>
                            </div>
                        </div>
                </div>
           
            <!-- /.card -->
    
    <!-- /.card -->
  </form>
</asp:Content>
