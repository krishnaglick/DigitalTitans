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
        <center>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
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
            <asp:Label ID="LabelSkillRating" runat="server" Text="Skill Rating" Visible="False"></asp:Label>
            <asp:RadioButtonList ID="RadioButtonListRatingOptions" runat="server" Enabled="True" RepeatDirection="Horizontal" AutoPostBack="True" Height="16px" Width="162px" Visible="False" OnSelectedIndexChanged="RadioButtonListRatingOptions_SelectedIndexChanged">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem Value="5"></asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="ButtonDeleteSkill" runat="server" Text="Delete" Visible="false" OnClick="ButtonDeleteSkill_Click"></asp:Button>
        </center>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" SelectCommand=""></asp:SqlDataSource>
    </form>
</body>
</html>
