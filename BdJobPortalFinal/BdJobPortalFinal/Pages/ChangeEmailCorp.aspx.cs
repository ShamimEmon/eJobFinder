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
    public partial class ChangeEmailCorp : System.Web.UI.Page,IClientSiteHandler,ICompanyInfoUpdator
    {
        private Email email = new Email();
        private CorporateEmailUpdator updator = new CorporateEmailUpdator();
        private bool flag = true;
        protected void Page_Load(object sender, EventArgs e)
        {
            update_btn.Click += UpdateAction;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void UpdateAction(object sender, EventArgs e)
        {
            GetInput();
            if (IsNewAndReNewMatchCB() == false)
                this.flag = false;
            if (IsCurrentCorrectCB() == false)
                this.flag = false;
            if (IsAllFieldsOk() == false)
                this.flag = false;
            if (this.flag == true)
            {
                UpdateCompany();
                Response.Redirect("http://localhost:26799/Pages/Corporate_home_account.aspx");
                return;
            }
            SetErrMsg();
            ClearFields();
        }
        public void GetInput() 
        {
            try
            {
                email.CurrentEmail = current_email.Value;
                email.NewEmail = new_email.Value;
                email.ReNwEmail = re_email.Value;
            }
            catch (NullReferenceException) { }
        }
        public void ClearFields() 
        {
            current_email.Value = "";
            new_email.Value = "";
            re_email.Value = "";

        }
        public void SetErrMsg() 
        {
            acc_err_div.Visible = true;
        }
        public bool IsAllFieldsOk() 
        {
            try
            {
                if (email.CurrentEmail.Length == 0)
                    return false;
                if (email.NewEmail.Length == 0)
                    return false;
                if (email.ReNwEmail.Length == 0)
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
            
        }
        public void UpdateCompany()
        {
            string acc_id = (string)Session["acc_id"];
            updator.UpDateEmailBL(acc_id, this.email.NewEmail);
        }
        public bool IsCurrentCorrectCB()
        {
            string acc_id = (string)Session["acc_id"];
            return this.updator.IsEmailCorrectBL(acc_id, this.email.CurrentEmail);

        }
        public bool IsNewAndReNewMatchCB()
        {
            return updator.IsNewAndReNewMatchBL(this.email.NewEmail, this.email.ReNwEmail);
        }
    }
}