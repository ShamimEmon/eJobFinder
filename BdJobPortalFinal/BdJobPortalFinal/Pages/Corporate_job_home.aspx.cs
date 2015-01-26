using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class Corporate_job_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            post_new_job_btn.Click += PostANewJobListener;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        protected void PostANewJobListener(object sender, EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/Post_job_part_one.aspx");
        }
    }
}