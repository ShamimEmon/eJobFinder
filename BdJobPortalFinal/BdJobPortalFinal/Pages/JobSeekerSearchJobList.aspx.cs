using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class JobSeekerSearchJobList : System.Web.UI.Page
    {

        public AddList addList = new AddList();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.addList = (AddList)Session["JobAddList"];
            Logger logger = new Logger();
            logger.IsLoggout();
            
        }
    }
}