<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WebApplication1.functionality.Settings" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="../Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
    <div class="top">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="./SR.aspx">Skills & Ratings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="./Settings.aspx">Settings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="./Logout.aspx">Log Out</asp:HyperLink>
    
        <p class="logo">Digital Titans</p>
    </div>
        <center>
        <asp:Button ID="ButtonChangePassword" runat="server" Text="Change Password" OnClick="ButtonChangePassword_Click" /><asp:Button ID="ButtonChangeEmail" runat="server" Text="Change Email" OnClick="ButtonChangeEmail_Click" /><asp:Button ID="ButtonChangeQA" runat="server" Text="Change Security Q&A" OnClick="ButtonChangeQA_Click" />
            <br />
            <asp:Label ID="LabelData1" runat="server" Text="" Visible="false"></asp:Label><br />
            <asp:TextBox ID="TextBoxData1" runat="server" Visible="false" TextMode="password"></asp:TextBox><br />
            <asp:Label ID="LabelData2" runat="server" Text="" Visible="false"></asp:Label><br />
            <asp:TextBox ID="TextBoxData2" runat="server" Visible="false" ></asp:TextBox><br />
            <asp:Label ID="LabelData3" runat="server" Text="" Visible="false"></asp:Label><br />
            <asp:TextBox ID="TextBoxData3" runat="server" Visible="false"></asp:TextBox><br />
            <asp:Button ID="ButtonAccept" runat="server" Text="Accept" Visible="false" OnClick="ButtonAccept_Click"></asp:Button>
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" Visible="false" OnClick="ButtonCancel_Click"></asp:Button>
        </center>
    </form>
</body>
</html>
