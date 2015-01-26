using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class AddListCreator
    {
        private Data_handler handler = new Data_handler();
        public AddList GetAddIdListsBL(Add add)
        {
            return handler.GetAddIdListsDL(add);
        }
    }
}