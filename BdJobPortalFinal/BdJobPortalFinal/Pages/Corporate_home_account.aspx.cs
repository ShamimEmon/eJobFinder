using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;
namespace BdJobPortalFinal.Pages
{
    public partial class Corporate_home_account : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            cng_mob.Click += ChangeMobAction;
            cng_email.Click += ChangeEmailAction;
            cng_address.Click += ChangeAddressAction;
            cng_pass.Click += ChangePassAction;

            Logger logger = new Logger();
            logger.IsLoggout();
                
        }
        public void ChangeMobAction(object sender,EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/ChangeMobileCorp.aspx");
        }
        public void ChangePassAction(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/ChangePasswordCorporate.aspx");
        }
        public void ChangeEmailAction(object sender, EventArgs e) 
        {
            Response.Redirect("http://localhost:26799/Pages/ChangeEmailCorp.aspx");
        }
        public void ChangeAddressAction(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:26799/Pages/ChangeAddressCorp.aspx");
        }
    }
}