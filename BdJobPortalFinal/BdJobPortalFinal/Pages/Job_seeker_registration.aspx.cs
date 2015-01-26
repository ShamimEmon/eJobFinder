using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Pages
{
    public partial class Job_seeker_registration : System.Web.UI.Page, IClientSiteHandler
    {
        private Cv cv = new Cv();
        private Account account = new Account();
        private JobPreference preference = new JobPreference();
        private Account_register register = new Account_register();
        private LocationPreference loc = new LocationPreference();
        private bool isInputValid=true;

        protected void Page_Load(object sender, EventArgs e)
        {
            register_button.Click += Register_button_listener;
        }

        public string CreateJobSeekerAccInDBDL(string cv_id,Account account)
        {
             return register.CreateJobSeekerAccInDBDL(cv_id,account);
        }
        public void RegisterJobSeekerInDbBL(Cv cv,string acc_id)
        {
            register.RegisterJobSeekerInDbBL(cv,acc_id);
        }
        public void AddJobPreferenceOfJobSeekerCB(string cv_id, JobPreference preference)
        {
            register.AddJobPreferenceOfJobSeekerBL(cv_id,preference);
        }
        public void AddJobLocationPreferenceOfJobSeekerCB(string cv_id, LocationPreference loc)
        {
            register.AddJobLocationPreferenceOfJobSeekerBL(cv_id,loc);
        }
        public void CreateJobSeeker() 
        {
            this.account.Acc_pass = CreateJobSeekerAccInDBDL(this.cv.Cv_id, this.account);
            RegisterJobSeekerInDbBL(this.cv,this.account.Acc_id);
            AddJobPreferenceOfJobSeekerCB(this.cv.Cv_id, this.preference);
            AddJobLocationPreferenceOfJobSeekerCB(this.cv.Cv_id, this.loc);
        }

        public void Register_button_listener(object sender, EventArgs e) 
        {
            GetInput();
            if (IsAllFieldsOk() == false)
                isInputValid = false;

            if (isInputValid == false)
            {

                SetErrMsg();
                return;
            }

            CreateJobSeeker();
            Session["seeker_acc"] =this.account;
            Response.Redirect("http://localhost:26799/Pages/JobSeeker_reg_confirmation.aspx");

        }
        public void SetJobPreference() 
        {
            this.preference = new JobPreference();
            if (one_ckbx.Checked)
            {
                this.preference.JobId.Add("1");
                this.preference.Count++;
            }
            if (two_ckbx.Checked)
            {
                this.preference.JobId.Add("2");
                this.preference.Count++;
            }
            if (one_ckbx.Checked == false && two_ckbx.Checked == false)
                isInputValid = false;
        }
        public void SetLocPreference() 
        {
            this.loc = new LocationPreference();
            if (one_cxk2.Checked)
            {
                this.loc.LocId.Add("1");
                this.loc.Counter++;
            }
            if (two_cxk2.Checked)
            {
                this.loc.LocId.Add("2");
                this.loc.Counter++;
            }
            if (three_cxk2.Checked)
            {
                this.loc.LocId.Add("3");
                this.loc.Counter++;
            }
            if (four_cxk2.Checked)
            {
                this.loc.LocId.Add("4");
                this.loc.Counter++;
            }
            if (one_cxk2.Checked == false && two_cxk2.Checked == false && three_cxk2.Checked == false && four_cxk2.Checked == false)
                this.isInputValid = false;
        }
       public void GetInput()
        { 
           
            try
            {
                this.cv.Cv_name = name.Value;
                this.cv.Fathers_name = fathers_name.Value;
                this.cv.Mothers_name = mothers_name.Value;
                this.cv.Cv_dob = Convert.ToDateTime(dob.Value);
                this.cv.Gender = gender.Value;
                this.cv.National_id = nid.Value;
                this.cv.Cv_current_address = cur_add.Text;
                this.cv.Cv_permanent_address = per_add.Text;
                this.cv.Cv_mob = mob.Value;
                this.cv.Cv_email = email.Value;
                this.cv.Career_objective = career_obj.Text;
                this.cv.Present_salary = Convert.ToDouble(present_sal.Value);
                this.cv.Expected_salary = Convert.ToDouble(exp_sal.Value);
                this.cv.Looking_for_job_id = looking_for.Value;
                this.cv.CurrentComapnyName = current_company.Value;
                this.cv.CurrentCompanyAddress = current_company_address.Value;
                this.cv.current_job_id = current_job.Value;
                this.cv.JobNatureId = job_nature.Value;
                this.cv.Cv_language_skills = language_skills.Text;
                this.cv.Cv_other_skills = other_skills.Text;
                SetJobPreference();
                SetLocPreference();
            }
            catch (NullReferenceException)
            {
                this.isInputValid = false;
            }
            catch (FormatException) 
            {
                this.isInputValid = false;
            }
           
        }

       public void ClearFields()
        { 
           //do nothing
        }
        public void SetErrMsg() 
        {
            err_div.Visible = true;
        }
       public bool IsAllFieldsOk()
        {
            if (name.Value.Length == 0)
                return false;
            if (fathers_name.Value.Length == 0)
                return false;
            if (mothers_name.Value.Length == 0)
                return false;
            if (dob.Value.Length == 0)
                return false;
            if (gender.Value.Length == 0)
                return false;
            if (nid.Value.Length == 0)
                return false;
            if (cur_add.Text.Length == 0)
                return false;
            if (per_add.Text.Length == 0)
                return false;
            if (mob.Value.Length == 0)
                return false;
            if (email.Value.Length == 0)
                return false;
            if (career_obj.Text.Length == 0)
                return false;
            if (present_sal.Value.Length == 0)
                return false;
            if(exp_sal.Value.Length==0)
                return false;
            if (looking_for.Value.Length == 0)
                return false;
            if (current_company.Value.Length == 0)
                return false;
            if (current_company_address.Value.Length == 0)
                return false;
            if (current_job.Value.Length == 0)
                return false;
            if (job_nature.Value.Length == 0)
                return false;
           return true; 
        }
    }
}