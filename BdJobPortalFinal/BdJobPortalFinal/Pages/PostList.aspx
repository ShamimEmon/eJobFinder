<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="PostList.aspx.cs" Inherits="BdJobPortalFinal.Pages.PostList" %>


 

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/tables.css"/>
    <table>
         <tr class="head"><td>Job Title</td><td>Post Date</td><td>Applications</td></tr>
         <%for(int i=0;i<post.Counter;i++) %>
          <%{ %>
              <tr class="r<%=Convert.ToString(i%2)%>"><td><%=post.JobTitle[i]%></td><td><%=post.PostDate[i]%></td><td><a href="http://localhost:26799/Pages/Application_list_page.aspx?add_id=<%=post.Add_id[i]%>">Click Here</a></td></tr>
          <%}%>
     </table>
</asp:Content>