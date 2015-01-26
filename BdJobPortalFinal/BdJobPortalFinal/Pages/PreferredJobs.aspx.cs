using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;

namespace BdJobPortalFinal.Pages
{
    public partial class PreferredJobs : System.Web.UI.Page
    {
        private AddList preferredJobList = new AddList();
        private PreferredJobGetter preferedJobGetter = new PreferredJobGetter();
        private string acc_id = "";
        private string cv_id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            this.acc_id =(string)Session["acc_id"];
            this.cv_id = preferedJobGetter.GetCvIDFromDbBL(this.acc_id);
            this.preferredJobList = preferedJobGetter.GetPrefferedJobList(this.cv_id);
            Session["JobAddList"] = this.preferredJobList;
            Response.Redirect("http://localhost:26799/Pages/JobSeekerSearchJobList.aspx");
        }
    }
}