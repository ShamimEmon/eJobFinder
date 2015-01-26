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
    public partial class Application_list_page : System.Web.UI.Page
    {
        public CVList cvList = new CVList();
        private MyPostListsCreator creator = new MyPostListsCreator();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string add_id=Request.QueryString["add_id"].ToString();
            this.cvList=GetCvListByApplicationCB(add_id);
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public CVList GetCvListByApplicationCB(string add_id)
        {


            return creator.GetCvListByApplicationBL(add_id);

        }

    }
}