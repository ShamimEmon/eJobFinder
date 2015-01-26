<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="AddAcademicQualification.aspx.cs" Inherits="BdJobPortalFinal.Pages.AddAcademicQualification" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/tables.css"/>
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <form runat="server" class="add_info" id="add_education">
    <table class="table">
        <tr class="head"><td>Degree Name</td><td>Institution Name</td><td>Score</td><td>Pass Year</td></tr>
        <%for(int i=0;i<qualification.counter;i++)%>
        <%{ %>
         <tr class="r<%=Convert.ToString((i%2))%>"><td><%=qualification.Degree_name[i]%></td><td><%=qualification.Academic_Institute[i] %></td><td><%=qualification.Score[i] %></td><td><%=qualification.Year[i] %></td></tr>
        <%} %>
    </table>
     <div class="update_form2">
         <p class="tag2" runat="server" id="err_msg"></p>
         <p class="tag">Degree Name</p><input type="text" runat="server" id="deg" class="current"/><p class="tag">Institute</p><input type="text" runat="server" id="institute" class="current"/><p class="tag">Score</p><input runat="server" id="score" class="current" type="text"/><p class="tag">Pass Year</p><input runat="server" id="year" class="current" type="text"/>
         <asp:Button ID="finish" CssClass="update_btn2" runat="server" Text="Finish"/>
         <asp:Button ID="addAnother" CssClass="update_btn2" runat="server" Text="Add"/>
         <asp:Button ID="removeAnother" CssClass="update_btn2" runat="server" Text="Remove" />
     </div>
    </form>
    
</asp:Content>