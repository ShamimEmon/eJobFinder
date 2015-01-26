<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="Corporate_job_home.aspx.cs" Inherits="BdJobPortalFinal.Pages.Corporate_job_home" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/corporate_home_content.css" />
    <form id="corporate_job_home_form" runat="server" class="corporate_home_form">
        <asp:Button runat="server" ID="post_new_job_btn" CssClass="home_btn1" Text="Post New Job"/>
        <asp:Button runat="server" ID="renew_job_add" CssClass="home_btn1" Text="Renew posted Job"/>
    </form>   
    
</asp:Content>