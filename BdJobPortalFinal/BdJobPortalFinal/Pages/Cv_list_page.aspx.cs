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
    public partial class Cv_list_page : System.Web.UI.Page
    {
        public CVList cvList = new CVList();
        private CVListCreator creator = new CVListCreator();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            string job_id = (string)Session["job_id"];
            this.cvList = GetCvListCB(job_id);
            Logger logger = new Logger();
            logger.IsLoggout();
        } 
        public CVList GetCvListCB(string job_id) 
        {
            return creator.GetCvListBL(job_id);
        }
        
        
        
    }
}