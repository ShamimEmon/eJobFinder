using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class Post_job_part_one : System.Web.UI.Page,IClientSiteHandler
    {
        private Add add = new Add();
        private JobPoster poster = new JobPoster();
        private bool isInputOk=true;
        private string acc_id = "";
        public JobCategory category = new JobCategory();
        private CategoryGetter getter = new CategoryGetter();
       
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //err.InnerText = "";
            this.category = GetJobCategorCB();
            btn.Click +=PreviewAddAction;
            if(deadline.Value.Length==0)
               deadline.Value = "mm/dd/yyyy";
            Logger logger = new Logger();
            logger.IsLoggout();
            
            
        }
        public JobCategory GetJobCategorCB() 
        {
             return getter.GetJobCategoryBL();
        }
        public void PreviewAddAction(object sender, EventArgs e) 
        {
            this.acc_id = Convert.ToString(Session["acc_id"]);
            GetInput();
            if (IsAllFieldsOk() == false)
            {
                SetErrMsg();
                return;
            }
            
               SetSessionValue();
               Response.Redirect("http://localhost:26799/Pages/Post_job_part_two.aspx");
                
            
          
            
        }
        public void SetJobNature()
        {
            add.Job_nature = "";
            if (job_nature_one.Checked)
                add.Job_nature = "Full Time";
            if (job_nature_two.Checked)
                add.Job_nature = "Part Time";
            if (job_nature_three.Checked)
                add.Job_nature = "Contract";


        }
        public bool IsAllFieldsOk() 
        {
            try
            {
              if (add.Location.Length == 0)
                 return false;
              if (add.Job_nature.Length == 0)
                 return false;
              if (salary.Value.Length == 0)
                 return false;
              if (min_exp.Value.Length == 0)
                 return false;
              if (max_exp.Value.Length == 0)
                 return false;
              if (Convert.ToString(add.AddType).Length == 0)
                 return false;
              if (add.JobCategory.Length == 0)
                 return false;
              if (add.JobCategory.Length == 0)
                 return false;
              if (add.JobTitle.Length == 0)
                 return false;
              if (vacancies.Value.Length == 0)
                 return false;
              if (Convert.ToString(add.CvType).Length == 0)
                 return false;
              if (Convert.ToString(add.NeedPicture).Length == 0)
                 return false;
              if (add.GenderPreference.Length == 0)
                 return false;
              if (add.JobLevel.Length == 0)
                 return false;
              if (deadline.Value.Length == 0)
                 return false;
              if (from.Value.Length == 0)
                 return false;
              if (to.Value.Length == 0)
                 return false;
              if (add.Education.Length == 0)
                 return false;
              if (add.JobResponsibility.Length == 0)
                 return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }
        public void GetInput()
        {
            try
            {
                add.CompanyId = GetCompanyIdCB(this.acc_id);
                add.AddType = Convert.ToInt32(add_type.Value);
                SetJobNature();
                add.JobCategory = job_type.Value;
                add.JobTitle = job_title.Value;
                add.Location = location.Value;
                add.NoOfVacancies = Convert.ToInt32(vacancies.Value);
                SetCvType();
                SetPicNeeded();
                add.Deadline = Convert.ToDateTime(deadline.Value);
                add.AgeFrom = Convert.ToInt32(from.Value);
                add.AgeTo = Convert.ToInt32(to.Value);
                add.Max_exp = Convert.ToInt32(max_exp.Value); //Convert.ToString(max_exp.Value);
                add.Min_exp = Convert.ToInt32(min_exp.Value);
                add.Sal = Convert.ToDouble(salary.Value);
                SetGenderPreference();
                SetJobLevel();
                add.Education = education.Value;
                add.JobResponsibility = responsibility.Value;
                add.AdditionalJobResponsibility = addtional_responsibility.Value;
                add.SalMax = Convert.ToDouble(salmax.Value);
            }
            catch (NullReferenceException) { }
            catch (FormatException)
            {
                ;
            }
        }
        public void SetGenderPreference() 
        {
            add.GenderPreference = "";
            if (gender_one.Checked)
                add.GenderPreference = "male";
            if (gender_two.Checked)
                add.GenderPreference = "Female";
            if (gender_three.Checked)
                add.GenderPreference = "both";
        }
        public void SetPicNeeded() 
        {
            add.NeedPicture =0;
            if (pic_yes.Checked)
                add.NeedPicture=1;
            if(pic_no.Checked )
                add.NeedPicture =2;
        }
        public void SetCvType() 
        {
            this.add.CvType = 0;
            if (cvtype_one.Checked)
                this.add.CvType = 1; 
            if (cv_type_two.Checked)
                this.add.CvType =2;
            if (cv_type_three.Checked)
                this.add.CvType =3;  
        }
        public void SetJobLevel() 
        {
            add.JobLevel = "";
            if (level_one.Checked)
                add.JobLevel = "Entry";
            if (level_two.Checked)
                add.JobLevel = "Mid";
            if (level_three.Checked)
                add.JobLevel = "Senior";
        }
        
        public string GetCompanyIdCB(string acc_id) 
        {
            return poster.GetCompanyIdBL(acc_id);
        }

        
        public void ClearFields()
        {
            //do nothing
        }
        public void SetErrMsg()
        { 
            err_div_2.Visible = true;
        }
       

        public void SetSessionValue() 
        {
            Session["Add"] = this.add;
        }
        public void GetJobCategory() 
        {
        }

    }
}