using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    [Serializable()]
    public class AcademicQualification
    {
        public List<string> Degree_name = new List<string>();
        public List<string> Score=new List<string>();
        public List<string> Year=new List<string>();
        public List<string> Academic_Institute=new List<string>();
        public string Cv_id { set; get; }
        public int counter = 0;
    }
}