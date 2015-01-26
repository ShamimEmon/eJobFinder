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
    public partial class ChangePasswordCorporate : System.Web.UI.Page
    {
        private Credential acc = new Credential();
        private PasswordUpdatorJSK updator = new PasswordUpdatorJSK();
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
                UpdateCv();
                Response.Redirect("http://localhost:26799/Pages/Corporate_home_account.aspx");
                return;
            }
            SetErrMsg();
            ClearFields();
        }
        public void UpdateCv()
        {
            string acc_id = (string)Session["acc_id"];
            updator.UpDatePassBL(acc_id, this.acc.NewPass);
        }
        public bool IsCurrentCorrectCB()
        {
            string acc_id = (string)Session["acc_id"];
            return this.updator.IsPassCorrectBL(acc_id, this.acc.CurrentPass);

        }
        public bool IsNewAndReNewMatchCB()
        {
            return updator.IsNewAndReNewMatchBL(this.acc.NewPass, this.acc.ReNewPass);
        }
        public void GetInput()
        {
            try
            {
                acc.CurrentPass = current_mob.Value;
                acc.NewPass = new_mob.Value;
                acc.ReNewPass = re_new.Value;
            }
            catch (NullReferenceException) { }
        }
        public void ClearFields()
        {
            current_mob.Value = "";
            new_mob.Value = "";
            re_new.Value = "";

        }
        public void SetErrMsg()
        {
            acc_err_div.Visible = true;
        }
        public bool IsAllFieldsOk()
        {
            try
            {
                if (acc.CurrentPass.Length == 0)
                    return false;
                if (acc.NewPass.Length == 0)
                    return false;
                if (acc.ReNewPass.Length == 0)
                    return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
            return true;
        }
    }
}