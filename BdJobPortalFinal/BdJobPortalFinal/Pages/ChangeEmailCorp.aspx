<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="ChangeEmailCorp.aspx.cs" Inherits="BdJobPortalFinal.Pages.ChangeEmailCorp" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <div class="acc_err_div" runat="server" id="acc_err_div" visible="false">
        
        <p>You have one or more of the following errors:</p>
        <ul>
            <li>Require all fields</li>
            <li>current email is incorrect</li>
            <li>New email and Re:email is not same</li>
        </ul>
    </div>
    <form id="update_mob_form"  runat="server" class="update_form">
     <p class="tag">Current Email</p><input type="text" runat="server" id="current_email" class="current"/>
     <p class="tag">New Email</p><input type="text" runat="server" id="new_email" class="current"/>
     <p class="tag">Re:new Email</p><input type="text" runat="server" id="re_email" class="current"/>
     <asp:Button Text="Change" ID="update_btn" runat="server" CssClass="update_btn"/>
    </form>
    
</asp:Content>