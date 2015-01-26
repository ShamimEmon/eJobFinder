using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;

namespace BdJobPortalFinal.Pages
{
    public partial class JobSeekerLogin : System.Web.UI.Page,IClientSiteHandler
    {
        private Account clientAcc = new Account();
        private Authenticator authenticator = new Authenticator();
        private bool isInputOk = true;

        protected void Page_Load(object sender, EventArgs e)
        {
            login_button.Click += LoginAction;



        }
        public bool IsAllFieldsOk()
        {
            if (this.clientAcc.Acc_id.Length == 0)
                return false;
            if (this.clientAcc.Acc_pass.Length == 0)
                return false;
            return true;
        }

        public void LoginAction(object sender, EventArgs e)
        {
            GetInput();

            if (IsCredentialValidCB() == false)
                this.isInputOk = false;

            if (IsAllFieldsOk() == false)
                this.isInputOk = false;

            if (this.isInputOk == true)
            {
                this.clientAcc = GetAccountCB(this.clientAcc);
                Session["acc_id"] = this.clientAcc.Acc_id;
                //string company_id = GetCompanyIdCB(this.clientAcc.Acc_id);
                //Session["company_id"] = company_id;

               // if (this.clientAcc.Acc_type == "2")
                   // Response.Redirect("http://localhost:26799/Pages/Corporate_home_account.aspx");
                if (this.clientAcc.Acc_type == "1")
                    Response.Redirect("http://localhost:26799/Pages/JobSeekerAccountHome.aspx");
            }
            ClearFields();
            SetErrMsg();
        }
        public string GetCompanyIdCB(string acc_id)
        {
            return authenticator.GetCompanyIdBL(acc_id);
        }
        public void ClearFields()
        {
            user_name.Value = "";
            user_pass.Value = "";
        }
        public Account GetAccountCB(Account account)
        {
            return this.authenticator.GetAccountBL(account);
        }
        public void GetInput()
        {
            try
            {
                this.clientAcc.Acc_id = user_name.Value;
                this.clientAcc.Acc_pass = user_pass.Value;
            }
            catch (NullReferenceException)
            {

            }
        }

        public bool IsCredentialValidCB()
        {
            return authenticator.IsCredentialValidBL(this.clientAcc);

        }
        public void SetErrMsg()
        {
            err.InnerText = "Invalid Id or Password";
        }
    }
}