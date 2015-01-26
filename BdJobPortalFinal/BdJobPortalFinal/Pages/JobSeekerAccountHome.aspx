<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="JobSeekerAccountHome.aspx.cs" Inherits="BdJobPortalFinal.Pages.JobSeekerAccountHome" %>
<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<link rel="stylesheet" href="../Css/corporate_home_content.css" />
    <form id="corporate_job_home_form" runat="server" class="corporate_home_form">
        <asp:Button runat="server" ID="changeMob" CssClass="home_btn1" Text="Change Mobile Number"/>
        <asp:Button runat="server" ID="changeEmail" CssClass="home_btn1" Text="Change Email"/>
        <asp:Button runat="server" ID="cng_pass" CssClass="home_btn1" Text="Change Password"/>
 </form> 
</asp:Content>  
    