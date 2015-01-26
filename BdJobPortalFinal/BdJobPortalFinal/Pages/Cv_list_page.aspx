<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="Cv_list_page.aspx.cs" Inherits="BdJobPortalFinal.Pages.Cv_list_page" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="../Css/tables.css" />
    <table  class="table">
        <tr class="head">
            <td class="td_name">Name</td><td class="td_age">Present Salary</td><td class="td_exp">Expected Salary</td><td class="td_link">Cv Link</td>
        </tr>
         
            <%for(int i=0;i<cvList.counter;i++)%><%{%>
               <tr class="r<%=Convert.ToString(i%2)%>">
                  <td class="td_name"><%=cvList.Cv_name[i]%></td><td class="td_age"><%=Convert.ToString(cvList.Present_salary[i]) %></td><td class="td_exp"><%=Convert.ToString(cvList.Expected_salary[i]) %></td><td class="td_link"><a href="http://localhost:26799/Pages/ViewCvMaster.aspx?id=<%=cvList.Cv_id[i]%>">View Cv</a></td>
               </tr>
             <%}%> 
         
       
       
    </table>
    
    
</asp:Content>