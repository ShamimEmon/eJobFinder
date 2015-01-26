<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/JobSeeker.Master" CodeBehind="AddSkill.aspx.cs" Inherits="BdJobPortalFinal.Pages.AddSkill" %>


<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <link rel="stylesheet" href="../Css/tables.css"/>
    <link rel="stylesheet" href="../Css/update_style.css"/>
    <form runat="server" class="add_info" id="add_education">
    <table class="table">
       <%for( int i=0;i<skills.Counter;i++) %><%{ %>
      <tr><td><%=skills.Description[i] %></td></tr>
        <%} %>
    </table>
     <div class="update_form2">
         <p class="tag2" runat="server" id="err_msg"></p>
         <p class="tag">Skill</p><input type="text" runat="server" id="skill" class="current"/>
         <asp:Button ID="finish" CssClass="update_btn2" runat="server" Text="Finish"/>
         <asp:Button ID="addAnother" CssClass="update_btn2" runat="server" Text="Add"/>
         <asp:Button ID="removeAnother" CssClass="update_btn2" runat="server" Text="Remove" />
     </div>
    </form>
    
</asp:Content>
