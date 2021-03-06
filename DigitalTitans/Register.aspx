<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.functionality.Register" %>

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
      </ul></div><br />

        <p class="logo">Digital Titans</p>
        <center>
            <asp:Table runat="server">
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label1" runat="server" Text="Username "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="user" runat="server"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label2" runat="server" Text="Password "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="pass" runat="server" TextMode="Password"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label3" runat="server" Text="Security Question "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="sq" runat="server"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label4" runat="server" Text="Security Answer "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="sa" runat="server" TextMode="Password"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label5" runat="server" Text="Email "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="em" runat="server" TextMode="Email"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Label ID="Label6" runat="server" Text="Manager Name "></asp:Label></asp:TableCell>
                    <asp:TableCell><asp:TextBox ID="mgr" runat="server"></asp:TextBox><br /></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell><asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click"></asp:Button></asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </center>
    </div>

    <div id="footer">
        Copyright 2013 Digital Titans.UNF
            </div></div>

    </form>
</body>
</html>
