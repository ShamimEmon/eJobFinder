using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class ApplicantListGetter
    {
        private Data_handler handler = new Data_handler();

        public ApplicantList GeCvIdBL(string add_id)
        {
            return handler.GeCvIdDL(add_id);
        }
    }
}