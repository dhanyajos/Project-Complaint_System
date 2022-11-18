<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ConfirmedUserList.aspx.cs" Inherits="ComplaintProject.Admin.ConfirmedUserList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
        <h3 style="margin-top:100px;">Verified User List</h3>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="user_phnno" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" AutoGenerateColumns="False" GridLines="Vertical">

            <AlternatingRowStyle BackColor="#DCDCDC" />

            <Columns>

                <asp:BoundField DataField="user_name" HeaderText="Name" />
                <asp:BoundField DataField="user_email" HeaderText="Email" />
                <asp:BoundField DataField="user_phnno" HeaderText="Phone Number" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />

            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="Black" HorizontalAlign="Center" BackColor="#999999" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</asp:Content>
