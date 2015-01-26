using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;
namespace BdJobPortalFinal.Business_layer
{
    public class JobPoster
    {
        private Data_handler handler = new Data_handler();

        public string GetCompanyIdBL(string acc_id)
        {
            return handler.GetCompanyIdDB(acc_id);
        }
        public string GetCompanyNameBL(string acc_id) 
        {
            return handler.GetCompanyNameDB(acc_id);
        }
        public void PostJobToDatabaseBL(Add add)
        {
            handler.PostJobToDatabaseDB(add);
        }
       
    }
}