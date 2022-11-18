<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="RegUser.aspx.cs" Inherits="ComplaintProject.Guest.RegUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
   
        <h2 style="margin-left: 500px;margin-top:200px;">User Registration</h2>
        <form id="form1" runat="server">
            <center>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
                        </td>
                        <td>

                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your name" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator><br />
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>

                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Email" Width="184px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your email" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid format" ControlToValidate="TextBox2" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator><br />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
                        </td>
                        <td>

                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Phone" Width="184px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Phone number" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator><br />

                        </td>
                        <td>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please check your Number" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                        </td>
                       
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                        </td>
                        <td>

                            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
                            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female" />
                            <asp:RadioButton ID="RadioButton3" runat="server" GroupName="gender" Text="Others" />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>

                            <asp:Label ID="Label6" runat="server" Text="User Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox4" runat="server" Width="184px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Username" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator><br />
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label8" runat="server" Text="Password"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" Width="184px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please enter your Password" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Confirm Password"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox ID="confirmpass" runat="server" Width="184px" TextMode="Password"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator runat="server" ErrorMessage="Please confirm your Password" ControlToValidate="confirmpass" ForeColor="Red"></asp:RequiredFieldValidator>

                        </td>
                        <td>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords are not matching" ControlToCompare="TextBox5" ControlToValidate="confirmpass" ForeColor="Red"></asp:CompareValidator>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Button1" runat="server" Text="Register" Height="38px" Style="margin-left: 88px" Width="145px" OnClick="Button1_Click" />
                        </td>
                    </tr>
                </table>
            </center><br />
             <asp:Label ID="lblmessage" runat="server" Style="color: #FF6666; font-weight: 700; margin-left: 400px;"></asp:Label>

        </form>
   
</asp:Content>
