<%@ Page Title="Products" Language="C#" MasterPageFile="~/Guest.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="eComProjectTemplate.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Amazing Products<asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" PageSize="5">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
            <asp:BoundField DataField="desc" HeaderText="desc" SortExpression="desc" />
            <asp:BoundField DataField="supplier" HeaderText="supplier" SortExpression="supplier" />
            <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
        </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ecomdbcs %>" DeleteCommand="DELETE FROM [Products] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Products] ([name], [desc], [supplier], [price]) VALUES (@name, @desc, @supplier, @price)" SelectCommand="SELECT * FROM [Products]" UpdateCommand="UPDATE [Products] SET [name] = @name, [desc] = @desc, [supplier] = @supplier, [price] = @price WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="desc" Type="String" />
                <asp:Parameter Name="supplier" Type="String" />
                <asp:Parameter Name="price" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="desc" Type="String" />
                <asp:Parameter Name="supplier" Type="String" />
                <asp:Parameter Name="price" Type="Int32" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </h1>
</asp:Content>
