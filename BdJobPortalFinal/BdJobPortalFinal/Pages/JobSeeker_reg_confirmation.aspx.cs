using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Pages
{
    public partial class JobSeeker_reg_confirmation : System.Web.UI.Page
    {
        public Account account = new Account();
        protected void Page_Load(object sender, EventArgs e)
        {
            ok.Click += OkAction;
            this.account = (Account)Session["seeker_acc"];
        }
        public void OkAction(object sender, EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/job_seeker_login.aspx"); 
        }
    }
}