<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WebApplication1.functionality.Settings" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="../Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form>
    <div class="top">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="./SR.aspx">Skills & Ratings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="./Settings.aspx">Settings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="./Logout.aspx">Log Out</asp:HyperLink>
    
        <p class="logo">Digital Titans</p>
    </div>
    </form>
</body>
</html>
