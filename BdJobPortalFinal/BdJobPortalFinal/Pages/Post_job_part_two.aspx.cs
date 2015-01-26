using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class Post_job_part_two : System.Web.UI.Page
    {
        public Add add = new Add();
        private JobPoster poster = new JobPoster();
        private string company_name="";
       
       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                RetriveObjectFromSession();
                this.company_name = GetComapnyName();
               
            }
            catch (NullReferenceException) { }
            apply_online_button.Click += PostjobListener;
            Logger logger = new Logger();
            logger.IsLoggout();
            
        }


       
        public void PostjobListener(object sender, EventArgs e) 
        {
            PostJobToDatabaseCB(this.add);
            Response.Redirect("http://localhost:26799/Pages/Payment_page.aspx");
        }
        public void PostJobToDatabaseCB(Add add)
        {
            poster.PostJobToDatabaseBL(add);
        }
        public string GetJobTitle() 
        {
            if (add == null)
                return "";
            return this.add.JobTitle;
        }
        public string GetJobLevel() 
        {
            if (add == null)
                return "";
            return this.add.JobLevel;
        }
        public string GetMinAge() 
        {
            if (add == null)
                return "";
            return Convert.ToString(this.add.AgeFrom);
        }
        public string GetMaxAge()
        {
            if (add == null)
                return "";
            return Convert.ToString(this.add.AgeTo);
        }
        public string GetMinExp() 
        {
            if (add == null)
                return "";
            return Convert.ToString(this.add.Min_exp);
        }
        public string GetMaxExp()
        {
            if (add == null)
                return "";
            return Convert.ToString(this.add.Max_exp);
        }
        public string GetGender()
        {
            if (add == null)
                return "";
            return this.add.GenderPreference; 
        }
        
       
        public string[] GetResponsibility() 
        {
           
               string []str= this.add.JobResponsibility.Split('.');
               return str;
        }
        public string[] GetAddditionalResponsibility()
        {

            string[] str = this.add.AdditionalJobResponsibility.Split('.');
            return str;
        }
        public string[] GetEducationalRequirements()
        {

            string[] str = this.add.Education.Split('.');
            return str;
        }


        
        public void RetriveObjectFromSession() 
        {
            this.add=(Add)Session["Add"];
        }
        public string GetComapnyName() 
        {
            string acc_id =(string)Session["acc_id"];
            return this.poster.GetCompanyNameBL(acc_id);
        }
       
        public string GetVacancies() 
        {
            if (add == null)
                return "";
            return Convert.ToString(add.NoOfVacancies);
        }
        public string GetJobNature()
        {
            if (add == null)
                return "";
            return Convert.ToString(add.Job_nature);
        }
        public string GetLocation() 
        {
            if (add == null)
                return "";
            return add.Location;
        }

        public string GetSalaries() 
        {
            if (add == null)
                return "";
            return Convert.ToString(add.Sal);
        }
    }
}