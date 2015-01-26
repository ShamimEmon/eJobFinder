<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="Corporate_registration.aspx.cs" Inherits="BdJobPortalFinal.Pages.Corporate_registration" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet"  href="../Css/corporate_reg_style.css"/>
    <h2 class="heading">Corporate Registration</h2>
    <div runat="server" visible="false" id="err_div" class="err_div">
    <ul>
     <p class="lister">You have one or more of the following errors:</p>
    <li class="err" runat="server" id="err1">Require All Fields</li>
    <li class="err" runat="server" id="err2">Unavailable User Name</li>
    <li class="err" runat="server" id="err3">Password And Re:password doesn't match</li>
    </ul>
    </div>

    <form id="corporate_reg_form" runat="server" class="corporate_ref_form">
     <div class="top_cover"><p class="title">Account Information</p></div>
     <div class="account_info">
         
        <p class="tag" >User Name</p><input runat="server" type="text"  class="input" id="acc_id"/>
         <p class="tag">Password</p><input runat="server" type="text"  class="input" id="acc_pass"/>
         <p class="tag">Re:Password</p><input runat="server" type="text"  class="input" id="acc_pass_re"/>
     </div>
     <div class="top_cover"><p class="title">Company Details</p></div>
     <div class="account_info">
         
        <p class="tag">Comapny  Name</p><input runat="server" type="text" id="company_name" class="input_large"/>
         <p class="tag">Contact Person</p><input runat="server" id="contact_person" type="text"  class="input"/>
         <p class="tag">Designation</p><input runat="server" id="designation" type="text"  class="input"/>
     </div>

    
     <div class="account_info"> 
        <p class="tag">Industry Type</p><input id="industry_type" type="text" runat="server" class="input"/>
     </div>

    <div class="account_info"> 
        <p class="tag">Business Description</p><textarea id="company_description" runat="server" class="text_area"></textarea>
    </div>
    <div class="top_cover"><p class="title">Contact Details</p></div>
    <div class="contact_details"> 

        <p class="tag">Comapny  Address</p><input id="company_address" runat="server" type="text"  class="input_large"/>
         <p class="tag">Country</p><input id="country" runat="server" type="text"  class="input"/>
         <p class="tag">City</p><input id="city" runat="server" type="text"  class="input"/>
        <p class="tag">Area</p><input  id="area" runat="server" type="text"  class="input"/>
         <p class="tag">Billing Address</p><input id="billing_address" runat="server" type="text"  class="input_large"/>
         <p class="tag">Contact Phone</p><input id="contact_phone" runat="server" type="text"  class="input"/>
        <p class="tag">email</p><input id="email" runat="server" type="text"  class="input"/>
        <p class="tag">website</p><input id="website" runat="server" type="text"  class="input_large"/>
       <!-- <input runat="server" type="checkbox" value="1" name="terms" class="terms"  /><p runat="server" class="cond" id="cond">I accept the terms and policies</p><br />-->
        <asp:Button runat="server" ID="register" CssClass="register" Text="Register" />
         
    </div>

    </form>
</asp:Content>