<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="ComplaintProject.Admin.confirmuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">

    <h2>User Details</h2>
          
 <form id="form1" runat="server">
          <h3 style="margin-top:100px;">Unconfirmed User List</h3>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="user_phnno" OnRowDeleting="GridView1_RowDeleting" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AutoGenerateColumns="False">
                <Columns>
                    
                     <asp:BoundField DataField="user_name" HeaderText="Name" />
                     <asp:BoundField DataField="user_email" HeaderText="Email" />
                     <asp:BoundField DataField="user_phnno" HeaderText="Phone Number" />
                     <asp:BoundField DataField="gender" HeaderText="Gender" />
                
                    <asp:CommandField HeaderText="Confirm Status" ShowDeleteButton="True" DeleteText="Confirm" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
     </form>
   
 </asp:Content>
