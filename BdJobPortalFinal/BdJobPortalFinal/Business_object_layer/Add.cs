using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class Add
    {
        public string AddId { set; get; }
        public string JobTitle { set; get; }
        public int AddType { set; get; }
        public string JobCategory{ set; get;}
        public int NoOfVacancies { set; get; }
        public int CvType { set; get; }
        public int NeedPicture { set; get;}
        public DateTime Deadline { set; get;}
        public int AgeFrom { set; get; }
        public int AgeTo { set; get; }
        public string GenderPreference { set; get; }
        public string JobLevel { set; get; }
        public string Education { set; get; }
        public string JobResponsibility { set; get; }
        public string AdditionalJobResponsibility { set; get; }
        public string CompanyId { set; get; }
        public string Job_nature { set; get; }
        public int Min_exp { set; get; }
        public int Max_exp { set; get; }
        public double Sal { set; get; }
        public string Location { set; get;}
        public bool IsPaid { set; get; }
        public double SalMax {set;get;}
        
    }
}