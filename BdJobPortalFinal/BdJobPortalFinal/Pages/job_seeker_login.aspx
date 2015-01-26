<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="job_seeker_login.aspx.cs" Inherits="BdJobPortalFinal.Pages.JobSeekerLogin" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/corporate_login_style.css"/>
    <div class="info_div">
        <h3 class="info_div_title">Why Choose eJobSearch.com? </h3>
        <ul >
            <li class="info_div_list">Thousands of job to choose from</li>
            <li class="info_div_list">Advanced Search engine to strength you job hunt</li>
            <li class="info_div_list">Hassle Free,simple interface</li>
            <li class="info_div_list">Smart job suggestion and notification to keep you on track</li>
        </ul>
    </div>
    <form runat="server" class="login_form" id="login_form">
        <h1 class="corporate_login">Job Seeker Login</h1>
     <div class="login_div">
     <p class="err" id="err" runat="server" ></p>
     <p class="title">Seeker Id</p><input type="text" id="user_name" class="input" runat="server"/>
     <p class="title">Password</p><input type="text" id="user_pass" runat="server" class="input" />
     <asp:Button Text="Login" ID="login_button" class="login_button" runat="server" />
     </div>
         <p class="err2">New User?<a href="http://localhost:26799/Pages/Job_seeker_registration.aspx">Click Here For Registration</a></p>
    </form>
   
    
</asp:Content>




