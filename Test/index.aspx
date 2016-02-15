<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Test.index" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" runat="server">
    <%--<style>
        div.content {
            width: 600px;
            height: 550px;
            border: 1px solid black;
            padding: 10px;
            overflow: hidden;
            background-color: lightseagreen;
        }

        div.content_child {
            float: left;
            margin-right: 10px;
        }
    </style>--%>
    <%--<div class="content">
        <div class="content_child">--%>
    <%--<asp:ListBox ID="lbContacts" runat="server" Width="183px" AutoPostBack="True" OnSelectedIndexChanged="lbContacts_SelectedIndexChanged1" Height="305px"></asp:ListBox>--%>
    <asp:Literal ID="LTable" runat="server" EnableViewState="False"></asp:Literal>

    <%--<button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button>--%>

    <script>
        //$(document).ready(function () {
        //});
        function runModal(id, firstname, lastname) {
            document.location = 'index.aspx?id=' + id + '&mode=edit';
            $("#cphmain_tbvfirstname").val(firstname);
            $("h4.modal-title").text(firstname + " " + lastname);
            $("#cphmain_tbvlastname").val(lastname);
            $("#cphmain_tbvid").val($("#" + id).attr('id'));
            $("#cphmain_tbvid").val(id);
            $("#myModal").modal('show');
        }
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
                    <asp:Label ID="lblVfirstname" runat="server" Text="Firstname"></asp:Label>
                    <asp:TextBox ID="tbVfirstname" runat="server"></asp:TextBox>
                    <asp:Label ID="lblVlastname" runat="server" Text="Lastname"></asp:Label>
                    <asp:TextBox ID="tbVlastname" runat="server"></asp:TextBox>
                    <asp:TextBox ID="tbVId" runat="server" CssClass="hidden"></asp:TextBox>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnSave" CssClass="btn btn-default" runat="server" Text="Save" OnClick="btnSave_Click" />
                    <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                </div>
            </div>

        </div>
    </div>
    <%--</div>--%>
    <%--<div class="content_child">
            <asp:Label ID="lblIDtxt" runat="server" Text="ID"></asp:Label>
            <asp:Label ID="lblID" runat="server"></asp:Label>
            <div class="bc">
                <asp:Label ID="lblFirstname" runat="server" Text="Firstname"></asp:Label>
            </div>
            <div class="bc">
                <asp:TextBox ID="tbFirstname" runat="server"></asp:TextBox>

            </div>
            <div class="bc">
                <asp:Label ID="lblLastname" runat="server" Text="Lastname"></asp:Label>
            </div>
            <div class="bc">
                <asp:TextBox ID="tbLastname" runat="server"></asp:TextBox>

            </div>
            <div class="bc">
                <asp:Label ID="lblSsn" runat="server" Text="Ssn"></asp:Label>
            </div>
            <div class="bc">

                <asp:TextBox ID="tbSsn" runat="server"></asp:TextBox>
            </div>
        </div>--%>
    <%--<div class="content_child">
        <div class="btns">
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            <asp:Button ID="btnCreate" runat="server" Text="Create" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" />
        </div>
    </div>--%>
    <%--</div>--%>
</asp:Content>
