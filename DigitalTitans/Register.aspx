<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.functionality.Register" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="./Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Policies.aspx">Policies</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Pricing.aspx">Pricing</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Security.aspx">Security &amp; Privacy</asp:HyperLink>
        <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/Login.aspx">Log In</asp:HyperLink>
    
        <p class="logo">Digital Titans</p>
        <center>
            <asp:Label ID="Label1" runat="server" Text="Username "></asp:Label><asp:TextBox ID="user" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Password "></asp:Label><asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label3" runat="server" Text="Security Question "></asp:Label><asp:TextBox ID="sq" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label4" runat="server" Text="Security Answer "></asp:Label><asp:TextBox ID="sa" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="Label5" runat="server" Text="Email "></asp:Label><asp:TextBox ID="em" runat="server" TextMode="Email"></asp:TextBox><br />
            <asp:Label ID="Label6" runat="server" Text="Manager Name "></asp:Label><asp:TextBox ID="mgr" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"></asp:Button>
        </center>
    </div>

    
    </form>
</body>
</html>
