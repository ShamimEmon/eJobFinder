<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="Default.aspx.cs" Inherits="BdJobPortalFinal.Pages.Default" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link rel="stylesheet" href="../Css/default_style.css"/>
    <form id="job_search_form" class="job_search_form" runat="server">
        <div class="search_box_title_div"></div>
     <p class="job_search_err" runat="server" id="job_search_err" visible="false">Please Select All Fields</p>
     <p class="title">Job Type</p><select id="job_type" class="selector" runat="server">
                                            <option value="0">Type</option>
                                            <option value="1">Full Time</option>
                                            <option value="2">Part Time</option>
                                            <option value="3">Contract</option>
                                           </select>
     <p class="title">Category</p><select id="job_category" class="selector" runat="server">
                                             <option value="0">Job Category</option>
                                             <option value="1">Software Engineer</option>
                                             <option value="2">Web Developer</option>
                                             <option value="3">Accountant</option>             
                                  </select>

   
    <p class="title">Salary Range</p><select id="job_salary_range" class="selector" runat="server">
                                            <option value="0">Salary</option>
                                            <option value="1">20,000-35,000</option>
                                            <option value="2">36,000-50,000</option>
                                   
                                           </select>
   <p class="title">Experience</p><select id="job_experience_range" class="selector" runat="server">
                                            <option value="0">Experience</option>
                                            <option value="1">Freshers</option>
                                            <option value="2">2-5 years</option>
                                            <option value="3">5 years+</option>
                                           </select>
   
  <asp:Button text="Search" runat="server" ID="job_search_button" CssClass="job_search_button"/>   
    </form>
    
</asp:Content>
