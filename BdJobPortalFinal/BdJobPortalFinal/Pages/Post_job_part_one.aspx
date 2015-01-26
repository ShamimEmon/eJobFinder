<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Pages/Corporate.Master" CodeBehind="Post_job_part_one.aspx.cs" Inherits="BdJobPortalFinal.Pages.Post_job_part_one" %>

<asp:Content ID="one" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../Css/post_job_style.css" />
    <link rel="stylesheet"  href="../Css/corporate_reg_style.css"/>
    <div runat="server" visible="false" id="err_div_2" class="err_div_2">
    <ul>
    <p class="lister">You have one or more of the following errors:</p>
    <li class="err" runat="server" id="err1">Require All Fields</li>
    <li class="err" runat="server" id="err2">Deadline must be a valid date,Salary must be in valid number format</li>
    </ul>
    </div>
    <form runat="server" id="post_job_part_one_form" class="post_job_part_one_form">
        <div class="inner_div">
         <div class="info_div_odd">
         <div class="div_parts" ><p class="text">Add Type</p></div>
         <div class="div_parts_right">
             <select class="select" runat="server" id="add_type">
                 <option value="1">Normal Add</option>
                 <option value="2">Hot Add</option>
             </select>
         </div>
         </div>
        <!-- <div class="info_div_even">
            <div class="div_parts"><p class="text">Job </p></div>
            <div class="div_parts_right">
             <select class="select" runat="server" id="job_category">
                 <option value="one">Full Time</option>
                 <option value="two">Part Time</option>
             </select>
            </div>
         </div>-->
         <div class="info_div_odd">
            <div class="div_parts"><p class="text">Job Category</p></div>
            <div class="div_parts_right">
             <select class="select" runat="server"  id="job_type">
                 <option value="1" >Software Engineer</option>
                 <option value="2">Web Developer</option>
                 <option value="3">Accountant</option>
                 
             </select>
            </div>
         </div>
         <div class="info_div_even"> 
             <div class="div_parts"><p class="text">Job Title</p></div>
             <div class="div_parts_right">
                <input type="text" class="input" runat="server" id="job_title" />
              </div>
         </div>
         
         <div class="info_div_odd"> 
             <div class="div_parts"><p class="text">Location</p></div>
             <div class="div_parts_right">
                <input type="text" class="input" runat="server" id="location" />
              </div>
         </div>

            <div class="info_div_odd">
                <div class="div_parts"><p class="text">No of Vacancies</p></div>
                <div class="div_parts_right"><input type="text" class="input_small" runat="server" id="vacancies" /></div>
            </div>

            <div class="info_div_even">
                <div class="div_parts"><p class="text">How do you want to Receive CV?</p></div>
                <div class="div_parts_right">
                    <input type="checkbox"  name="cb" class="checkbox" runat="server" id="cvtype_one"/><p class="text_2">Email attatchment</p>
                    <input type="checkbox"  name="cb" class="checkbox" runat="server" id="cv_type_two" /><p class="text_2">Online CV</p>
                    <input type="checkbox"  name="cb" class="checkbox" runat="server" id="cv_type_three" /><p class="text_2">Hard Copy</p>
                </div>
            </div>

           <div class="info_div_odd">
               <div class="div_parts"><p class="text">Picture Required?</p></div>
               <div class="div_parts_right">
                   <input type="radio"  name="cb2" class="checkbox" runat="server" id="pic_yes" value="yes"/><p class="text_2">Yes</p>
                    <input type="radio"  name="cb2" class="checkbox"  runat="server" id="pic_no" value="no"/><p class="text_2">No</p>  
               </div>
           </div>
          
        <div class="info_div_even">
            <div class="div_parts"><p class="text">Deadline</p></div>
             <div class="div_parts_right">
                <input type="text" class="input_small" runat="server" id="deadline" />
              </div>
        </div>
        
       <!-- <div class="info_div_odd">
            <div class="div_parts"><p class="text">Billing Contact</p></div>
             <div class="div_parts_right">
                <input type="text" class="input" runat="server" id="billing_contact"/>
              </div>
        </div>
        
        <div class="info_div_even">
            <div class="div_parts"><p class="text">Designation</p></div>
             <div class="div_parts_right">
                <input type="text" class="input" runat="server" id="designation" />
              </div>
        </div>-->

        <div class="info_div_odd">
            <div class="div_parts"><p class="text">Age Range</p></div>
             <div class="div_parts_right">
                <p class="text">From</p><input type="text" class="input_small" runat="server" id="from"/>
                <p class="text">To</p><input type="text" class="input_small" runat="server" id="to"/>
              </div>
        </div>

         <div class="info_div_even">
            <div class="div_parts"><p class="text">Experience</p></div>
             <div class="div_parts_right">
                <p class="text">Atleast</p><input type="text" class="input_small" runat="server" id="min_exp"/>
                <p class="text">At most</p><input type="text" class="input_small" runat="server" id="max_exp"/>
              </div>
        </div>

        <div class="info_div_odd">
               <div class="div_parts"><p class="text">Job Nature</p></div>
               <div class="div_parts_right">
                   <input type="radio"  name="cb5" class="checkbox" runat="server" id="job_nature_one"/><p class="text_2">Full Time</p>
                    <input type="radio"  name="cb5" class="checkbox" runat="server" id="job_nature_two" /><p class="text_2">Part Time</p>  
                    <input type="radio"  name="cb5" class="checkbox" runat="server" id="job_nature_three" /><p class="text_2">Contract</p>  
               </div>
           </div>
        <div class="info_div_even">
            <div class="div_parts"><p class="text">Salary</p></div>
             <div class="div_parts_right">
                <p class="text">Min</p><input type="text" class="input" runat="server" id="salary" />
                <p class="text"> Max</p><input type="text" class="input" runat="server" id="salmax" />
              </div>
        </div>
        
            
        <div class="info_div_odd">
               <div class="div_parts"><p class="text">Gender</p></div>
               <div class="div_parts_right">
                   <input type="radio"  name="cb3" class="checkbox" runat="server" id="gender_one"/><p class="text_2">Male</p>
                    <input type="radio"  name="cb3" class="checkbox" runat="server" id="gender_two" /><p class="text_2">Female</p>  
                    <input type="radio"  name="cb3" class="checkbox" runat="server" id="gender_three" /><p class="text_2">Both</p>  
               </div>
           </div>

         <div class="info_div_even">
               <div class="div_parts"><p class="text">Job Level</p></div>
               <div class="div_parts_right">
                   <input type="radio"  name="cb4" class="checkbox" runat="server" id="level_one"/><p class="text_2">Entry Level</p>
                   <input type="radio"  name="cb4" class="checkbox" runat="server" id="level_two"/><p class="text_2">Mid Level</p>  
                   <input type="radio"  name="cb4" class="checkbox" runat="server" id="level_three" /><p class="text_2">Senior Level</p>  
               </div>
           </div>
        
        <div class="info_div_large">
           <p class="text">Educational Qualification</p>
           <textarea runat="server" id="education" ></textarea>
        </div>

         <div class="info_div_large">
           <p class="text">Responsibility</p>
           <textarea runat="server" id="responsibility" ></textarea>
        </div>
         <div class="info_div_large">
           <p class="text">Additional Responsibility</p>
           <textarea runat="server" id="addtional_responsibility"></textarea>
        </div>
        </div>

        <asp:Button runat="server" Text="Preview Add" CssClass="button" ID="btn" />
    </form>
    </asp:Content>