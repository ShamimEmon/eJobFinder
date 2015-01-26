<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="ViewCvMaster.aspx.cs" Inherits="BdJobPortalFinal.Pages.ViewCvMaster" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link rel="stylesheet" href="../Css/cv_style.css" />
    <link rel="stylesheet" href="../Css/tables.css" />
<div class="cv_div">
 <div class="title_div">
     <h3 class="title_tag"><%=cv.Cv_name%></h3>
     <p class="mobile_tag"><b>Mob:</b><%=cv.Cv_mob %></p>
     <p class="email_tag"><b>Email:</b><%=cv.Cv_email %></p>
     <p class="postal_tag"><b>Postal Address:</b><%=cv.Cv_postal_address %></p>
 </div>
 <div class="other_div">
  <h3>Personal Profile</h3>
  <p class="tag"><b>Fathers Name:</b><%=cv.Fathers_name %></p>
  <p class="tag"><b>Mothers Name:</b><%=cv.Mothers_name %></p>
  <p class="tag"><b>Date of Birth:</b><%=Convert.ToString(cv.Cv_dob.ToString("dd/MM/yyyy")) %></p>
  <p class="tag"><b>Gender:</b><%=cv.Gender %></p>
 </div>
  
 <div class="other_div">
  <h3>Current Job</h3>
  <p class="tag"><b>Position:</b><%=this.current_job %></p>
  <p class="tag"><b>Salary:</b><%=cv.Present_salary+" BDT" %></p>
  <p class="tag"><b>Company Name:</b><%=cv.CurrentComapnyName %></p>
  <!--<p class="tag">company Address:<%=cv.CurrentCompanyAddress %></p>-->
  <p class="tag"><b>Start Date:</b><%=cv.StartDate.ToString("dd/MM/yyyy") %></p>
  
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
      <tr class="head"><td class="td_name">Position</td><td class="td_name">Company Name</td><td class="td_age">Start Date</td><td class="td_age">End Date</td></tr>
      <%for(int i=0;i<history.Counter;i++)%><%{ %>
       <tr class="r<%=Convert.ToString(i%2) %>"><td class="td_name"><%=history.Position[i]%></td><td class="td_name"><%=history.CompanyName[i]%></td><td class="td_age"><%=history.StartDate[i].ToString("dd/MM/yyyy")%></td><td class="td_age"><%=history.EndDate[i].ToString("dd/MM/yyyy")%></td></tr>
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
  <tr class="head"><td>Degree Name</td><td>Score</td><td>Year</td></tr>
  <%for (int i = 0; i < qualification.counter;i++ ) %><%{ %>
  <tr class="r<%=Convert.ToString(i%2) %>"><td><%=qualification.Degree_name[i]%></td><td><%=qualification.Score[i]%></td><td><%=qualification.Year[i]%></td></tr>
  <%} %>
  </table>
  
 </div>
 <div class="other_div">
  <h3>Language Skills</h3>
  <p class="tag">
      <%=cv.Cv_language_skills %>
  </p>
 </div>
 <!--<div class="other_div">
  <h3>other Skills Skills</h3>
   <p class="tag">
      <%=cv.Cv_other_skills %>
  </p>
 </div>-->
 </div>

</asp:Content>
