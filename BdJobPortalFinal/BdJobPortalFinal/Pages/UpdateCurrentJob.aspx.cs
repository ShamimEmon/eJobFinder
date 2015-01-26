using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class UpdateCurrentJob : System.Web.UI.Page,IClientSiteHandler
    {
        public CurrentJob job = new CurrentJob();
        private CurrentJobUpdator updator = new CurrentJobUpdator();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            finish.Click += UpdateJobListener;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void UpdateJobListener(object sender, EventArgs e) 
        {
            if (IsAllFieldsOk())
            {
                GetInput();
                string acc_id = (string)Session["acc_id"];
                this.job.Cv_id = updator.GetCvIDFromDbBL(acc_id);
                this.updator.UpdateCurrentJobBL(this.job);
                Response.Redirect("http://localhost:26799/Pages/CvHomePage.aspx");
            }
            else
                SetErrMsg();
        }
        public void GetInput()
        {
            this.job.JobId = pos.Value;
            try
            {
                this.job.PresentSalary = Convert.ToDouble(salary.Value);
                this.job.DateJoined = Convert.ToDateTime(join_date.Value);
            }
            catch (FormatException) 
            {
                //err_msg.InnerText = "Invaid Input Type";
            }
            this.job.CurrentCompanyName = company_name.Value;
            
        }
        public void ClearFields() 
        {
            //do nothing
        }
        public void SetErrMsg() 
        {
            err_msg.InnerText = "Missing Field(s) or Invalid input";
        }
        public bool IsAllFieldsOk() 
        {
            if(pos.Value == "0")
                return false;
            if (salary.Value.Length == 0)
                return false;
            if (join_date.Value.Length == 0)
                return false;
            if (company_name.Value.Length == 0)
                return false;
            return true;
        }
    }
}