<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="JobSeekerSearchJobDescription.aspx.cs" Inherits="BdJobPortalFinal.Pages.JobSeekerSearchJobJobDescription" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/job_add_style.css" />
   
    <form id="form1" runat="server">
    <div class="job_add_div">
       <p class="title"><%=company_name%></p>
       <p class="job_title"><%=add.JobTitle %></p>
       <p class="tag">No of Vacancies</p><p class="desc"><%=Convert.ToInt32(add.NoOfVacancies)%></p>
       <p class="tag">Job Responsibilities</p>
        <ul>
           <%
                string[] requirements = GetResponsibility();
                for (int i = 0; i < requirements.Length; i++)
                    Response.Write("<li class=" + "\"list\"+>" + requirements[i] + "</li>");
            %>
        </ul>

        
        
       <p class="tag">Job Nature</p>
        <p class="desc"><%=add.Job_nature %></p>
        <p class="tag">Job Level:</p><p class="desc"><%=add.JobLevel %></p>
        <p class="tag">Age Range</p><p class="desc"><%=add.AgeFrom+" To "+add.AgeTo %></p>
        <p class="tag">Experience</p><p class="desc"><%=add.Min_exp+" To "+add.Max_exp%></p>
        <p class="tag">Gender</p><p class="desc"><%=add.GenderPreference %></p>
         <p class="tag">Location</p><p class="desc"><%=add.Location%></p>
        

        <p class="tag">Salary</p><p class="desc"><%=Convert.ToString(add.Sal)+" To "+Convert.ToString(add.SalMax) %></p>
        
        <p class="tag">Educational Requirement</p>
        <ul >
            <%
                
                string[] educationalRequirements = GetEducationalRequirements();
                for (int i = 0; i < educationalRequirements.Length; i++)
                    Response.Write("<li class="+"\"list\"+>" + educationalRequirements[i] + "</li>");
            %>

           
           

        </ul>

        

        <p class="tag">Additional Requirement</p>
        <ul>
           <%
                string[] AdditionalRequirements = GetAddditionalResponsibility();
                for (int i = 0; i < AdditionalRequirements.Length; i++)
                    Response.Write("<li class=" + "\"list\"+>" + AdditionalRequirements[i] + "</li>");
            %>
        </ul>

       
    </div>
    <div class="apply_for_job_div">
        <p class="email">Email your Cv To:</p><p class="email"><%=email%></p>
        <p class="or">Or</p>
        <asp:Button ID="apply_online_button" CssClass="apply_online_button" runat="server" Text="Apply Online"/>
    </div>
    </form>
    
</asp:Content>