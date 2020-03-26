<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true" CodeBehind="Profile_Store.aspx.cs" Inherits="Creditmanagment.pages.examples.Profile_Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- .container-fluid -->
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Profile</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage_User.aspx">Home</a></li>
                    <li class="breadcrumb-item active">Storekeeper Profile</li>
                </ol>
            </div>
        </div>
    </div>
    <!-- /.container-fluid -->
    <!-- Main content -->
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <!-- Profile Image -->
                <div class="card card-primary card-outline">
                    <div class="card-body box-profile">
                        <div class="text-center">
                            <asp:Image ID="imgUserImage_YS" runat="server" class="img-circle elevation-2" alt="Store Image" Width="200" Height="200" />
                        </div>

                        <h3 class="profile-username text-center">
                            <asp:Label ID="lblDisplayname_YS" runat="server"></asp:Label></h3>

                        <ul class="list-group list-group-unbordered mb-3">
                            <%--<li class="list-group-item">
                                <b>Store Name</b> <a class="float-right">
                                    <asp:Label ID="lblStorename_YS" runat="server"></asp:Label></a>
                            </li>
                            <li class="list-group-item">
                                <b>Store Category</b> <a class="float-right">
                                    <asp:Label ID="lblStorecategory_YS" runat="server"></asp:Label></a>
                            </li>--%>
                            <li class="list-group-item">
                                <b>First Name</b> <a class="float-right">
                                    <asp:Label ID="lblFirstname_YS" runat="server"></asp:Label></a>
                            </li>
                            <li class="list-group-item">
                                <b>Last Name</b> <a class="float-right">
                                    <asp:Label ID="lblLastname_YS" runat="server"></asp:Label></a>
                            </li>
                            <li class="list-group-item">
                                <b>Mobile No.</b> <a class="float-right">
                                    <asp:Label ID="lblMobileno_YS" runat="server"></asp:Label></a>
                            </li>
                        </ul>

                        <a href="../../pages/examples/Edit_Profile_Store.aspx" class="btn btn-primary btn-block"><b>Edit</b></a>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
            <!-- Post -->
            <!-- About Me Box -->
            <div class="card card-primary col-5">
                <div class="card-header">
                    <h3 class="card-title">About Me</h3>
                </div>
                <!-- /.card-header -->
                <div class="card-body">
                   <strong><i class="fas fa-store mr-1"></i>Store Name </strong>
                    <p class="text-muted">
                        <asp:Label ID="lblStorename_YS" runat="server"></asp:Label>
                    </p>
                    <hr>
                  <strong><i class="fas fa-shopping-cart mr-1"></i>Store Category </strong>
                    <p class="text-muted">
                        <asp:Label ID="lblStorecategory_YS" runat="server"></asp:Label>
                    </p>
                    <hr>
                    <strong><i class="fas fa-envelope mr-1"></i>Email </strong>
                    <p class="text-muted">
                        <asp:Label ID="lblEmail_YS" runat="server"></asp:Label>
                    </p>
                    <hr>
                    <strong><i class="fas fa-phone mr-1"></i>Helpline No.</strong>
                    <p class="text-muted">
                        <asp:Label ID="lblHelplineno_YS" runat="server"></asp:Label>
                    </p>
                    <hr>
                    <strong><i class="fas fa-map-marker-alt mr-1"></i>Location</strong>
                    <p class="text-muted">
                        <asp:Label ID="lblAddress_YS" runat="server"></asp:Label>
                    </p>
                </div>
                <!-- /.card-body -->
            </div>
        </div>
    </div>
    <!-- /.tab-pane -->
</asp:Content>
