using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_layer;



namespace BdJobPortalFinal.Pages
{
    public partial class SearchJodDescription : System.Web.UI.Page
    {
        private AddInfoGetter addInfoGetter = new AddInfoGetter();
        public Add add = new Add();
        private JobApplication app = new JobApplication();
        public string company_name = "";
        private string add_id = "";
        public string email = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.add_id = Request.QueryString["add_id"];
            this.add = addInfoGetter.GetAddFromDataBaseBL(add_id);
            this.company_name = addInfoGetter.GetCompanyNameFromDBDL(this.add.CompanyId);
            this.email = addInfoGetter.GetCompanyEmailFromDBBL("corp_1");
            this.app.AddId = (this.add_id);
            this.app.CompanyID = this.add.CompanyId;
            apply_online_button.Click += ApplyOnlineListener;

        }
        public void ApplyOnlineListener(object sender, EventArgs e)
        {
            Session["JobApplication"] = this.app;
            string acc_id = (string)Session["acc_id"];

            if (acc_id == null)
                Response.Redirect("http://localhost:26799/Pages/AskAccount.aspx");
            Response.Redirect("http://localhost:26799/Pages/JobApplicationProcessPage.aspx");
        }
        public string[] GetResponsibility()
        {

            string[] str = this.add.JobResponsibility.Split('.');
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

    }
}