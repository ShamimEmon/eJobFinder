using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class ApplicationFailure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Logger logger = new Logger();
            logger.IsLoggout();
        }
    }
}