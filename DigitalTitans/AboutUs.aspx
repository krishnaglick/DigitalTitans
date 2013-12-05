<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="./Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="header">
		<p id="name">Digital Titans- Human Resource Solutions</p>
	</div>
        <div id="mainpage">
    
        
    
            <div class="right">

                <div class="top">
        <ul>
        <li><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Why.aspx">Why Digital Titans?</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Pricing.aspx">Pricing</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/AboutUs.aspx">AboutUs</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Login.aspx">Log In</asp:HyperLink></li>
      </ul></div><br /> 
        <p class="logo">Digital Titans</p></div>
    

        
        <div id="footer">
        <a href="Default.aspx" id="email">Home</a>
            </div></div>
    </form>
</body>
</html>