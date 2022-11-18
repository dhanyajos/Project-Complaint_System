<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="ComplaintProject.Admin.UserList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <form id="form1" runat="server">
      <asp:Button ID="Button1" runat="server" Text="Confirm User" Height="34px" Style="margin-top:200px;margin-left:500px" Width="226px" OnClick="Button1_Click"/><br /><br />
      <asp:Button ID="Button2" runat="server" Text="Verified User Details" Width="226px"  Height="34px" Style="margin-left:500px" OnClick="Button2_Click" />
          </form>          
</asp:Content>
