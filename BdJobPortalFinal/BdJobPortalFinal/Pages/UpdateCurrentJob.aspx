<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="UpdateCurrentJob.aspx.cs" Inherits="BdJobPortalFinal.Pages.UpdateCurrentJob" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <form runat="server" id="updateJob" class="add_info">
        <div class="update_form2">
         <p class="tag2" runat="server" id="err_msg"></p>
         <p class="tag">Position</p><select class="current" runat="server" id="pos">
                                     <option value="0">Select Position</option>
                                     <option value="1">Software Engineer</option>
                                     <option value="2">Web Developer</option>
                                    </select><p class="tag">Date Joined</p><input type="text" runat="server" id="join_date" class="current"/><p class="tag">Company Name</p><input runat="server" id="company_name" class="current" type="text"/><p class="tag">salary</p><input runat="server" id="salary" class="current" type="text"/>
         <asp:Button ID="finish" CssClass="update_btn2" runat="server" Text="Update"/>
        </div>
         
    </form>
    
</asp:Content>