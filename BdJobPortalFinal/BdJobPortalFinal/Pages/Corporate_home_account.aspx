<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="Corporate_home_account.aspx.cs" Inherits="BdJobPortalFinal.Pages.Corporate_home_account" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/corporate_home_content.css" />
    <form id="corporate_account_home_form" runat="server" class="corporate_home_form">
        <asp:Button runat="server" ID="cng_mob" CssClass="home_btn1" Text="Change mobile"/>
        <asp:Button runat="server" ID="cng_email" CssClass="home_btn1" Text="Change email address"/>
        <asp:Button runat="server" ID="cng_address" CssClass="home_btn1" Text="Change Billing Address"/>
        <asp:Button runat="server" ID="cng_pass" CssClass="home_btn1" Text="Change Password"/>
        
    </form>   
    
</asp:Content>