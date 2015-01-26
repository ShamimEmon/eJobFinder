using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BdJobPortalFinal.Database_layer;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Business_layer
{
    public class CVListCreator
    {
        private Data_handler handler = new Data_handler();
        private AcademicQualification qualification = new AcademicQualification();
        public CVList GetCvListBL(string job_id) 
        {
            return handler.GetCvListDL(job_id);
        }
        public Cv GetCvBL(string cv_id)
        {
            return handler.GetCvDL(cv_id);
        }
        public string GetJobTitleBl(string job_id) 
        {
            return handler.GetJobTitleDL(job_id);
        }
        public AcademicQualification GetAcademicQalificationsBL(string cv_id,AcademicQualification qalification) 
        {
            return handler.GetAcademicQalificationsDL(cv_id,qalification);
        }
        public EmploymentHistory GetEmploymentHistoryBL(string cv_id, EmploymentHistory employmentHistory)
        {
            return handler.GetEmploymentHistoryDL(cv_id,employmentHistory);
        }
        public SkillSet GetSkillSetDL(string cv_id, SkillSet skillSet) 
        {
            return handler.GetSkillSetDL(cv_id,skillSet);
        }
    }
}