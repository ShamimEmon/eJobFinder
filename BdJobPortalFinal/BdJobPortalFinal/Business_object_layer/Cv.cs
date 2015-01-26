using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class Cv
    {
        public string Cv_id { set; get; }
        public string Cv_name { set; get; }
        public string Cv_postal_address { set; get; }
        public string Cv_mob { set; get; }
        public DateTime Cv_dob { set; get; }
        public string Cv_email { set; get; }
        public string Cv_language_skills { set; get; }
        public string Cv_other_skills { set; get; }
        public string Cv_permanent_address { set; get; }
        public string Cv_current_address { set; get; }
        public string Fathers_name { set; get; }
        public string Mothers_name { set; get; }
        public string Gender { set; get; }
        public string National_id { set; get; }
        public string Career_objective { set; get; }
        public double Present_salary { set; get; }
        public double Expected_salary { set; get; }
        public string current_job_id { set; get; }
        public string Looking_for_job_id { set; get; }
        public string CurrentComapnyName {set;get;}
        public string CurrentCompanyAddress {set; get;}
        public DateTime StartDate { set; get; }
        public string JobNatureId { set; get; }
    }
}