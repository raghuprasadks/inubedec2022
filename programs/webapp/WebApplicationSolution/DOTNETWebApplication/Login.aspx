<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DOTNETWebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label><br />
    <asp:TextBox ID="TextBoxEmail" runat="server" Text="Enter Email"></asp:TextBox><br />
    <asp:TextBox ID="TextBoxPassword" runat="server" Text="Enter Password" TextMode="Password"></asp:TextBox><br />


    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br />
    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    
</asp:Content>
