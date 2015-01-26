using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BdJobPortalFinal.Pages
{
    public partial class Corporate : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["lb"] == "Logout")
            {
                Session["acc_id"] = null;
                Response.Redirect("http://localhost:26799/Pages/Default.aspx");
                
            }
        }
    }
}