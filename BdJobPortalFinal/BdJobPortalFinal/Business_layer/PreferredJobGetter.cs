using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    
    public class PreferredJobGetter
    {
        private Data_handler handler = new Data_handler();

        public AddList GetPrefferedJobList(string cv_id) 
        {
            return handler.GetAddIdListsFromJobsDL(cv_id);
        }
        public string GetCvIDFromDbBL(string acc_id)
        {
            return this.handler.GetCvIDFromDbDL(acc_id);
        }
    }
}