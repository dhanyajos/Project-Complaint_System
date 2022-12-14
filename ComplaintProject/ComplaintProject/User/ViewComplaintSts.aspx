<%@ Page Title="" Language="C#" MasterPageFile="~/User/UserMaster.Master" AutoEventWireup="true" CodeBehind="ViewComplaintSts.aspx.cs" Inherits="ComplaintProject.User.ViewComplaintSts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <form id="form1" runat="server">
        <h2 style="margin-top:100px;">Complaint Status</h2>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="user_phnno" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="cmpdate" HeaderText="Complaint Date" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="product" HeaderText="Product Name" />
                <asp:BoundField DataField="user_phnno" HeaderText="Phone Number" />
                <asp:BoundField DataField="cmpmsg" HeaderText="Complaint Message" />
                <asp:BoundField DataField="cmpstatus" HeaderText="Complaint Status" />

            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    </form>
</asp:Content>
