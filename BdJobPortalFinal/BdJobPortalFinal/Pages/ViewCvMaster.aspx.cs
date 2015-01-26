using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class ViewCvMaster : System.Web.UI.Page
    {
        public Cv cv = new Cv();
        public AcademicQualification qualification = new AcademicQualification();
        public EmploymentHistory history = new EmploymentHistory();
        public SkillSet skills = new SkillSet();

        private CVListCreator creator = new CVListCreator();
        public string current_job = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            this.cv = getCvCB();
            this.current_job = GetJobTitleCB(this.cv.current_job_id);
            this.qualification = this.creator.GetAcademicQalificationsBL(GetId(), this.qualification);
            this.history = GetEmploymentHistoryCB(GetId(), this.history);
            this.skills = GetSkillSetBL(GetId(), this.skills);
            Logger logger = new Logger();
            logger.IsLoggout();

        }
        public string GetId()
        {
            return Request.QueryString["id"].ToString();
        }
        public Cv getCvCB()
        {
            string cv_id = GetId();
            return this.creator.GetCvBL(cv_id);
        }
        public string GetJobTitleCB(string job_id)
        {
            return creator.GetJobTitleBl(job_id);
        }
        public AcademicQualification GetAcademicQalificationsCB(string cv_id, AcademicQualification qualification)
        {
            return creator.GetAcademicQalificationsBL(cv_id, qualification);
        }
        public EmploymentHistory GetEmploymentHistoryCB(string cv_id, EmploymentHistory employmentHistory)
        {
            return creator.GetEmploymentHistoryBL(cv_id, this.history);
        }
        public SkillSet GetSkillSetBL(string cv_id, SkillSet skillSet)
        {
            return creator.GetSkillSetDL(cv_id, skillSet);
        }
    }
}