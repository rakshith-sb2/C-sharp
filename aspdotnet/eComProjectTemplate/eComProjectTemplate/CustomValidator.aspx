<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="CustomValidator.aspx.cs" Inherits="eComProjectTemplate.CustomValidator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label" runat="server" Text="Gender"></asp:Label>
    <asp:RadioButton ID="MaleRadioButton" runat="server" GroupName="gender" Text="Male" />
    <asp:RadioButton ID="FemaleRadioButton" runat="server" GroupName="gender" Text="Female"  />
    <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Please select a gender" ForeColor="#CC0000" OnServerValidate="CustomValidator1_ServerValidate" Display="Dynamic" ValidateEmptyText="True">* Select Gender</asp:CustomValidator>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" />
</asp:Content>
