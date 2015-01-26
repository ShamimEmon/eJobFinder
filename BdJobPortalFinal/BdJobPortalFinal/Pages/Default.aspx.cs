using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Helpers;


namespace BdJobPortalFinal.Pages
{
    public partial class Default : System.Web.UI.Page
    {
        private Add add = new Add();
        private AddList list = new AddList();
        private AddListCreator creator = new AddListCreator();

        public AddList GetAddIdListsCB(Add add)
        {
            return creator.GetAddIdListsBL(add);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            job_search_button.Click += Listener;
        }
        public void Listener(object sender, EventArgs e)
        {
            GetInput();
            if (IsAllFieldsOk() == false)
            {
                SetErrMsg();
                return;
            }
            this.list = GetAddIdListsCB(this.add);
            Session["JobAddList"] = this.list;
            Response.Redirect("http://localhost:26799/Pages/SearchList.aspx");

        }

        public void GetInput()
        {
            SetJobNature();
            this.add.JobCategory = job_category.Value;
            SetSalaryRange();
            SetJobExp();

        }
        public void SetJobNature()
        {
            if (job_type.Value == "1")
                this.add.Job_nature = "Full Time";
            if (job_type.Value == "2")
                this.add.Job_nature = "Part Time";
            if (job_type.Value == "3")
                this.add.Job_nature = "Contract";
        }
        public void ClearFields()
        {
            //do nothing
        }
        public void SetErrMsg()
        {
            job_search_err.Visible = true;
        }
        public bool IsAllFieldsOk()
        {
            if (add.Job_nature == "0")
                return false;
            if (add.JobCategory == "0")
                return false;
            if (job_salary_range.Value == "0")
                return false;
            if (job_experience_range.Value == "0")
                return false;
            return true;
        }
        public void SetSalaryRange()
        {

            if (job_salary_range.Value == "1")
            {
                add.Sal = 20000;
                add.SalMax = 35000;
            }
            if (job_salary_range.Value == "2")
            {
                add.Sal = 36000;
                add.SalMax = 50000;
            }

        }
        public void SetJobExp()
        {
            if (job_experience_range.Value == "1")
            {
                add.Min_exp = 0;
                add.Max_exp = 0;
            }
            if (job_experience_range.Value == "2")
            {
                add.Min_exp = 2;
                add.Max_exp = 5;
            }
            if (job_experience_range.Value == "3")
            {
                add.Min_exp = 6;
                add.Max_exp = 100;
            }

        }
        
    }
}