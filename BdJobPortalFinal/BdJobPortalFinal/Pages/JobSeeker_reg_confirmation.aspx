<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="JobSeeker_reg_confirmation.aspx.cs" Inherits="BdJobPortalFinal.Pages.JobSeeker_reg_confirmation" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/confirmation.css" />
    <form runat="server" id="reg_confirmatio_form" class="confirmation_form">
        <div class=" title_"><p class="tag">Confirmation</p></div>
        <p class="tag">Your Account has been created</p>
        <p class="tag">Your Account:<%=account.Acc_id %></p>
        <p class="tag">Your Password:<%=account.Acc_pass %></p>
        <p class="tag">Make sure you add following information(s):</p>
         <ul>
             <li class="tag">Educational Information</li>
             <li class="tag">Skills,Careerer Summary</li>
         </ul>
        <asp:Button runat="server" Text="Ok" ID="ok" CssClass="ok" />
    </form>
    
</asp:Content>
