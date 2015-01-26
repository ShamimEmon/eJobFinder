using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class CvHomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            add_academic_qualification.Click += AcademicQualificationAdder;
            add_job_history.Click += EmploymentHistoryAdder;
            view_cv.Click += CvViewer;
            update_current_job.Click += CurrentJobUpdator;
            add_skill.Click += SkillAdder;

            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void AcademicQualificationAdder(object sender, EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/AddAcademicQualification.aspx");
        }
        public void EmploymentHistoryAdder(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/AddEmploymentHistory.aspx");
        }
        public void CvViewer(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/ViewMyCv.aspx");
        }
        public void CurrentJobUpdator(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/UpdateCurrentJob.aspx");
        }
        public void SkillAdder(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/AddSkill.aspx");
        }

    }
}