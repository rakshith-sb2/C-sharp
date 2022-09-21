<%@ Page Title="Sign Up" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="ASPNET_GettingStarted_1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Sign Up Form</h1>
    <table class="nav-justified">
        <tr>
            <td style="width: 423px">
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 423px">
                <asp:Label ID="Label2" runat="server" Text="EMail"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="EMailTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 423px">
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 423px">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 423px"></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
