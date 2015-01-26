using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class CorporateEmailUpdator
    {
       private Data_handler handler = new Data_handler();

       public void UpDateEmailBL(string acc_id,string email)
       {
           handler.UpDateEmailCorporate(acc_id, email);
       }
       public bool IsEmailCorrectBL(string acc_id, string num)
       {
           string temp;
           temp = handler.GetEmailFromCompany(acc_id);
           if (num == temp)
               return true;
           return false;
       }
       public bool IsNewAndReNewMatchBL(string email1, string email2) 
       {
           return email1.Equals(email2);
       }
    }
}