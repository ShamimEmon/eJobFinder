using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class AddInfoGetter
    {
        private Data_handler handler = new Data_handler();

        public Add GetAddFromDataBaseBL(string add_id) 
        {
            return handler.GetAddFromDataBaseDL(add_id);
        }
        public string GetCompanyNameFromDBDL(string company_id) 
        {
            return handler.GetCompanyNameFromDBDL(company_id);
        }
        public string GetCompanyEmailFromDBBL(string company_id) 
        {
            return handler.GetCompanyEmailFromDBDL(company_id);
        }
    }
}