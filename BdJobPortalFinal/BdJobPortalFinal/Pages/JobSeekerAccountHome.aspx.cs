using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class JobSeekerAccountHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            changeEmail.Click += ChangeEmailListener;
            changeMob.Click += ChangeMobListener;
            cng_pass.Click += ChangePassListener;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void ChangeEmailListener(object sender, EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/ChangeEmailJSK.aspx");
        }
        public void ChangeMobListener(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/ChangeMobileJSK.aspx");
        }
        public void ChangePassListener(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/ChangePasswordJSK.aspx");
        }
    }
}