using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class PostList : System.Web.UI.Page
    {
        private MyPostListsCreator creator = new MyPostListsCreator();
        public MyPosts post = new MyPosts();
        public ApplicantList list = new ApplicantList();
        private ApplicantListGetter listCreator = new ApplicantListGetter();

        protected void Page_Load(object sender, EventArgs e)
        {
            string company_id = Session["company_id"].ToString();
            Session["page"]="PostList";
            this.post = GetJobHeadingCB(company_id);
            Logger logger = new Logger();
            logger.IsLoggout();
            //this.list=GeCvIdCB("");
        }
        public MyPosts GetJobHeadingCB(string cv_id)
        {
            return creator.GetJobHeadingBL(cv_id);
        }

        //useless
        public ApplicantList GeCvIdCB(string add_id) 
        {
            return listCreator.GeCvIdBL(add_id);
        }
    }
}