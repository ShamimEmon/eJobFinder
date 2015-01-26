<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="JobSeekerSearchJobList.aspx.cs" Inherits="BdJobPortalFinal.Pages.JobSeekerSearchJobList" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/tables.css" />
    <table>
        <tr class="head"><td>Title</td><td>No Of Vacancies</td><td>Experience</td><td>Dead Line</td><td>Job Link</td></tr>
        <%for(int i=0;i<addList.Counter;i++) %>
        <%{ %>
            <tr><td><%=addList.JobTitle[i]%></td><td><%=Convert.ToString(addList.NoOfVacancies[i]) %></td><td><%=Convert.ToString(addList.Min_exp[i])+" To "+Convert.ToString(addList.Max_exp[i])+" Years"%></td><td><%=addList.Deadline[i] %></td><td><a href="http://localhost:26799/Pages/JobSeekerSearchJobDescription.aspx?add_id=<%=addList.AddId[i] %>">View Job</a></td></tr>
        <%} %>
        
    </table>
    
</asp:Content>