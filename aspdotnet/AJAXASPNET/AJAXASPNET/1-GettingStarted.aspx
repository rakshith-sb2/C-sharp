﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1-GettingStarted.aspx.cs" Inherits="AJAXASPNET._1_GettingStarted" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Normal" />
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Button ID="Button2" runat="server" Text="AJAX" />
                </ContentTemplate>
            </asp:UpdatePanel>
    </form>
</body>
</html>
