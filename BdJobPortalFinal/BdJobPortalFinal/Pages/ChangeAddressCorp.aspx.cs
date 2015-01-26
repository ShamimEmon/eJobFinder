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
    public partial class ChangeAddressCorp : System.Web.UI.Page,IClientSiteHandler,ICompanyInfoUpdator
    {
        private BillingAddress add = new BillingAddress();
        private BillingAddressUpdator updator = new BillingAddressUpdator();
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
                add.CurrentBillingAddress = current_address.Value;
                add.NewBillingAddress = new_address.Value;
                add.ReNewBillingAddress = re_address.Value;
            }
            catch (NullReferenceException) { }
        }
        public void ClearFields()
        {
            current_address.Value = "";
            new_address.Value = "";
            re_address.Value = "";

        }
        public void SetErrMsg()
        {
            acc_err_div.Visible = true;
        }
        public bool IsAllFieldsOk()
        {
            try
            {
                if (add.CurrentBillingAddress.Length == 0)
                    return false;
                if (add.NewBillingAddress.Length == 0)
                    return false;
                if (add.ReNewBillingAddress.Length == 0)
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
            updator.UpDateAddressBL(acc_id, this.add.NewBillingAddress);
        }
        public bool IsCurrentCorrectCB()
        {
            string acc_id = (string)Session["acc_id"];
            return this.updator.IsAddressCorrectBL(acc_id, this.add.CurrentBillingAddress);

        }
        public bool IsNewAndReNewMatchCB()
        {
            return updator.IsNewAndReNewMatchBL(this.add.NewBillingAddress, this.add.ReNewBillingAddress);
        }

    }
}