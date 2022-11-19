<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="viewQuery.aspx.cs" Inherits="ComplaintProject.Admin.viewQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <h2>Raise a Query</h2>
    <form id="form1" runat="server">
        <h2 style="margin-top: 50px;">Query Details</h2>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="user_phnno" CellPadding="4" ForeColor="Black" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit">
            <Columns>

                <asp:BoundField DataField="product" HeaderText="Product Name" />
                <asp:BoundField DataField="user_name" HeaderText="Name" />
                <asp:BoundField DataField="user_phnno" HeaderText="Name" />
                <asp:BoundField DataField="querymsg" HeaderText="Query" />
                <asp:BoundField DataField="reply" HeaderText="Reply" />

                <asp:CommandField HeaderText="Edit Reply" ShowEditButton="True" EditText="Reply" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
            <RowStyle BackColor="White" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</asp:Content>
