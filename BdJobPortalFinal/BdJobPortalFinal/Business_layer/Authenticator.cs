using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class Authenticator
    {
        
        private Data_handler handler = new Data_handler();

        public bool IsCredentialValidBL(Account account)
        {
            Account temp = new Account();
            try
            {
                temp = this.handler.GetAccount(account.Acc_id, account.Acc_pass);


                if (temp.Acc_id.Equals(account.Acc_id) == false)
                    return false;
                if (temp.Acc_pass.Equals(account.Acc_pass) == false)
                    return false;
            }
            catch (NullReferenceException) { return false; }
            return true;

        }
        public Account GetAccountBL(Account account) 
        {
            return handler.GetAccount(account.Acc_id, account.Acc_pass);
        }
        public string GetCompanyIdBL(string acc_id)
        {

            return handler.GetCompanyIdDB(acc_id);
        }
       
    }
}