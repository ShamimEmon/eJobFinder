using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class CurrentJob
    {
        public string JobId { set; get; }
        public DateTime DateJoined { set; get; }
        public string CurrentCompanyName { set; get; }
        public double PresentSalary { set; get; }
        public string Cv_id { set; get; }
    }
}