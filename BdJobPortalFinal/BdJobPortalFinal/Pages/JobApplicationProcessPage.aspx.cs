using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Pages
{
    public partial class JobApplicationProcessPage : System.Web.UI.Page
    {
        private JobApplication app = new JobApplication();
        private JobApplicator applicator = new JobApplicator();
        private string acc_id = "";
        private bool hasApplied = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.acc_id = (string)Session["acc_id"];
            this.app=(JobApplication)Session["JobApplication"];
            this.app.CvId = applicator.GetCvIDFromDbBL(this.acc_id);
            this.hasApplied = applicator.HasApplied(this.app.CvId,this.app.AddId);
            if (hasApplied)
                Response.Redirect("http://localhost:26799/Pages/ApplicationFailure.aspx");
            applicator.AcceptApplication(this.app);
            Response.Redirect("http://localhost:26799/Pages/ApplicationSuccess.aspx");

        }
    }
}