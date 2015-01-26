using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class CVList
    {
        public List<string> Cv_id = new List<string>();
        public List<string> Cv_name=new List<string>();
        public List<string> Cv_postal_address = new List<string>();
        public List<string> Cv_mob = new List<string>();
        public List<DateTime> Cv_dob = new List<DateTime>();
        public List<string> Cv_email = new List<string>();
        public List<string> Cv_language_skills = new List<string>();
        public List<string> Cv_other_skills = new List<string>();
        public List<string> Cv_permanent_address = new List<string>();
        public List<string> Cv_current_address = new List<string>();
        public List<string> Fathers_name = new List<string>();
        public List<string> Mothers_name = new List<string>();
        public List<string> Gender = new List<string>();
        public List<string> National_id = new List<string>();
        public List<string> Career_objective = new List<string>();
        public List<string> Present_salary = new List<string>();
        public List<string> Expected_salary = new List<string>();
        public List<string> Looking_for = new List<string>();
        public int counter = 0;
    }
}