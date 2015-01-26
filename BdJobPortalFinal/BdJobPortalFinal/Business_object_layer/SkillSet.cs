using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{  
    [Serializable]
    public class SkillSet
    {
        
        public List<string> Description = new List<string>();
        public string cv_id { set; get; }
        public int Counter = 0;

    }
}