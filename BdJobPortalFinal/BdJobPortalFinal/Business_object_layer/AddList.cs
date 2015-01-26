using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class AddList
    {
        public List<string> AddId = new List<string>();
        public List<string> JobTitle = new List<string>();
        public List<int> NoOfVacancies = new List<int>();
        public List<int> Min_exp = new List<int>();
        public List<int> Max_exp = new List<int>();
        public List<DateTime> Deadline = new List<DateTime>();
        public int Counter = 0;

        
    }
}