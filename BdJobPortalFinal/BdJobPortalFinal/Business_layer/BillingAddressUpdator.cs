using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class BillingAddressUpdator
    {
        private Data_handler handler = new Data_handler();
        public bool IsAddressCorrectBL(string acc_id, string cur_add)
        {
            string temp;
            temp = handler.GetBillingAddressFromCompany(acc_id);
            if (cur_add == temp)
                return true;
            return false;
        }
        public bool IsNewAndReNewMatchBL(string add1, string add2)
        {

            return add1.Equals(add2);
        }
        public void UpDateAddressBL(string acc_id, string add)
        {
            handler.UpDateAddressDB(acc_id, add);
        }
    }
}