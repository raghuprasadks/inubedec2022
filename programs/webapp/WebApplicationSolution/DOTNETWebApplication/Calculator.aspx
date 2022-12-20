<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="DOTNETWebApplication.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Calculator"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Enter First Number"></asp:Label>
    <asp:TextBox ID="TextBoxFN" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Select Operation"></asp:Label>
    
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Value="+">Addition</asp:ListItem>
        <asp:ListItem Value="-">Subtraction</asp:ListItem>
        <asp:ListItem Value="*">Multiplication</asp:ListItem>
        <asp:ListItem Value="/">Division</asp:ListItem>
    </asp:DropDownList><br />

    <asp:Label ID="Label3" runat="server" Text="Enter Second Number"></asp:Label>
    <asp:TextBox ID="TextBoxSN" runat="server"></asp:TextBox><br />
    <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" /><br />
    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
    

</asp:Content>
