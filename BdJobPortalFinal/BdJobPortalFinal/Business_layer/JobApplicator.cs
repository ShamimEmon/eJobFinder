using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class JobApplicator
    {
        private Data_handler handler = new Data_handler();
        public bool HasApplied(string cv_id,string add_id) 
        {
            string id=handler.GetCvIDFromApplication(cv_id,add_id);
            if (id == null)
                return false;
            return true;
        }
        public string GetCvIDFromDbBL(string acc_id) 
        {
            return this.handler.GetCvIDFromDbDL(acc_id);
        }
        public void AcceptApplication(JobApplication app) 
        {
            handler.RecordApplication(app);
        }
    }
}