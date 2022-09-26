<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="StateForm1.aspx.cs" Inherits="eComProjectTemplate.StateForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="USER NAME"></asp:Label>
    <asp:TextBox ID="UserNameTextBox" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
    <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password"></asp:TextBox><br />


    <asp:Button ID="Button1" runat="server" OnClick="Submit_Click" Text="SUBMIT" />
    <asp:Button ID="Button2" runat="server" OnClick="Restore_Click" Text="RESTORE" />


</asp:Content>
