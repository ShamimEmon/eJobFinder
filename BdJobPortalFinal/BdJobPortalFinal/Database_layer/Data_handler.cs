using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using BdJobPortalFinal.Business_object_layer;

namespace BdJobPortalFinal.Database_layer
{
    public class Data_handler
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;



        public void SetConnection()
        {
            Db_con_instance conn = new Db_con_instance();
            this.connection = conn.GetConn();

        }

        public void ExecuteQuery(string query)
        {
            SetConnection();
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.command.CommandText = query;
            this.command.ExecuteNonQuery();
        }

        public Account GetAccount(string acc_id,string acc_pass) 
        {
            Account tempAccInstance = new Account();
            string query = "SELECT acc_id,acc_pass,acc_type from account where acc_id='"+acc_id+"' AND acc_pass='"+acc_pass+"'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                try
                {
                    tempAccInstance.Acc_id = reader.GetString(0);
                    tempAccInstance.Acc_pass = reader.GetString(1);
                    tempAccInstance.Acc_type = reader.GetString(2);
                }
                catch (NullReferenceException) 
                {
                    
                }
            }
            
            this.connection.Close();
            return tempAccInstance;    
        }
        public bool isDup(string str)
        {
            string query = "SELECT acc_id from account where acc_id='" + str + "'";
            ExecuteQuery(query);
            str=null;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                try
                {
                    str = reader.GetString(0);
                }
                catch (NullReferenceException) { }
            this.connection.Close();
            if (str == null)
                return false;
            return true;
        }
        public void RegisterCorporateUserDb(Account account,Company company) 
        {   account.Acc_type="2";
            int counter = 0;
            string query = "INSERT INTO ACCOUNT values('" + account.Acc_id + "','" + account.Acc_pass + "','" + account.Acc_type + "')";
            ExecuteQuery(query);
            this.connection.Close();
            query = "SELECT count(*) FROM company";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                counter =reader.GetInt32(0);
            }
            company.Company_id ="corp_"+ Convert.ToString(++counter);
            this.connection.Close();

            query = "INSERT INTO company values('" + company.Company_id + "','" + company.Company_name + "','" + company.Company_description + "','" + company.Industry_type + "','" + company.Company_address + "','" + company.Company_city + "','" + company.Company_area + "','" + company.Company_country + "','" + company.Billing_address + "','" + company.Billing_contact_no + "','" + company.Billing_email + "','" + company.WebSite + "','" + account.Acc_id + "','" + company.Contact_person+"')";
            ExecuteQuery(query);
            this.connection.Close();



        }
       

       public string GetCompanyIdDB(string acc_id)
        {
            string query = "SELECT company_id FROM company WHERE acc_id='"+acc_id+"'";
            string result = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            this.connection.Close();
            return result;
        }
        public string GetCompanyNameDB(string acc_id)
        {
            string query = "SELECT company_name FROM company WHERE acc_id='" + acc_id + "'";
            string result = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            this.connection.Close();
            return result;
        }
        public void PostJobToDatabaseDB(Add add)
        {
            string isPaid="0";
            string addId = "add " + Convert.ToString(GetRowsFromJob());
            string query ="insert into job values('"+addId+"','"+add.JobTitle+"','"+add.NoOfVacancies+"','"+add.NeedPicture+"','"+add.Deadline.Date+"','"+ DateTime.Now+"','"+add.GenderPreference+"','"+add.AgeFrom+"','"+add.AgeTo+"','"+add.JobLevel+"','"+add.CompanyId+"','"+add.Job_nature+"','"+add.Min_exp+"','"+add.Max_exp+"','"+add.Sal+"','"+isPaid+"','"+add.AddType+"','"+add.Location+"','"+add.CvType+"','"+add.Education+"','"+add.JobResponsibility+"','"+add.AdditionalJobResponsibility+"','"+add.JobCategory+"',"+add.SalMax+")";
            ExecuteQuery(query);
            this.connection.Close();
        }
        
        public int GetRowsFromJob()
        {
            string query = "select count(*) from job";
            int result = 0;
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }

            this.connection.Close();
            return result;
        }

        public int GetRowsFromEducational_requirement()
        {
            string query = "select count(*) from educational_requirement";
            int result = 0;
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }

            this.connection.Close();
            return result;
        }

        public string GetMobileNumberFromCompany(string acc_id) 
        {
            string query = "select billing_contact_no from company WHERE acc_id='" + acc_id + "'" ;
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no=null;
            while (reader.Read()) 
             no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public string GetMobileNumberFromCv(string acc_id)
        {
            string query = "select cv_mob from cv WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        
        public string GetBillingAddressFromCompany(string acc_id)
        {
            string query = "select billing_address from company WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public string GetEmailFromCompany(string acc_id)
        {
            string query = "select billing_email_address from company WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public string GetEmailFromCv(string acc_id)
        {
            string query = "select cv_email from cv WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public void UpDateMobileCorporate(string acc_id, string mob)
        {
            string query = "update company SET billing_contact_no='"+mob+"' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void UpDateMobileJSK(string acc_id, string mob)
        {
            string query = "update cv SET cv_mob='" + mob + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void UpDateAddressDB(string acc_id, string address)
        {
            string query = "update company SET billing_address='" + address + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void UpDateEmailCorporate(string acc_id, string email)
        {
            string query = "update company SET billing_email_address='" + email + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void UpDateEmailJSK(string acc_id, string email)
        {
            string query = "update cv SET cv_email='" + email + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public CVList GetCvListDL(string job_id) 
        {
            string query = "select cv_id,cv_name,cv_current_address,cv_mob,cv_dob,cv_email,cv_language_skills,cv_other_skills,cv_permanent_address,cv_current_address,fathers_name,mothers_name,gender,national_id,career_objective,present_salary,expected_salary,job_id from cv WHERE job_id='"+job_id+"'";
            ExecuteQuery(query);
            CVList list=new CVList();
            SqlDataReader reader = command.ExecuteReader();
            list.counter = 0;
            while (reader.Read())
            {
               
                list.Cv_id.Add(reader.GetString(0));
                list.Cv_name.Add(reader.GetString(1));    
                list.Cv_postal_address.Add(reader.GetString(2));
                list.Cv_mob.Add(reader.GetString(3));
                list.Cv_dob.Add(reader.GetDateTime(4));
                list.Cv_email.Add(reader.GetString(5));
                list.Cv_language_skills.Add(reader.GetString(6));
                list.Cv_other_skills.Add(reader.GetString(7));
                list.Cv_permanent_address.Add(reader.GetString(8));
                list.Cv_current_address.Add(reader.GetString(9));
                list.Fathers_name.Add(reader.GetString(10));
                list.Mothers_name.Add(reader.GetString(11));
                list.Gender.Add(reader.GetString(12));
                list.National_id.Add(reader.GetString(13));
                list.Career_objective.Add(reader.GetString(14));
                list.Present_salary.Add(Convert.ToString(reader.GetDecimal(15)));
                list.Expected_salary.Add(Convert.ToString(reader.GetDecimal(16)));
                list.Looking_for.Add(reader.GetString(17));
                list.counter++;
                
            }


            this.connection.Close();
            return list;
        }

        public Cv GetCvDL(string cv_id)
        {
            string query = "select cv_name,cv_current_address,cv_mob,cv_dob,cv_email,cv_language_skills,cv_other_skills,cv_permanent_address,cv_current_address,fathers_name,mothers_name,gender,national_id,career_objective,present_salary,expected_salary,job_id,date_joined,current_company_name,current_company_address,job_id_looking_for from cv WHERE cv_id='"+cv_id+"'";
            ExecuteQuery(query);
            Cv cv = new Cv();
            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
               
                cv.Cv_name=reader.GetString(0);
                cv.Cv_postal_address=reader.GetString(1);
                cv.Cv_mob=reader.GetString(2);
                cv.Cv_dob=reader.GetDateTime(3);
                cv.Cv_email=reader.GetString(4);
                cv.Cv_language_skills=reader.GetString(5);
                cv.Cv_other_skills=reader.GetString(6);
                cv.Cv_permanent_address=reader.GetString(7);
                cv.Cv_current_address=reader.GetString(8);
                cv.Fathers_name=reader.GetString(9);
                cv.Mothers_name=reader.GetString(10);
                cv.Gender=reader.GetString(11);
                cv.National_id=reader.GetString(12);
                cv.Career_objective=reader.GetString(13);
                cv.Present_salary=Convert.ToDouble(reader.GetDecimal(14));
                cv.Expected_salary=Convert.ToDouble(reader.GetDecimal(15));
                cv.current_job_id=reader.GetString(16);
                cv.StartDate = reader.GetDateTime(17);
                cv.CurrentComapnyName = reader.GetString(18);
                cv.CurrentCompanyAddress = reader.GetString(19);
                cv.Looking_for_job_id = reader.GetString(20);
                

               

            }


            this.connection.Close();
            return cv;
        }
        public string GetJobTitleDL(string job_id) 
        {
            string query = "select job_name from job_title where job_id='" + job_id + "'";
            string job_title = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                job_title = reader.GetString(0);
            }

            this.connection.Close();
            return job_title;
        }
        public AcademicQualification GetAcademicQalificationsDL(string cv_id,AcademicQualification qalification)
        {
            string query = "select deg_name,result,pass_year from academic_qualification where cv_id='" + cv_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                qalification.Degree_name.Add(reader.GetString(0));
                qalification.Score.Add(reader.GetString(1));
                qalification.Year.Add(reader.GetString(2));
                qalification.counter++;
            }
            return qalification;
        }
        public EmploymentHistory GetEmploymentHistoryDL(string cv_id, EmploymentHistory employmentHistory)
        {
            string query = "select start_date,end_date,company_name,company_loc,postion from employment_history where cv_id='" + cv_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    employmentHistory.StartDate.Add(reader.GetDateTime(0));
                    employmentHistory.EndDate.Add(reader.GetDateTime(1));
                    employmentHistory.CompanyName.Add(reader.GetString(2));
                    employmentHistory.CompanyLoc.Add(reader.GetString(3));
                    employmentHistory.Position.Add(reader.GetString(4));
                }
                catch (NullReferenceException) { }
                employmentHistory.Counter++;
            }
            this.connection.Close();
            return employmentHistory;
        }
        public SkillSet GetSkillSetDL(string cv_id,SkillSet skillSet) 
        {
            string query = "select desciption from skill where cv_id='" + cv_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    skillSet.Description.Add(reader.GetString(0));
                }
                catch (NullReferenceException) { }
                skillSet.Counter++;
            }
            this.connection.Close();
            return skillSet;
        }
        public MyPosts GetJobHeadingDL(string company_id)
        {
            MyPosts post = new MyPosts();

            string query = "select job_title,post_date,add_id from job where company_id='" + company_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    post.JobTitle.Add(reader.GetString(0));
                    post.PostDate.Add(reader.GetDateTime(1));
                    post.Add_id.Add(reader.GetString(2));
                    post.Counter++;
                    
                }
                catch (NullReferenceException) { }
                
            }
            this.connection.Close();
            //return skillSet;

            return post;
        }
        public ApplicantList GeCvIdDL(string add_id)
        {
            ApplicantList list = new ApplicantList();

            string query="select cv_id from application where add_id='" +add_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    list.list.Add(reader.GetString(0));
                    list.Counter++;

                }
                catch (NullReferenceException) { }

            }
            this.connection.Close();
            return list;
        }

        public JobCategory GetJobCategoryDL() 
        {
            JobCategory category = new JobCategory();
            string query = "SELECT  job_id,job_name FROM job_title";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    category.JobId.Add(reader.GetString(0));
                    category.jobTitle.Add(reader.GetString(1));
                    category.counter++;
                   
                }
                catch (NullReferenceException) { }

            }
            this.connection.Close();
            return category;
        }
        public CVList GetCvListByApplicationDL(string add_id)
        {


            CVList list = new CVList();
            list.counter = 0;
            string query = "SELECT  cv_id,cv_name,present_salary,expected_salary FROM cv where cv_id IN(select cv_id from application WHERE add_id='"+add_id+"')";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    
                    list.Cv_id.Add(reader.GetString(0));
                    list.Cv_name.Add(reader.GetString(1));
                    list.Present_salary.Add(Convert.ToString(reader.GetDecimal(2)));
                    list.Expected_salary.Add(Convert.ToString(reader.GetDecimal(3)));
                    list.counter++;
                }
                catch (NullReferenceException) { }

            }
            this.connection.Close();
            return list;

        }

        public string CreateJobSeekerAccInDBDL(string cv_id,Account account) 
        {
            string query = "SELECT count(*) from account";
            ExecuteQuery(query);
            int count=0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                count=reader.GetInt32(0);
            }
            account.Acc_id = "jsk" + Convert.ToString(count);
            string pass="1234";
            string acc_type = "1";

            query = "Insert into account values('" + account.Acc_id + "','" + pass + "','" + acc_type + "')";
            ExecuteQuery(query);
            this.connection.Close();
            return pass;
        }
        public void RegisterJobSeekerInDbDL(Cv cv,string acc_id)
        {
            string query = "select count(*) FROM cv";
            ExecuteQuery(query);
            int count = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                count = reader.GetInt32(0);
            cv.Cv_id = "cv" + Convert.ToString(count);
            query = "INSERT INTO cv values('" + cv.Cv_id + "','" + cv.Cv_name + "','" + cv.Cv_postal_address + "','" + cv.Cv_mob + "','" + cv.Cv_dob + "','" + cv.Cv_email + "','" + cv.Cv_language_skills + "','" + cv.Cv_other_skills + "','" + cv.Cv_permanent_address + "','" + acc_id + "','" + cv.Cv_current_address + "','" + cv.Fathers_name + "','" + cv.Mothers_name + "','" + cv.Gender + "','" + cv.National_id + "','" + cv.Career_objective + "'," + cv.Present_salary + "," + cv.Expected_salary + ",'" + cv.current_job_id + "','" + cv.StartDate + "','" + cv.CurrentComapnyName + "','" + cv.CurrentCompanyAddress + "','" + cv.Looking_for_job_id + "','" + cv.JobNatureId + "')";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void AddJobPreferenceOfJobSeekerDL(string cv_id, JobPreference preference)
        {
            
            int count = 0;
            for (int i = 0; i < preference.Count; i++)
            {
              string query = "SELECT count(*) FROM job_references";
              ExecuteQuery(query);
              SqlDataReader reader = command.ExecuteReader();
              while (reader.Read())
                 count = reader.GetInt32(0);
              this.connection.Close();
              string job_pref_id = "pref" + Convert.ToString(count);
            

                query = "INSERT INTO job_references VALUES('" + job_pref_id + "','" + preference.JobId[i] + "','" + cv_id + "')";
                ExecuteQuery(query);
                this.connection.Close();
            }
            
        }
        public void AddJobLocationPreferenceOfJobSeekerDL(string cv_id, LocationPreference loc)
        {
            int count = 0;
            for (int i = 0; i < loc.Counter; i++)
            {
             string query = "SELECT count(*) FROM preferred_location";
             ExecuteQuery(query);
             SqlDataReader reader = command.ExecuteReader();
             while (reader.Read())
                count = reader.GetInt32(0);
             this.connection.Close();
             string loc_pref_id = "loc" + Convert.ToString(count);


             query = "INSERT INTO preferred_location VALUES('" + loc_pref_id + "','" + loc.LocId[i] + "','" + cv_id + "')";
                ExecuteQuery(query);
                this.connection.Close();
            }
        }

        public AddList GetAddIdListsDL(Add add)
        {
            AddList list = new AddList();
            //string str = "12/31/2014 12:00:00 AM";
            string query = "SELECT add_id,job_title,vacancies,exp_min,exp_max,dead_line FROM job WHERE job_nature='" + add.Job_nature + "' AND job_id='" + add.JobCategory + "' AND sal >=" + add.Sal +"AND salMax <="+add.SalMax+" AND exp_min >= " + add.Min_exp+"AND exp_max <="+add.Max_exp + " AND isPaid='" + 1 + "' AND datediff(day,dead_line,GETDATE()) <=0 ";
            ExecuteQuery(query);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                list.AddId.Add(reader.GetString(0));
                list.JobTitle.Add(reader.GetString(1));
                list.NoOfVacancies.Add(reader.GetInt32(2));
                list.Min_exp.Add(reader.GetInt32(3));
                list.Max_exp.Add(reader.GetInt32(4));
                list.Deadline.Add(reader.GetDateTime(5));
                list.Counter++;
            }
            this.connection.Close();
            return list;
        }

        public AddList GetAddIdListsDLByPref(Add add,string []preference)
        {
            AddList list = new AddList();
            //string str = "12/31/2014 12:00:00 AM";
            string query = "SELECT add_id,job_title,vacancies,exp_min,exp_max,dead_line FROM job WHERE  isPaid='" + 1 + "' AND datediff(day,dead_line,GETDATE()) <=0 AND Add_id IN(SELECT add_id from job WHERE add_id='" + preference[0] + "' or add_id='" + preference[1] + "')";
            ExecuteQuery(query);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.AddId.Add(reader.GetString(0));
                list.JobTitle.Add(reader.GetString(1));
                list.NoOfVacancies.Add(reader.GetInt32(2));
                list.Min_exp.Add(reader.GetInt32(3));
                list.Max_exp.Add(reader.GetInt32(4));
                list.Deadline.Add(reader.GetDateTime(5));
                list.Counter++;
            }
            this.connection.Close();
            return list;
        }

       
        public Add GetAddFromDataBaseDL(string add_id) 
        {
            Add add = new Add();
            string query = "select job_title,vacancies,job_nature,job_level,min_age,max_age,exp_min,exp_max,gender_pref,location,sal,salmax,job_resp,add_job_resp,education,company_id  from job where add_id='"+add_id+"'";
            ExecuteQuery(query);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                add.JobTitle=reader.GetString(0);
                add.NoOfVacancies=reader.GetInt32(1);
                add.Job_nature=reader.GetString(2);
                add.JobLevel=reader.GetString(3);
                add.AgeFrom=reader.GetInt32(4);
                add.AgeTo=reader.GetInt32(5);
                add.Min_exp = reader.GetInt32(6);
                add.Max_exp = reader.GetInt32(7);
                add.GenderPreference = reader.GetString(8);
                add.Location = reader.GetString(9);
                add.Sal = Convert.ToInt32(reader.GetDecimal(10));
                add.SalMax = Convert.ToInt32(reader.GetDecimal(11));
                add.JobResponsibility = reader.GetString(12);
                add.AdditionalJobResponsibility = reader.GetString(13);
                add.Education = reader.GetString(14);
                add.CompanyId = reader.GetString(15);
            }
            this.connection.Close();
            return add;
        }
        public string GetCompanyNameFromDBDL(string company_id)
        {
            string query = "SELECT company_name FROM company WHERE company_id='" + company_id + "'";
            string result = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            this.connection.Close();
            return result;
        }
        public string GetCompanyEmailFromDBDL(string company_id) 
        {
            string query = "SELECT billing_email_address FROM company WHERE company_id='" + company_id + "'";
            string result = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            this.connection.Close();
            return result;
        }
        public string GetCvIDFromDbDL(string acc_id) 
        {

            string query = "SELECT cv_id FROM cv WHERE acc_id='" + acc_id + "'";
            string result = "";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetString(0);
            }

            this.connection.Close();
            return result;
        }
        public void RecordApplication(JobApplication application)
        {
            string applicationId = MakeApplicationID();
            string query = "INSERT INTO APPLICATION VALUES('" +applicationId+ "','" + application.AddId + "','" + application.CvId + "','" + application.CompanyID + "')";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public string MakeApplicationID() 
        {
            string query = "select count(*) FROM Application";
            ExecuteQuery(query);
            int count = 0;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                count = reader.GetInt32(0);
            this.connection.Close();
            return "app"+Convert.ToString(count);
        }
        public string GetCvIDFromApplication(string cv_id,string add_id) 
        {
            string query = "SELECT cv_id FROM APPLICATION WHERE cv_id='"+cv_id+"' AND add_id='"+add_id+"'";
            string id = null;
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                id = reader.GetString(0);
            return id;

            
        }

        public AddList GetAddIdListsFromJobsDL(string cv_id)
        {
            AddList list = new AddList();
            //string str = "12/31/2014 12:00:00 AM";
            string query = "SELECT add_id,job_title,vacancies,exp_min,exp_max,dead_line FROM job WHERE    isPaid='" + 1 + "' AND datediff(day,dead_line,GETDATE()) <=0  AND job_id in(select job_id  from job_references where cv_id='"+cv_id+"')";
            ExecuteQuery(query);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.AddId.Add(reader.GetString(0));
                list.JobTitle.Add(reader.GetString(1));
                list.NoOfVacancies.Add(reader.GetInt32(2));
                list.Min_exp.Add(reader.GetInt32(3));
                list.Max_exp.Add(reader.GetInt32(4));
                list.Deadline.Add(reader.GetDateTime(5));
                list.Counter++;
            }
            this.connection.Close();
            return list;
        }

        public void AddAcademicQualification(AcademicQualification qualification) 
        {
            for (int i = 0; i < qualification.counter; i++)
            {
                string query = "Insert into academic_qualification values('" + GetQualificationId() + "','" + qualification.Degree_name[i] + "','" + qualification.Year[i] + "','" + qualification.Cv_id + "','" + qualification.Academic_Institute[i] + "','" + qualification.Score[i] + "')";
                ExecuteQuery(query);
                this.connection.Close();
            }
        }
        public string GetQualificationId() 
        {
            string query = "SELECT count(*) FROM academic_qualification";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
                count = reader.GetInt32(0);
            this.connection.Close();
            return "qa" + Convert.ToString(count);


        }
        public string GetEmpHistId() 
        {
            string query = "SELECT count(*) FROM employment_history";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
                count = reader.GetInt32(0);
            this.connection.Close();
            return "ehist" + Convert.ToString(count);

        }
        public void AddEmploymentHistory(EmploymentHistory history)
        {
            string str = "";
            for (int i = 0; i < history.Counter; i++)
            {
                string query ="Insert into employment_history values('" + GetEmpHistId() + "','" + history.StartDate[i] + "','" + history.EndDate[i] + "','" + history.CompanyName[i] + "','" +history.Cv_id + "','" + str + "','"+history.Position[i]+"')";
                ExecuteQuery(query);
                this.connection.Close();
            }
        }

        public void UpdateCurrentJob(CurrentJob job) 
        {
            string query = "update cv set job_id='"+job.JobId+"',date_joined='"+job.DateJoined+"',current_company_name='"+job.CurrentCompanyName+"',present_salary="+job.PresentSalary+" where cv_id='"+job.Cv_id+"'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void AddSkill(SkillSet skills) 
        {


            for (int i = 0; i < skills.Counter; i++)
            {
                string query = "insert into skill values('" + GetSkillId() + "','" + skills.Description[i] + "','" + skills.cv_id + "')";
                ExecuteQuery(query);
            }
            this.connection.Close();
        }
        public string GetSkillId()
        {
            string query = "SELECT count(*) FROM skill";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            int count = 0;
            while (reader.Read())
                count = reader.GetInt32(0);
            this.connection.Close();
            return "sk" + Convert.ToString(count);

        }
        public string GetPasswordFromCv(string acc_id)
        {
            string query = "select acc_pass from account WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public string GetPasswordFromCompany(string acc_id)
        {
            string query = "select acc_pass from account WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            SqlDataReader reader = command.ExecuteReader();
            string no = null;
            while (reader.Read())
                no = reader.GetString(0);
            this.connection.Close();
            return no;
        }
        public void UpDatePasswordJSK(string acc_id, string pass)
        {
            string query = "update account SET acc_pass='" + pass + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        public void UpDatePasswordCorporate(string acc_id, string pass)
        {
            string query = "update account SET acc_pass='" + pass + "' WHERE acc_id='" + acc_id + "'";
            ExecuteQuery(query);
            this.connection.Close();
        }
        
        

       
        
    }
}