<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="aspdotnetbasics.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="LabelName" runat="server" Text="Label">Name</asp:Label>
   
    <asp:TextBox ID="name" runat="server"></asp:TextBox><br />
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name is mandatory" Display="Dynamic" ControlToValidate="name" BackColor="Red"></asp:RequiredFieldValidator></br>
    <asp:Label ID="LabelEmail" runat="server" Text="Label">EMail</asp:Label>
    <asp:TextBox ID="email" runat="server"></asp:TextBox><br />
    <asp:Label ID="LabelMobile" runat="server" Text="Label">Mobile</asp:Label>
    <asp:TextBox ID="mobile" runat="server"></asp:TextBox><br />
    <input id="Submit1" type="submit" value="submit" />
    
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>


</asp:Content>
