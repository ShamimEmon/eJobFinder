using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class MyPosts
    {
        public List<string> JobTitle = new List<string>();
        public List<DateTime> PostDate = new List<DateTime>();
        public List<string> Add_id = new List<string>();
        public int Counter = 0;
    }
}