<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="DisplayUsersList.aspx.cs" Inherits="Creditmanagment.pages.examples.DisplayUsersList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="col-lg-5">
                <div class="card card-info">
                    <div class="card-header">
                        <h3 class="card-title">Customres List</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    <form class="form-horizontal" runat="server" id="form1">
                </div>
                    <!-- Main content -->
                        <div class="row">
                            <div class="col-7">
                                <div class="card">
                                    
                                    <!-- /.card-header -->
                                    <div class="card-body">
                                        <asp:GridView ID="gdDisplayUsers" runat="server"></asp:GridView>
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
