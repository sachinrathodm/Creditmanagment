<%@ Page Title="" Language="C#" MasterPageFile="~/UserBlankPage.Master" AutoEventWireup="true" CodeBehind="SendRequestUser.aspx.cs" Inherits="Creditmanagment.pages.examples.SendRequestUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        
            <div class="col-lg-12">
                <div class="card card-info">
                    <div class="card-header">
                        <h3 class="card-title">Send Request</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    <form class="form-horizontal" id="form1">
                        <div class="card-body">
                            <div class="form-group row">
                                <label class="col-sm-4 col-form-label">Select Store Name</label>
                                <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                    <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                    <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                                    <asp:DropDownList ID="ddStoreName_YS" runat="server" class="form-control"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <!-- /.card-body -->
                        <div class="card-footer">
                            <%--<button id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>--%>
                            <asp:Button ID="btnCancel_YS" runat="server" Text="Cancel" class="btn btn-default float-right" />
                            <asp:Button ID="btnSend_YS" runat="server" type="submit" class="btn btn-info" Text="Send" />

                        </div>
                        <!-- /.card-footer -->
                    </form>
                </div>
            </div>
            
            <div>
                <div class="content-wrapper col-lg-8"">
                    <!-- Main content -->
                    <section class="content">
                        <div class="row">
                            <div class="col-12">
                                <div class="card">
                                    <div class="card-header">
                                        <h3 class="card-title">Request Status</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class="card-body">
                                        <asp:GridView ID="gdUserRequest" runat="server"></asp:GridView>
                                    </div>
                                    <!-- /.card-body -->
                                </div>
                            </div>
                        </div>
                </div>
            </div>
            <!-- /.card -->
    </form>
    <!-- /.card -->


</asp:Content>
