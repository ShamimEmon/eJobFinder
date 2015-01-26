using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Business_layer
{
    
    public class CurrentJobUpdator
    {
        private Data_handler handler = new Data_handler();

        public void UpdateCurrentJobBL(CurrentJob job) 
        {
            this.handler.UpdateCurrentJob(job);
        }

        public string GetCvIDFromDbBL(string acc_id)
        {
            return handler.GetCvIDFromDbDL(acc_id);
        }
    }
}