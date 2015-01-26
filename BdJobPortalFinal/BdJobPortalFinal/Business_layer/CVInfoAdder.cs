using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class CVInfoAdder
    {
        private Data_handler handler = new Data_handler();

        public string GetCvIDFromDbBL(string acc_id)
        { 
            return handler.GetCvIDFromDbDL(acc_id);
        }
        public void AddAcademicQualificationBL(AcademicQualification qualification) 
        {
            handler.AddAcademicQualification(qualification);
        }
        public void AddEmploymentHistoryBL(EmploymentHistory history) 
        {
            handler.AddEmploymentHistory(history);
        }
    }
}