<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SR.aspx.cs" Inherits="WebApplication1.functionality.SR" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="../Core.css" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" id="Head1">
    <title>Digital Titans - Skills & Ratings</title>
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

        <asp:SqlDataSource ID="SqlDataSourceEmployees" runat="server" ConnectionString="<%$ ConnectionStrings:DigitalTitansConnectionString %>" SelectCommand="SELECT [Username] FROM [Users] WHERE ([Manager] = @Manager)">
            <SelectParameters>
                <asp:SessionParameter Name="Manager" SessionField="Username" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <center>
            <asp:DropDownList ID="DropDownListEmployees" runat="server" AutoPostBack="True" DataSourceID="SqlDataSourceEmployees" DataTextField="Username" DataValueField="Username" AppendDataBoundItems="true" OnSelectedIndexChanged="DropDownListEmployees_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" DataSourceID="SqlDataSource1" GridLines="None" ForeColor="#333333">
                <AlternatingRowStyle BackColor="White" CssClass="altrowstyle" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" Height="10px" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:Button ID="ButtonSkillAddFunTimes" runat="server" Text="Add New Skill" OnClick="ButtonSkillAddFunTimes_Click" /><asp:Button ID="ButtonSkillRateFunTimes" runat="server" Text="Edit Skill Rating" OnClick="ButtonSkillRateFunTimes_Click" /><asp:Button ID="ButtonPickSkillDelete" runat="server" Text="Delete Skill" Height="26px" OnClick="ButtonPickSkillDelete_Click"></asp:Button>
            <br />
            <asp:Label ID="LabelNewSkillName" runat="server" Text="Skill Name" Visible="False"></asp:Label><br />
            <asp:TextBox ID="TextBoxNewSkillName" runat="server" Visible="False" MaxLength="20"></asp:TextBox><br />
            <asp:Label ID="LabelNewSkillDescription" runat="server" Text="Skill Description" Visible="False"></asp:Label><br />
            <asp:TextBox ID="TextBoxNewSkillDescription" runat="server" Visible="False" MaxLength="100"></asp:TextBox><br />
            <asp:Label ID="LabelChooseSkillToRate" runat="server" Text="Choose Skill To Rate" Visible="False"></asp:Label><br />
            <asp:DropDownList ID="DropDownListEditingSkillList" runat="server" Visible="false"></asp:DropDownList>
            <br />
            <asp:Label ID="LabelSkillRating" runat="server" Text="Skill Rating" Visible="False"></asp:Label><br />
            <asp:RadioButtonList ID="RadioButtonListRatingOptions" runat="server" Enabled="True" RepeatDirection="Horizontal" AutoPostBack="True" Height="16px" Width="172px" Visible="False" OnSelectedIndexChanged="RadioButtonListRatingOptions_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            </asp:RadioButtonList><br />
            <asp:Button ID="ButtonDeleteSkill" runat="server" Text="Delete" Visible="false" OnClick="ButtonDeleteSkill_Click"></asp:Button>
            <asp:Button ID="ButtonCancel" runat="server" Text="Cancel" Visible="false" OnClick="ButtonCancel_Click" />
        </center>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" SelectCommand=""></asp:SqlDataSource>
    </form>
</body>
</html>
