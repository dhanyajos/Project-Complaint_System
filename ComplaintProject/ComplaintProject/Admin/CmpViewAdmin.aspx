<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="CmpViewAdmin.aspx.cs" Inherits="ComplaintProject.Admin.CmpViewAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
      
        
        <h2 style="margin-top:100px;">Complaint Details</h2>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="cmp_id" CellPadding="4" ForeColor="Black"  BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" style="margin-right: 101px" Width="901px" Height="190px">
            <Columns>
                <asp:BoundField DataField="cmpdate" HeaderText="Complaint Date" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="cmp_id" HeaderText="Complaint ID" />               
                <asp:BoundField DataField="product" HeaderText="Product Name" />
                <asp:BoundField DataField="user_name" HeaderText="Customer Name" />
                <asp:BoundField DataField="user_phnno" HeaderText="Phone number" />
                <asp:BoundField DataField="cmpmsg" HeaderText="Complaint Message" />
                <asp:BoundField DataField="cmpstatus" HeaderText="Complaint Status" />
                 <asp:TemplateField>  
                    <ItemTemplate>  
                        <asp:Button ID="btn_Edit" runat="server" Text="Edit" CommandName="Edit" BackColor="Red" Height="35px" Width="97px" />  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:Button ID="btn_Update" runat="server" Text="Update" CommandName="Update"/>  
                        <asp:Button ID="btn_Cancel" runat="server" Text="Cancel" CommandName="Cancel"/>  
                    </EditItemTemplate>  
                </asp:TemplateField>  
                
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
