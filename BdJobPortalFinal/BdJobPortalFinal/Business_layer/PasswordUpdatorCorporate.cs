using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;
namespace BdJobPortalFinal.Business_layer
{
    public class PasswordUpdatorCorporate
    {

        private Data_handler handler = new Data_handler();
        public bool IsPassCorrectBL(string acc_id, string cur_no)
        {
            string temp;
            temp = handler.GetPasswordFromCompany(acc_id);
            if (cur_no == temp)
                return true;
            return false;
        }
        public bool IsNewAndReNewMatchBL(string mob1, string mob2)
        {

            return mob1.Equals(mob2);
        }
        public void UpDatePassBL(string acc_id, string mob)
        {
            handler.UpDatePasswordCorporate(acc_id, mob);
        }
    }
}