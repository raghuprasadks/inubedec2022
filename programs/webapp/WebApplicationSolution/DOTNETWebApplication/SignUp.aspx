<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="DOTNETWebApplication.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Sign Up Form" ForeColor="#99CCFF"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Label">Enter Your Name</asp:Label>
    <asp:TextBox ID="TextBoxName" runat="server" BorderColor="#993366" ToolTip="Enter your name"></asp:TextBox><br />

    <asp:Label ID="Label3" runat="server" Text="Label">Enter Your Email</asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" TextMode="Email"></asp:TextBox><br />

     <asp:Label ID="Label4" runat="server" Text="Label">Enter Your Mobile</asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Label">Enter Your Password</asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Label ID="Label6" runat="server" Text="Sex"></asp:Label>
    <asp:RadioButton ID="RadioButton1" runat="server" GroupName="sex" Text="Male" />
    <asp:RadioButton ID="RadioButton2" runat="server" GroupName="sex" Text="Female" /><br />
    <asp:Label ID="Label7" runat="server" Text="Qualification"></asp:Label>
    <asp:CheckBox ID="CheckBoxUG" runat="server" Text="UG" />
    <asp:CheckBox ID="CheckBoxPG" runat="server" Text="PG"/>
    <asp:CheckBox ID="CheckBoxOTH" runat="server" Text="OTH" /><br />
    <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" /><br />
    <asp:Label ID="LabelPageLoad" runat="server" Text=" "></asp:Label><br />
    <asp:Label ID="LabelButtonClick" runat="server" Text=" "></asp:Label><br />

    <asp:Label ID="LabelMsg" runat="server" Text=" "></asp:Label>

</asp:Content>
