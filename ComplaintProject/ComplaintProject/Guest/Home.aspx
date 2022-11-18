<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ComplaintProject.Guest.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentBody" runat="server">
    <style>
        h2 {
            margin-top: 100px;
            text-align: center;
            color: blue;
        }

        h4 {
            text-align: center;
            color: blue;
        }

        img {
            width: 500px;
            height: 400px;
            animation-delay: 5s;
            margin-left: 480px;
        }
    </style>
    <body>
        <h2>Welcome to HELPDESK</h2>
        <h4>Online Product Complaint Software</h4>
        <img src="images/cmp.gif" alt="home" />
    </body>
</asp:Content>
