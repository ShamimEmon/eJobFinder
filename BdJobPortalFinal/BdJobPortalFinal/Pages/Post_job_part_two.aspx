<%@ Page Language="C#"  AutoEventWireup="true"  CodeBehind="Post_job_part_two.aspx.cs" MasterPageFile="~/Pages/Corporate.Master"  Inherits="BdJobPortalFinal.Pages.Post_job_part_two" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/job_add_style.css" />
   
    <form id="form1" runat="server">
    <div class="job_add_div">
       <p class="title"><%=GetComapnyName() %></p>
       <p class="job_title"><%=GetJobTitle() %></p>
       <p class="tag">No of Vacancies</p><p class="desc"><%=GetVacancies()%></p>
       <p class="tag">Job Responsibilities</p>
        <ul>
           <%
                string[] requirements = GetResponsibility();
                for (int i = 0; i < requirements.Length; i++)
                    Response.Write("<li class=" + "\"list\"+>" + requirements[i] + "</li>");
            %>
        </ul>

        
        
       <p class="tag">Job Nature</p>
        <p class="desc"><%=GetJobNature() %></p>
        <p class="tag">Job Level:</p><p class="desc"><%=GetJobLevel() %></p>
        <p class="tag">Age Range</p><p class="desc"><%=GetMaxAge()+"To "+GetMaxAge()%></p>
        <p class="tag">Experience</p><p class="desc"><%=add.Min_exp+" To "+add.Max_exp %></p>
        <p class="tag">Gender</p><p class="desc"><%=GetGender() %></p>
         <p class="tag">Location</p><p class="desc"><%=GetLocation() %></p>
        

        <p class="tag">Salary</p><p class="desc"><%=GetSalaries()%> To <%=Convert.ToString(add.SalMax )%></p>
        
        <p class="tag">Educational Requirement</p>
        <ul >
            <%
                //string list = "<li>";
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
        <!--<p class="email">Email your Cv To:</p><p class="email">Email Address</p>
        <p class="or">Or</p>-->
        <asp:Button ID="apply_online_button" CssClass="apply_online_button" runat="server" Text="Post Job"/>
    </div>
    </form>
    
</asp:Content>