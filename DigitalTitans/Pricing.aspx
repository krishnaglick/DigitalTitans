<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pricing.aspx.cs" Inherits="WebApplication1.Pricing" %>

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
        <li><asp:HyperLink ID="HyperLink9" runat="server" NavigateUrl="~/AboutUs.aspx">About Us</asp:HyperLink></li>
        <li><asp:HyperLink ID="HyperLink10" runat="server" NavigateUrl="~/Login.aspx">Log In</asp:HyperLink></li>
      </ul></div>
    
                <br /><br /><p class="bold">Plans & Pricing</p>

                        <p class="forward">
                                <i>Initial Fee</i><br />
                                    Base: $1,000<br />
                                    This fee covers setup of our product for your system.<br />
                                    *Additional customizations to workflows will increase the cost.<br /><br />
                                <i>Yearly Subscription</i><br />
                                    Base: $5,000<br />
                                    Yearly cost will increase with company size. 
                                Additional workflows will not affect this cost.<br />
                                    *This is required to use our product.<br /><br />
                                <i>Maintenance & Support</i><br />
                                    Yearly Subscription will include two months of free support.<br />
                                    Additional month's costs will vary based on workflow customizations and company size.<br />
                                    *Businesses who have a subscription will receive higher ticket priority for requested changes or bugs.
                        </p>
        </div>
                
        <div id="footer">
        Copyright 2013 Digital Titans.UNF
            </div></div>
    </form>
</body>
</html>