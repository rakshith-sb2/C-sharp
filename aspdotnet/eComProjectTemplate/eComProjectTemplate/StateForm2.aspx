<%@ Page Title="" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="StateForm2.aspx.cs" Inherits="eComProjectTemplate.StateForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <asp:LinkButton ID="LinkButton1" runat="server" Text="GoTo Page 3" PostBackUrl="~/StateForm3.aspx"></asp:LinkButton>
</div>
</asp:Content>
