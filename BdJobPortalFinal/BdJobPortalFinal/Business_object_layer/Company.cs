using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Business_object_layer
{
    public class Company
    {
        public string Company_id { set; get; }
        public string Company_name { set;get;}
        public string Contact_person{ set; get; }
        public string Company_description{ set; get; }
        public string Industry_type{ set; get; }
        public string Company_address{ set; get; }
        public string Company_city { set; get; }
        public string Company_area{ set; get; }
        public string Company_country { set; get; }
        public string Billing_address { set; get; }
        public string Billing_contact_no { set; get; }
        public string Billing_email { set; get; }
        public string WebSite { set; get; }
        public string Acc_id { set; get; }

    }
}