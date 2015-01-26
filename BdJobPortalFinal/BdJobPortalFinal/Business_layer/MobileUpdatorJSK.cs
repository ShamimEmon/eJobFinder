using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;


namespace BdJobPortalFinal.Business_layer
{
    public class MobileUpdatorJSK
    {
        private Data_handler handler = new Data_handler();
        public bool IsNumberCorrectBL(string acc_id, string cur_no)
        {
            string temp;
            temp = handler.GetMobileNumberFromCv(acc_id);
            if (cur_no == temp)
                return true;
            return false;
        }
        public bool IsNewAndReNewMatchBL(string mob1, string mob2)
        {

            return mob1.Equals(mob2);
        }
        public void UpDateMobileBL(string acc_id, string mob)
        {
            handler.UpDateMobileJSK(acc_id, mob);
        }
    }
}