<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Test.index" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Literal ID="LTable" runat="server" EnableViewState="False"></asp:Literal>

    <script>
        //$(document).ready(function () {
        
        //});
    </script>
    <div id="myModal" class="modal fade" role="dialog">
        <div class="modal-dialog">

            <!-- Modal content-->
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">View </h4>
                </div>
                <div class="modal-body">
                    <input type="hidden" id="modal_mode" name="modal_mode" value="" />

                    <%--<label for="firstname">Firstname</label>
                    <input id="firstname" />
                    <label for="lastname">Lastname</label>
                    <input id="lastname" />--%>
                    <asp:Label ID="lblVfirstname" runat="server" Text="Firstname"></asp:Label>
                    <asp:TextBox ID="tbVfirstname" runat="server"></asp:TextBox>
                    <asp:Label ID="lblVlastname" runat="server" Text="Lastname"></asp:Label>
                    <asp:TextBox ID="tbVlastname" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tbVId" runat="server" CssClass="hidden"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnAdd" CssClass="btn btn-default" runat="server" Text="Add" />
                    <asp:Button ID="btnEdit" CssClass="btn btn-default" runat="server" Text="Save" OnClick="btnSave_Click"/>
                    <asp:Button ID="btnDelete" CssClass="btn btn-default" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
