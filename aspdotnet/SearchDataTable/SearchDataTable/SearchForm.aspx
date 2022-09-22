<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchForm.aspx.cs" Inherits="SearchDataTable.SearchForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="2">Search</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:RadioButton ID="Male" runat="server" AutoPostBack="True" GroupName="sex" OnCheckedChanged="Male_CheckedChanged" Text="Male" />
                    <asp:RadioButton ID="Female" runat="server" GroupName="sex" OnCheckedChanged="Female_CheckedChanged" Text="Female" />
                    <asp:RadioButton ID="All" runat="server" GroupName="sex" OnCheckedChanged="All_CheckedChanged" Text="All" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="SearchButton" runat="server" OnClick="SearchButton_Click" Text="Search" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
