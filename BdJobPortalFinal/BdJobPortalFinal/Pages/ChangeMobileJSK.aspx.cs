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
    public partial class ChangeMobileJSK : System.Web.UI.Page, IClientSiteHandler
    {
        private Mobile mob = new Mobile();
        private MobileUpdatorJSK updator = new MobileUpdatorJSK();
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
                Response.Redirect("http://localhost:26799/Pages/JobSeekerAccountHome.aspx");
                return;
            }
            SetErrMsg();
            ClearFields();
        }
        public void UpdateCv()
        {
            string acc_id = (string)Session["acc_id"];
            updator.UpDateMobileBL(acc_id, this.mob.NewNumber);
        }
        public bool IsCurrentCorrectCB()
        {
            string acc_id = (string)Session["acc_id"];
            return this.updator.IsNumberCorrectBL(acc_id, this.mob.CurrentNumber);

        }
        public bool IsNewAndReNewMatchCB()
        {
            return updator.IsNewAndReNewMatchBL(this.mob.NewNumber, this.mob.ReNewNumber);
        }
        public void GetInput()
        {
            try
            {
                mob.CurrentNumber = current_mob.Value;
                mob.NewNumber = new_mob.Value;
                mob.ReNewNumber = re_new.Value;
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
                if (mob.CurrentNumber.Length == 0)
                    return false;
                if (mob.NewNumber.Length == 0)
                    return false;
                if (mob.ReNewNumber.Length == 0)
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