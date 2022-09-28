<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordStrength.aspx.cs" Inherits="Practiceajax.PasswordStrength" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Password</title>

    <style>

        .BarBorder{
            border:2px black ridge;
            width:120px;
        }        
        .Poor{
            background-color:darkred;
        }
        .Weak{
            background-color:red;
        }
        .Average{
            background-color:yellow;
        }
        .Nice{
            background-color:lightgreen;
        }
        .Strong{
            background-color:green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Enter Password"></asp:Label>     
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <ajaxtoolkit:passwordstrength runat="server" ID="PasswordStrength1" MinimumLowerCaseCharacters="3" TargetControlID="TextBox1" MinimumNumericCharacters="2" MinimumSymbolCharacters="1" MinimumUpperCaseCharacters="3" PreferredPasswordLength="8" PrefixText="Password Strength: " RequiresUpperAndLowerCaseCharacters="True" HelpStatusLabelID="Label2" StrengthIndicatorType="BarIndicator" TextStrengthDescriptions="Poor;Weak;Average;Nice;Strong" BarBorderCssClass="BarBorder" BarIndicatorCssClass="Poor" StrengthStyles="Poor;Weak;Average;Nice;Strong"></ajaxtoolkit:passwordstrength>
               <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </div>
               </ContentTemplate>
        </asp:UpdatePanel>
       
    </form>
</body>
</html>
