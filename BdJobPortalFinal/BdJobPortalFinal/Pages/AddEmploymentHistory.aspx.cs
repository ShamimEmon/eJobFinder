using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;

namespace BdJobPortalFinal.Pages
{
    public partial class AddEmploymentHistory : System.Web.UI.Page
    {
        public EmploymentHistory history = new EmploymentHistory();
        private CVInfoAdder adder = new CVInfoAdder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["employment_history"] != null)
                this.history = (EmploymentHistory)ViewState["employment_history"];
            finish.Click += FinishListener;
            addAnother.Click += AddAnotherAction;
            removeAnother.Click += RemoveLastAction;

            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void FinishListener(object sender, EventArgs e)
        {
            if (ViewState["employment_history"] != null)
            {
                this.history = (EmploymentHistory)ViewState["employment_history"];
                string acc_id = (string)Session["acc_id"];
                this.history.Cv_id = GetCvIdFromAccount(acc_id);
                this.adder.AddEmploymentHistoryBL(this.history);
                Response.Redirect("http://localhost:26799/Pages/CvHomePage.aspx");

            }
            else
                SetErrMsg();
        }
        public string GetCvIdFromAccount(string acc_id)
        {
            return this.adder.GetCvIDFromDbBL(acc_id);
        }
        public void AddAnotherAction(object sender, EventArgs e)
        {
           if (IsAllFieldsOk())
            {
                GetInput();
                ViewState["employment_history"] = null;
                ViewState["employment_history"] = this.history;
                ClearFields();
                err_msg.InnerText = "";
            }
            else
                SetErrMsg();

        }
        public void GetInput()
        {
            this.history.CompanyName.Add(company.Value);
            try
            {
                this.history.StartDate.Add(Convert.ToDateTime(sdate.Value));
                this.history.EndDate.Add(Convert.ToDateTime(edate.Value));
            }
            catch (FormatException) 
            {
                err_msg.InnerText = "Invalid Date Format";
                ClearFields();
            }
            this.history.Position.Add(position.Value);
            this.history.Counter++;
        }
        public void RemoveLastAction(object sender, EventArgs e)
        {
            if (ViewState["employment_history"] != null)
            {
                this.history = (EmploymentHistory)ViewState["employment_history"];
                RemoveCurrentItem(this.history.Counter - 1);
                ViewState["employment_history"] = this.history;


            }
        }
        public void RemoveCurrentItem(int i)
        {
            if (i >= 0)
            {
                this.history.CompanyName.RemoveAt(i);
                this.history.StartDate.RemoveAt(i);
                this.history.EndDate.RemoveAt(i);
                this.history.Position.RemoveAt(i);
                this.history.Counter--;
            }
        }

        public void ClearFields()
        {
            position.Value = "";
            sdate.Value = "";
            edate.Value = "";
            company.Value = "";
        }
        public void SetErrMsg()
        {
            err_msg.InnerText = "Fill all the Fields";
        }
        public bool IsAllFieldsOk()
        {
            if (position.Value.Length == 0)
                return false;
            if (sdate.Value.Length == 0)
                return false;
            if (edate.Value.Length == 0)
                return false;
            if (company.Value.Length == 0)
                return false;
            return true;
        }
        
    }
}