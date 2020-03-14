<%@ Page Title="" Language="C#" MasterPageFile="~/BlankPage.Master" AutoEventWireup="true"  CodeBehind="Add_Invoice.aspx.cs" Inherits="Creditmanagment.pages.examples.Add_Invoice" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="col-lg-6">
                <div class="card card-info">
                    <div class="card-header">
                        <h3 class="card-title">Add Invoice</h3>
                    </div>
                    <!-- /.card-header -->
                    <!-- form start -->
                    <form class="form-horizontal" runat="server" id="form1">
                        <div class="card-body">
                            <div class="form-group row">
                              <label class="col-sm-4 col-form-label">Select Customer Name</label>
                                <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                    <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                    <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                                    <asp:DropDownList ID="ddCustomerName_YS" runat="server" class="form-control" AutoPostBack="true" OnselectedIndexChanded="SelectedIndexChanged"></asp:DropDownList><br/>
                                  </div>
                               
                                <label class="col-sm-4 col-form-label">Description</label>
                                <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                    <asp:TextBox ID="txtDescription" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox><br/>
                                  </div>

                               <label class="col-sm-4 col-form-label">Item Value</label>
                                <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                    <asp:TextBox ID="txtValue_YS" runat="server" class="form-control"></asp:TextBox><br/>
                                  </div>

                              <asp:Label ID="lblitems" runat="server"  class="col-sm-4 col-form-label">Select Item Name</asp:Label>
                                <div style="-ms-flex: 0 0 60%;flex: 0 0 250%;max-width: 60%;">
                                    <%--<input type="text" class="form-control" id="inputEmail3" placeholder="Item Name">--%>
                                    <%--<asp:TextBox ID="txtItemname_YS" class="form-control" placeholder="Item Name" runat="server"></asp:TextBox>--%>
                                    <asp:DropDownList ID="ddItemName_YS" runat="server" class="form-control"></asp:DropDownList><br/>
                                  </div>

                               <asp:Label ID="lblqty"  runat="server"  class="col-sm-4 col-form-label">Qty</asp:Label>
                                <div style="-ms-flex: 0 0 60%; flex: 0 0 250%; max-width: 60%;">
                                <asp:TextBox ID="txtQty_YS" runat="server" class="form-control"></asp:TextBox>
                                  </div>
                        </div>
                        <!-- /.card-body -->
                        <div class="card-footer">
                            <%--<button id="btnAddItem_YS" runat="server" type="submit" class="btn btn-info">Add</button>
                    <button type="submit" class="btn btn-default float-right">Cancel</button>--%>
                            <asp:Button ID="btnAddNewItem_YS" runat="server" type="submit" class="btn btn-info" Text="Add NewItem" />
                            <asp:Button ID="btnAdd_YS" runat="server" Text="Add" class="btn btn-default float-right" />
                        </div>
                        <!-- /.card-footer -->
                </div>
            </div>
                <div class="content-wrapper col-lg-9">
                    <!-- Main content -->
                    <section class="content">
                        <div class="row">
                            <div class="col-12">
                                <div class="card">
                                    <div class="card-header">
                                        <h3 class="card-title">Items</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class="card-body">
                                       <asp:Label ID="lblnullmessage"  runat="server" Visible="false"  class="col-sm-4 col-form-label">Qty</asp:Label>
                                        <asp:GridView ID="gdUserRequest" runat="server" CellPadding="10" AutoPostBack="true"></asp:GridView>
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
