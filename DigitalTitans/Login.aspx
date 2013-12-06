<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm2" %>

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
        <p class="logo">Digital Titans</p>
        
            <asp:Label ID="LabelUsername" runat="server" Text="Username:  "></asp:Label>
            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:  "></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" EnableViewState="False" TextMode="password"></asp:TextBox><br /><br />
            <asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="Login_Click"></asp:Button>
            <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="Register_Click"></asp:Button><br />
            <asp:Button ID="ButtonForgotPassword" runat="server" Text="Forgot Password" OnClick="ButtonForgotPassword_Click" />
       
    
        </div>
        <div id="footer">
            Copyright 2013 Digital Titans.UNF
            </div>
    </form>
    
    
</body>
</html>
