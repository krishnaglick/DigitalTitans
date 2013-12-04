<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm2" %>

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
            <asp:Login ID="loginBox" runat="server" OnAuthenticate="loginBox_Authenticate">
            </asp:Login>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"></asp:Button>
       </center>
    </div>
    </form>
</body>
</html>
