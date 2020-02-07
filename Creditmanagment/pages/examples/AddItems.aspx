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
            <form class="form-horizontal" id="form1">
                <div class="card-body">
                    <div class="form-group row">
                        <label for="inputEmail3" class="col-sm-4 col-form-label">Item Name</label>
                        <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                            <input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="inputPassword3" class="col-sm-4 col-form-label">Rate</label>
                        <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="Rate">
                        </div>
                    </div>
                </div>
                <!-- /.card-body -->
                <div class="card-footer">
                    <%--<button id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>--%>
                  <asp:Button  id="btnCancel_YS" type="submit" runat="server" Text="Cancel" class="btn btn-default float-right" />
                  <asp:Button  id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info" Text="ADD" />

                </div>
                <!-- /.card-footer -->
            </form>
        </div>
    </div>
    <!-- /.card -->
</asp:Content>
