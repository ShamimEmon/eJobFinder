<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="AddEmploymentHistory.aspx.cs" Inherits="BdJobPortalFinal.Pages.AddEmploymentHistory" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/tables.css"/>
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <form runat="server" class="add_info" id="add_education">
    <table class="table">
        <tr class="head"><td>Company Name</td><td>Position</td><td>Start Date</td><td>End Date</td></tr>
        <%for(int i=0;i<history.Counter;i++)%>
        <%{ %>
         <tr class="r<%=Convert.ToString((i%2))%>"><td><%=history.CompanyName[i] %></td><td><%=history.Position[i] %></td><td><%=history.StartDate[i]%></td><td><%=history.EndDate[i]%></td></tr>
        <%} %>
    </table>
     <div class="update_form2">
         <p class="tag2" runat="server" id="err_msg"></p>
         <p class="tag">Company Name</p><input type="text" runat="server" id="company" class="current"/><p class="tag">Position</p><input type="text" runat="server" id="position" class="current"/><p class="tag">Start Date</p><input runat="server" id="sdate" class="current" type="text"/><p class="tag">End Date</p><input runat="server" id="edate" class="current" type="text"/>
         <asp:Button ID="finish" CssClass="update_btn2" runat="server" Text="Finish"/>
         <asp:Button ID="addAnother" CssClass="update_btn2" runat="server" Text="Add"/>
         <asp:Button ID="removeAnother" CssClass="update_btn2" runat="server" Text="Remove" />
     </div>
    </form>
    </asp:Content>
    