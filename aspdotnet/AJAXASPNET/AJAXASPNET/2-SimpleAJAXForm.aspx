<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2-SimpleAJAXForm.aspx.cs" Inherits="AJAXASPNET._2_SimpleAJAXForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
            <asp:Label ID="Label1" runat="server" Text="First Number"></asp:Label>
            <asp:TextBox ID="FirstNumberTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label>
            <asp:TextBox ID="SecondNumberTextBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit_Click" /><br />
            <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
        </div>
            </ContentTemplate>
            </asp:UpdatePanel>
    </form>
</body>
</html>
