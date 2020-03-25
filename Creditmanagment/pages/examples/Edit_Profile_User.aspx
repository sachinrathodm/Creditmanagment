<%@ Page Title="" Language="C#" MasterPageFile="~/UserBlankPage.Master" AutoEventWireup="true" CodeBehind="Edit_Profile_User.aspx.cs" Inherits="Creditmanagment.pages.examples.Edit_Profile_User" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row mb-2">
            <div class="col-sm-6">
                <h1>Edit Profile</h1>
            </div>
            <div class="col-sm-6">
                <ol class="breadcrumb float-sm-right">
                    <li class="breadcrumb-item"><a href="../../IndexHomePage_User.aspx">Home</a></li>
                    <li class="breadcrumb-item active"><a href="SendRequestUser.aspx">Edit Profile</a></li>
                </ol>
            </div>
        </div>
        <div class="col-lg-5">
            <div class="card card-info">
                <div class="card-header">
                    <h3 class="card-title">Edit Profile</h3>
                </div>
                <form runat="server" id="form1">
                    <div class="card-body">
                        <div class="input-group-append">
                            <div class="m-2 form-group" style="text-align: left; width: 200px">
                                <asp:TextBox ID="txtFirstname_YS" class="form-control" placeholder="First name" runat="server" />
                            </div>
                            <div class="m-2 form-group" style="width: 200px;">
                                <asp:TextBox ID="txtLastname_YS" class="form-control" placeholder="Last name" runat="server" />
                            </div>
                        </div>
                        <div class="input-group-append">
                            <div class="m-2 form-group" style="text-align: left; width: 200px">
                                <asp:TextBox ID="txtMobileno_YS" class="form-control" placeholder="Mobile no" runat="server" />
                            </div>
                            <div style="width: 200px;" class="m-2 form-group">
                                <asp:TextBox ID="txtEmail_YS" class="form-control" placeholder="Email" runat="server" />
                            </div>
                        </div>
                        <div class="m-2 form-group">
                            <asp:Label ID="lblinputfile" runat="server" for="InputFile_YS">File input</asp:Label>
                            <div class="input-group">
                                <div class="custom-file">
                                    <asp:FileUpload ID="InputFile_YS" class="custom-file-input" runat="server" />
                                    <asp:Label ID="ltrinputfile" runat="server" class="custom-file-label" for="InputFile_YS">Choose Photo</asp:Label>
                                </div>
                                <div class="input-group-append">
                                </div>
                            </div>
                        </div>
                        <div class="input-group-append">
                            <div style="width: 360px;" class="m-2 form-group">
                                <asp:TextBox ID="txtAddress_YS" class="form-control" placeholder="Address" runat="server" TextMode="MultiLine"></asp:TextBox>
                            </div>
                        </div>
                        <div class="input-group-append">
                            <div style="width: 360px;" class="ml-2 mr-2 mt-2 form-group">
                                <asp:TextBox ID="txtAdharcardno_YS" class="form-control" placeholder="Adhar card number" runat="server" />
                            </div>
                        </div>
                        <div class="ml-2 mr-2">
                            <asp:Label ID="lblBirthDate_YS" runat="server" Text="Label">Date Of Birth</asp:Label>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <asp:Label ID="ltrBirthdate_YS" runat="server" class="input-group-text"><i class="far fa-calendar-alt"></i></asp:Label>
                                </div>
                                <asp:TextBox ID="txtBirthDate_YS" runat="server" class="form-control" data-inputmask-alias="datetime" data-inputmask-inputformat="dd/mm/yyyy" data-mask> </asp:TextBox>
                            </div>
                            <!-- /.input group -->
                        </div>
                    </div>
                </form>
            </div>
        </div>
</asp:Content>
