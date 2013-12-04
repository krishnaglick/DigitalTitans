<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SR.aspx.cs" Inherits="WebApplication1.functionality.SR" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="../Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="./SR.aspx">Skills & Ratings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="./Settings.aspx">Settings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="./Logout.aspx">Log Out</asp:HyperLink>
    
        <p class="logo">Digital Titans</p>
    </div>
        <asp:DataList ID="DataList1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Both">
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="White" />
            <ItemTemplate>
                Skill_Name:
                <asp:Label ID="Skill_NameLabel" runat="server" Text='<%# Eval("Skill_Name") %>' />
                <br />
                Personal_Rating:
                <asp:Label ID="Personal_RatingLabel" runat="server" Text='<%# Eval("Personal_Rating") %>' />
                <br />
                Manager_Rating:
                <asp:Label ID="Manager_RatingLabel" runat="server" Text='<%# Eval("Manager_Rating") %>' />
                <br />
<br />
            </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalTitansConnectionString %>" SelectCommand="SELECT [Skill_Name], [Personal_Rating], [Manager_Rating] FROM [Skills]"></asp:SqlDataSource>
        <br />
    </form>
</body>
</html>
