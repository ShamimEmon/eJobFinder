using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Database_layer;

namespace BdJobPortalFinal.Business_layer
{   

    public class Account_register
    {
        private Account account = new Account();
        private Company company = new Company();
        private Data_handler handler = new Data_handler();

        public bool isDupBL(string str)
        {
            return handler.isDup(str) ;
        }
        public void RegisterCorporateUserBL(Account account,Company company) 
        {
            this.handler.RegisterCorporateUserDb(account,company);
        }
        public string CreateJobSeekerAccInDBDL(string cv_id,Account account)
        {
            return handler.CreateJobSeekerAccInDBDL(cv_id,account);
        }
        public void RegisterJobSeekerInDbBL(Cv cv,string acc_id)
        {
            handler.RegisterJobSeekerInDbDL(cv,acc_id);
        }
        public void AddJobPreferenceOfJobSeekerBL(string cv_id, JobPreference preference)
        {
            handler.AddJobPreferenceOfJobSeekerDL(cv_id,preference);
        }
        public void AddJobLocationPreferenceOfJobSeekerBL(string cv_id, LocationPreference loc)
        {
            handler.AddJobLocationPreferenceOfJobSeekerDL(cv_id,loc);
        }
    }
}