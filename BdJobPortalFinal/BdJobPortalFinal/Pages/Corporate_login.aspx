<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="Corporate_login.aspx.cs" Inherits="BdJobPortalFinal.Pages.Corporate_login" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/corporate_login_style.css"/>
    <div class="info_div">
        <h3 class="info_div_title">Why Choose eJobSearch.com? </h3>
        <ul >
            <li class="info_div_list">One of the most dymic,rapidly growing website</li>
            <li class="info_div_list">Thousands of Cv to choose from</li>
            <li class="info_div_list">Hassle Free,simple interface</li>
            <li class="info_div_list">Cheap yet convinient tool</li>
        </ul>
    </div>
    <form runat="server" class="login_form" id="login_form">
        <h1 class="corporate_login">Corporate Login</h1>
     <div class="login_div">
     <p class="err" id="err" runat="server"></p>
     <p class="title">Corporate Id</p><input runat="server" type="text" class="input" id="user_name" />
      <p class="title">Password</p><input runat="server" type="text" class="input" id="user_pass" />
      <asp:Button Text="Login" ID="login_button" class="login_button" runat="server"/>
     </div>
         <p class="err2">New User?<a href="http://localhost:26799/Pages/Corporate_registration.aspx">Click Here For Registration</a></p>
    </form>
    <div class="info_div"><h3 class="info_div_title">Offering and Pricing</h3>
        <ul>
            <li class="info_div_list">Hot Job(s):15000BDT(10 Days).500BDT/day after 10 days</li>
            <li class="info_div_list">Normal Job(s):8000BDT(20 Days).500BDT/day after 20 days</li>
            

        </ul>
    </div>
     <div class="info_div">
        <h3 class="info_div_title">Payment Methos</h3>
        <p class="info_div_paragraph">We are Currently Accepting Payment via Bkash,Ucash only.</p>
    </div>
    
</asp:Content>