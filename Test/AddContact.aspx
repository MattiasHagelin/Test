<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddContact.aspx.cs" Inherits="Test.AddContact" %>

<asp:Content ID="Content4" ContentPlaceHolderID="cphMain" runat="server">
    <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
    <asp:Label ID="lblIDtxt" runat="server"></asp:Label>
    <asp:Label ID="lblFirstname" runat="server" Text="Firstname"></asp:Label>
    <asp:TextBox ID="tbFirstname" runat="server"></asp:TextBox>
    <asp:Label ID="lblLastname" runat="server" Text="Lastname"></asp:Label>
    <asp:TextBox ID="tbLastname" runat="server"></asp:TextBox>
    <asp:Label ID="lblSsn" runat="server" Text="Ssn"></asp:Label>
    <asp:TextBox ID="tbSsn" runat="server"></asp:TextBox>
    <asp:LinkButton ID="lbSave" runat="server" OnClick="lbSave_Click">Save</asp:LinkButton>
</asp:Content>
