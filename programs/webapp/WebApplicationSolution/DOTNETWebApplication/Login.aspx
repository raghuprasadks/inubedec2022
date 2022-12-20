<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DOTNETWebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Enter Email"></asp:Label>
    
    <asp:TextBox ID="TextBoxEmail" runat="server" Text="Enter Email"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email is mandatory" Display="Dynamic" ControlToValidate="TextBoxEmail" ForeColor="Red">Email is mandatory</asp:RequiredFieldValidator><br />
    <asp:Label ID="Label3" runat="server" Text="Enter Password"></asp:Label>
    <asp:TextBox ID="TextBoxPassword" runat="server" Text="Enter Password" TextMode="Password"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password is mandatory" Display="Dynamic" ControlToValidate="TextBoxPassword"  ForeColor="Red">Password is mandatory</asp:RequiredFieldValidator><br />
   

    <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br />
    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    
</asp:Content>
