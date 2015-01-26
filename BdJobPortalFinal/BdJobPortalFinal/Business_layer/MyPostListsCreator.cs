using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
  
    public class MyPostListsCreator
    {
        private Data_handler handler = new Data_handler();

        public MyPosts GetJobHeadingBL(string cv_id) 
        {
            return handler.GetJobHeadingDL(cv_id);
        }

        public CVList GetCvListByApplicationBL(string add_id)
        {


            return handler.GetCvListByApplicationDL(add_id);

        }
    }
}