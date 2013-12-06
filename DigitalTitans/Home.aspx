<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="./Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Digital Titans - Human Resource Solutions</title>
</head>
<body>
    <form id="form1" runat="server">
     <div id="header">
		<img src="/logo.png" style="width:60px; height:60px" /><p id="name">Digital Titans- Human Resource Solutions</p>
	</div>
        <div id="mainpage">
    
        
            
            <div class="right">
                <div class="top">
        <ul>
        <li><asp:HyperLink ID="HyperLink6" runat="server" NavigateUrl="~/Home.aspx">Home</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink7" runat="server" NavigateUrl="~/Why.aspx">Why Digital Titans?</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/Pricing.aspx">Products & Pricing</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/AboutUs.aspx">About Us</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Login.aspx">Log In</asp:HyperLink></li>
      </ul><br />
            <table><tr></tr>
            <tr>
                <th class="pic"><img src="/office1.png" /><p>Are you tired of the clutter of yearly evaluations?</p></th>
                <th class="pic"><img src="/coyote.png" /><p style="text-align: center">Are you signing for help?</p></th>
            </tr>
                <tr>
                <th class="pic"><img src="/logo.png" /><p>After using our product....</p></th>
                <th class="pic"><img src="/office4.jpg" /><p>You will never think of yearly evaluations the same!</p></th>
            </tr>
                </table>
       </div>
    

        </div>
                
        <div id="footer">
        Copyright 2013 Digital Titans.UNF
            </div></div>
    </form>
</body>
</html>
