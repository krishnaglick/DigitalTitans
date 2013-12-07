<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Analyze.aspx.cs" Inherits="WebApplication1.functionality.Analyze" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="../Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title>Digital Titans - Analyze Data</title>
</head>

<body>
    <form id="form1" runat="server">
    <div class="top">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="./SR.aspx">Skills & Ratings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="./Settings.aspx">Settings</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="./Analyze.aspx">Analyze Data</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="./Logout.aspx">Log Out</asp:HyperLink>
    
        <p class="logo">Digital Titans</p>
    </div>

    <asp:SqlDataSource ID="SqlDataSourceAllSkills" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalTitansConnectionString %>" SelectCommand="SELECT DISTINCT [SkillName] FROM [Skills]"></asp:SqlDataSource>

    <div class="center">
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableHeaderCell>
                    <asp:Label ID="LabelChooseSkill" runat="server" Text="Please Choose a Skill"></asp:Label>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="LabelChooseRating" runat="server" Text="Please Choose a Min/Max Rating"></asp:Label>
                </asp:TableHeaderCell>
                <asp:TableHeaderCell>
                    <asp:Label ID="LabelOperator" runat="server" Text="Please Choose an Operator"></asp:Label>
                </asp:TableHeaderCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                    <asp:DropDownList ID="DropDownListAllSkills" runat="server" DataSourceID="SqlDataSourceAllSkills" DataValueField="SkillName"></asp:DropDownList>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButtonList ID="RadioButtonListChooseRating" runat="server" BorderStyle="Solid" BorderWidth="2" BorderColor="Black" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Value="1" Selected="True">1</asp:ListItem>
                        <asp:ListItem Value="2">2</asp:ListItem>
                        <asp:ListItem Value="3">3</asp:ListItem>
                        <asp:ListItem Value="4">4</asp:ListItem>
                        <asp:ListItem Value="5">5</asp:ListItem>
                    </asp:RadioButtonList>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:DropDownList ID="DropDownListOperators" runat="server">
                        <asp:ListItem Value="<"><</asp:ListItem>
                        <asp:ListItem Value=">">></asp:ListItem>
                        <asp:ListItem Value=">=">>=</asp:ListItem>
                        <asp:ListItem Value="<="><=</asp:ListItem>
                        <asp:ListItem Value="=">=</asp:ListItem>
                        <asp:ListItem Value="<>">≠</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell ColumnSpan="100" HorizontalAlign="Right">
                    <asp:Button ID="ButtonSearch" runat="server" Text="Search" OnClick="ButtonSearch_Click" />
                    <asp:Button ID="ButtonReset" runat="server" Text="Reset" OnClick="ButtonReset_Click" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow BorderWidth="0px">
                <asp:TableCell ColumnSpan="100" HorizontalAlign="Center" BorderWidth="0px">
                    <asp:Label runat="server" ID="LabelNothingHere" Text="No Results Found" Visible="false"></asp:Label>
                    <asp:GridView ID="GridViewMatchingUsers" runat="server" Visible="false"></asp:GridView>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>