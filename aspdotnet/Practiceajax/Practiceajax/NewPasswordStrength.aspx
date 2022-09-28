<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewPasswordStrength.aspx.cs" Inherits="Practiceajax.NewPasswordStrength" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" Text="Enter Password"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <ajaxToolkit:PasswordStrength ID="PasswordStrength1" runat="server" MinimumLowerCaseCharacters="2" MinimumNumericCharacters="2" MinimumSymbolCharacters="2" MinimumUpperCaseCharacters="2" PreferredPasswordLength="8" TargetControlID="TextBox1" HelpStatusLabelID="Label2" PrefixText="Password Strength: " StrengthIndicatorType="BarIndicator" />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </ContentTemplate>



            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
