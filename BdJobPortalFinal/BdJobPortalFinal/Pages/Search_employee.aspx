<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="Search_employee.aspx.cs" Inherits="BdJobPortalFinal.Pages.Search_employee" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <form id="update_mob_form"  runat="server" class="update_form">
     <p class="tag">job Category</p><select id="job_category" class="current" runat="server">
                                     <option value="0">Any</option>
                                     <option value="1" >Software Engineer</option>
                                     <option value="2">Web Developer</option>
                                     <option value="3">Accountant</option>
                                    </select>
    
     <asp:Button Text="Search" ID="search_button" runat="server" CssClass="update_btn"/>
    </form>
</asp:Content>

