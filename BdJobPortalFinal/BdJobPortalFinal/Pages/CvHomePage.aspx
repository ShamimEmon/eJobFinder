<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="CvHomePage.aspx.cs" Inherits="BdJobPortalFinal.Pages.CvHomePage" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/corporate_home_content.css" />
    <form id="corporate_account_home_form" runat="server" class="corporate_home_form">
        <asp:Button runat="server" ID="add_academic_qualification" CssClass="home_btn1" Text="Add Academic Qualification"/>
        <asp:Button runat="server" ID="add_job_history" CssClass="home_btn1" Text="Add Job History"/>
        <asp:Button runat="server" ID="update_current_job" CssClass="home_btn1" Text="Update Current Job"/>
        <asp:Button runat="server" ID="view_cv" CssClass="home_btn1" Text="View My CV"/>
        <asp:Button runat="server" ID="add_skill" CssClass="home_btn1" Text="Add Skill"/>
        
    </form>   
    
</asp:Content>