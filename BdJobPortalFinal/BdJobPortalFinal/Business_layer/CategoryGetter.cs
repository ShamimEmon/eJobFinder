using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    
    public class CategoryGetter
    {
        private Data_handler handler = new Data_handler();
        public JobCategory GetJobCategoryBL() 
        {
            return handler.GetJobCategoryDL();
        }
    }
}