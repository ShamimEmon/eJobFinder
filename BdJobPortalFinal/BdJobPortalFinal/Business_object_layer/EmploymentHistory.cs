using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    [Serializable]
    public class EmploymentHistory
    {
        public List<DateTime> StartDate = new List<DateTime>();
        public List<DateTime> EndDate = new List<DateTime>();
        public List<string> CompanyName = new List<string>();
        public List<string> CompanyLoc = new List<string>();
        public List<string> Position = new List<string>();
        public int Counter = 0;
        public string Cv_id { set; get; }
    }
}