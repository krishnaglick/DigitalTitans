<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="WebApplication1.ForgotPassword" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="./Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
     <div id="header">
		<p id="name">Digital Titans - Recover Password</p>
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
        <br />
        <div>
            <asp:Label ID="LabelAsk" runat="server" Text="Please enter your email address"></asp:Label><br />
            <asp:TextBox ID="TextBoxInput" runat="server"></asp:TextBox><br />
            <asp:Button ID="ButtonGo" runat="server" Text="Go" OnClick="ButtonGo_Click" /><br /><br />

            <asp:Label ID="LabelSQ" runat="server" Text="" Visible="false"></asp:Label><br />
            <asp:Label ID="LabelSA" runat="server" Text="Security Answer" Visible="false"></asp:Label><br />
            <asp:TextBox ID="TextBoxSA" runat="server" TextMode="Password" Visible="false"></asp:TextBox><br />
            <asp:Button ID="ButtonSendEmail" runat="server" Text="Send Email"  Visible="false" OnClick="ButtonSendEmail_Click"/>
        </div>
        </div>
                
        <div id="footer">
        Copyright 2013 Digital Titans.UNF
            </div></div>
    </form>
</body>
</html>
