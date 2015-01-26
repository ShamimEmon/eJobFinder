using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class Search_employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            search_button.Click+=SearchAction;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void SearchAction(object sender, EventArgs e) 
        {
            Session["job_id"] = job_category.Value;
            Session["page"] = "Search_employee";
            Response.Redirect("http://localhost:26799/Pages/Cv_list_page.aspx");
        }
    }
}