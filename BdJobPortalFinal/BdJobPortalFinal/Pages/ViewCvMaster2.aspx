<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="ViewCvMaster2.aspx.cs" Inherits="BdJobPortalFinal.Pages.ViewCvMaster2" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="../Css/cv_style.css" />
<div class="cv_div">
 <div class="title_div">
     <h3 class="tag"><%=cv.Cv_name%></h3>
     <p>Mob:<%=cv.Cv_mob %></p>
     <p>Email:<%=cv.Cv_email %></p>
     <p>Postal Address:<%=cv.Cv_postal_address %></p>
 </div>
 <div class="other_div">
  <h3>Personal Profile</h3>
  <p class="tag"><%=cv.Fathers_name %></p>
  <p class="tag"><%=cv.Mothers_name %></p>
  <p class="tag"><%=Convert.ToString(cv.Cv_dob) %></p>
  <p class="tag">Gender:<%=cv.Gender %></p>
 </div>
  
 <div class="other_div">
  <h3>Current Job</h3>
  <p class="tag">Position:<%=this.current_job %></p>
  <p class="tag">Salary:<%=cv.Present_salary %></p>
  <p class="tag">Company Name:<%=cv.CurrentComapnyName %></p>
  <p class="tag">company Address:<%=cv.CurrentCompanyAddress %></p>
  <p class="tag">Start Date:<%=cv.StartDate.Date.Day+"/"+cv.StartDate.Date.Month+"/"+cv.StartDate.Year %></p>
  
 </div>
  <div class="other_div">
  <h3>Skills</h3>
 <ul>
     <%for(int i=0;i<skills.Counter;i++) %><%{ %>
      <li><%=skills.Description[i]%></li>
     <%} %>
 </ul>
  
 </div>
 <div class="other_div">
  <h3>Career History</h3>
  <table>
      <tr><td>Position</td><td>Company Name</td><td>Company Address</td><td>Start Date</td><td>End Date</td></tr>
      <%for(int i=0;i<history.Counter;i++)%><%{ %>
       <tr><td><%=history.Position[i]%></td><td><%=history.CompanyName[i]%></td><td><%=history.CompanyLoc[i]%></td><td><%=history.StartDate[i]%></td><td><%=history.EndDate[i]%></td></tr>
      <%}%>
  </table>
  
 </div>
 
 <div class="other_div">
  <h3>Career Objective</h3>
  <p class="tag">
      <%=cv.Career_objective %>
  </p>
 </div>
 <div class="other_div">
  <h3>Educational Skills</h3>
  <table>
  <tr><td>Degree Name</td><td>Score</td><td>Year</td></tr>
  <%for (int i = 0; i < qualification.counter;i++ ) %><%{ %>
  <tr><td><%=qualification.Degree_name[i]%></td><td><%=qualification.Score[i]%></td><td><%=qualification.Year[i]%></td></tr>
  <%} %>
  </table>
  
 </div>
 <div class="other_div">
  <h3>Language Skills</h3>
  <p class="tag">
      <%=cv.Cv_language_skills %>
  </p>
 </div>
 <div class="other_div">
  <h3>other Skills Skills</h3>
   <p class="tag">
      <%=cv.Cv_other_skills %>
  </p>
 </div>
 </div>


</asp:Content>