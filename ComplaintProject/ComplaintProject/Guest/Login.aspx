<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintProject.Guest.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
   
        <form id="form1" runat="server">
            <center>

                <div class="panel" style="width: 800px; height: 300px; background-color: darkblue; margin-top: 200px">
                     <h2 style="text-align:center;color:white;">Sign In</h2>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text="Username" style="color:white;"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox1" runat="server" Height="29px" Width="185px"></asp:TextBox>
                            </td>

                        </tr>
                        <tr>
                            <td></td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Password" style="color:white;"></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Height="29px" TextMode="Password" Width="185px"></asp:TextBox>

                            </td>

                        </tr>
                        <tr>
                            <td></td>
                        </tr>

                        <tr>
                            <td>
                                <asp:Button ID="Button1" runat="server" Text="Login" Height="34px" Style="align-content:center" OnClick="Button1_Click" Width="110px" />
                            </td>
                        </tr>
                        
                    </table><br />
                   
                </div>
            </center>
              
        </form>
   
</asp:Content>
