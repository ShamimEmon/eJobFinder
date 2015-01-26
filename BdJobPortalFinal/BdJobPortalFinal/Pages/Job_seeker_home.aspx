<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="Job_seeker_home.aspx.cs" Inherits="BdJobPortalFinal.Pages.Job_seeker_home" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/corporate_home_style.css"/>
    <link rel="stylesheet"  href="../Css/corporate_reg_style.css"/>
    <h2 class="heading">Job Seeker Home</h2>
    <form class="corporate_div" runat="server" id="corporate_form">
    <asp:Button runat="server" ID="b1" Text="View Job Suggestion" CssClass="button" />
    <asp:Button runat="server" ID="b2" Text="Update Profile" CssClass="button" />
    <asp:Button runat="server" ID="b3" Text="Change Password" CssClass="button" />
    </form>
</asp:Content>

