<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="adonetweb.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Student Form"></asp:Label><br />

    <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>

    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>

    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label4" runat="server" Text="Address"></asp:Label>

    <asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br />

    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label><br />

    <asp:Label ID="LabelData" runat="server" Text=""></asp:Label>

</asp:Content>
