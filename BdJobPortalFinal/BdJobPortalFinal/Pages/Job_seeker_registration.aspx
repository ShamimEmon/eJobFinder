<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Top_level.Master" CodeBehind="Job_seeker_registration.aspx.cs" Inherits="BdJobPortalFinal.Pages.Job_seeker_registration" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <link rel="stylesheet" href="../Css/corporate_reg_style.css" />
    <h2 class="heading">Job Seeker Registration</h2>
    <div class="err_div" visible="false" runat="server" id="err_div">
       <ul >
           <li class="err">Please Fill all the fields</li>
           <li class="err">Date Must be in valid format</li>
       </ul>
      
    </div>
    <form id="corporate_ref_form_2" runat="server" class="corporate_ref_form">
        <div class="top_cover"><p class="title">Personal Information</p></div>
        <div class="contact_details_large">
            <p class="tag">Name</p><input type="text" runat="server" id="name" class="input_large"/>
            <p class="tag"> Father's Name</p><input type="text" runat="server" id="fathers_name" class="input_large"/>
            <p class="tag">Mother's Name</p><input type="text" runat="server" id="mothers_name"  class="input_large"/>
            <p class="tag">DOB</p><input type="text"  runat="server" id="dob" class="input"/>
            <p class="tag">Gender</p><input type="text" runat="server" id="gender" class="input"/>
            <!--<p class="tag">Maretial Stastus</p><input type="text" runat="server" id="maritial_stastus"  class="input"/>-->
            <p class="tag">National ID No</p><input type="text" runat="server" id="nid" class="input"/>
            <!--<p class="tag">Religion</p><input type="text" runat="server" id="religion" class="input"/>-->
            <p class="tag">Current Address</p><asp:TextBox runat="server"  ID="cur_add" Columns="5" Rows="5" TextMode="multiline" class="text_area"/>
            <p class="tag">Permanent Address</p><asp:TextBox runat="server"  ID="per_add" Columns="5" Rows="5" TextMode="multiline" class="text_area"/>
            <p class="tag">Mobile</p><input type="text" runat="server" id="mob"  class="input"/>
            <p class="tag">email</p><input type="text" runat="server" id="email"  class="input"/>
        </div>

        <div class="top_cover"><p class="title">Career Information</p></div>
        <div class="contact_details">
            <p class="tag">Career Objective</p><asp:TextBox runat="server"  ID="career_obj" Columns="5" Rows="5" TextMode="multiline" class="text_area"/>
            <p class="tag">Language Skills</p><asp:TextBox runat="server"  ID="language_skills" Columns="5" Rows="5" TextMode="multiline" class="text_area"/>
            <p class="tag">Other Skills</p><asp:TextBox runat="server"  ID="other_skills" Columns="5" Rows="5" TextMode="multiline" class="text_area"/>  
            <p class="tag">Present Position</p><select runat="server" id="current_job" class="input">
                                                  <option value="0">Select Your Job</option>
                                                  <option value="1">Software Engineer</option>
                                                  <option value="2">Web Developer</option>
                                                </select>
            <p class="tag">Company Name</p><input type="text"  runat="server" id="current_company" class="input"/>
            <p class="tag">Company Address</p><input type="text"  runat="server" id="current_company_address" class="input_large"/>
             <p class="tag">Present Salary</p><input type="text"  runat="server" id="present_sal" class="input"/>
            <p class="tag">Expected Salary</p><input type="text"  runat="server" id="exp_sal" class="input"/>
            <p class="tag">Looking For</p><select runat="server" id="looking_for" class="input">
                                                  <option value="0">Select Your Job</option>
                                                  <option value="1">Software Engineer</option>
                                                  <option value="2">Web Developer</option>
                                                </select> 
            <p class="tag">Available For</p><select runat="server" id="job_nature" class="input">
                                                  <option value="0">Select Job Nature</option>
                                                  <option value="1">Full Time</option>
                                                  <option value="2">Part Time</option>
                                                  <option value="3">Contract</option>
                                                </select> 
        </div>

        <div class="top_cover"><p class="title">Preferred Jobs</p></div> 
        <div class="account_info"> 
        <input type="checkbox" value="1" name="terms" class="terms_2" runat="server" id="one_ckbx" /><p class="cond_2">Software Development</p>
        <input type="checkbox" name="terms" value="2" class="terms_2" id="two_ckbx"  runat="server" /><p class="cond_2">Web Development</p>
       
     </div>

     <div class="top_cover"><p class="title">Preferred Location</p></div> 
        <div class="account_info"> 
        <input type="checkbox" value="1" name="terms" class="terms_2" runat="server" id="one_cxk2" /><p class="cond_2">Dhaka</p>
        <input type="checkbox" name="terms" value="1" class="terms_2" runat="server" id="two_cxk2"/><p class="cond_2">Chittagon</p>
        <input type="checkbox" name="terms" value="1" class="terms_2" runat="server" id="three_cxk2" /><p class="cond_2">Rajshahi</p>
        <input type="checkbox" value="1" name="terms" class="terms_2" runat="server" id="four_cxk2"/><p class="cond_2">Sylhet</p>
        
     </div>

     <!--<div class="top_cover"><p class="title">Career Information</p></div>-->
       <asp:Button runat="server" ID="register_button" CssClass="register" Text="Register" />
        <!-- <div class="contact_details">
            <p class="tag">Career Summary</p><textarea class="text_area"></textarea>
            <p class="tag">Educational Qualifications</p><textarea class="text_area"></textarea>
            <p class="tag">Special Qualifications</p><textarea class="text_area"></textarea>

            <input type="radio" value="1" name="terms" class="terms" /><p class="cond">I accept the terms and policies</p><br />
        <input type="radio" name="terms" value="1" class="terms" /><p class="cond">I decline the terms and policies</p>
        <asp:Button runat="server" ID="register" CssClass="register" Text="Register" />
         
              
        </div>-->



    </form>
</asp:Content>