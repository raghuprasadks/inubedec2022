<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginNew.aspx.cs" Inherits="DOTNETWebApplication.LoginNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Login New"></asp:Label><br />
            <asp:Label ID="Label2" runat="server" Text="Enter Email"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server" OnTextChanged="Page_Load"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Please Enter your Email ID" ForeColor="#CC0000" Display="Dynamic" ValidateRequestMode="Enabled"></asp:RequiredFieldValidator> <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Password"></asp:Label>
            
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="RequiredFieldValidator" ValidateRequestMode="Enabled" ForeColor="#CC0000">Password is mandatory</asp:RequiredFieldValidator><br />

            
            <asp:Button ID="Button1" runat="server" Text="Login" />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </div>
    </form>
</body>
</html>
