<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="ComplaintProject.Admin.ProductDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <form id="form1" runat="server" style="margin-top: 50px">
        <h2 style="margin-top: 100px; text-align: center;">Product Details</h2>
        <asp:Label ID="Label1" runat="server" Text="Product Details" Style="margin-left: 500px"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Product Name" Style="margin-left: 500px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Style="margin-left: 25px"></asp:TextBox><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" Style="margin-left: 572px" Width="116px" OnClick="Button1_Click" /><br />
        <br />
        <asp:GridView ID="GridView1" runat="server" Style="margin-left: 500px" Width="327px" AutoGenerateColumns="False" DataKeyNames="productid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="product" HeaderText="Product Name" />
                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />

            </Columns>
        </asp:GridView>
    </form>

</asp:Content>

