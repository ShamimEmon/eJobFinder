using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Business_layer;
using BdJobPortalFinal.Database_layer;


namespace BdJobPortalFinal.Pages
{
    public partial class Corporate_registration : System.Web.UI.Page,IClientSiteHandler
    {
        private Company company = new Company();
        private Account account = new Account();
        private Account_register acc_register = new Account_register();
        private Data_handler handler = new Data_handler();
        private string temp_pass ="";
        private bool isInputOk=true;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //err1.InnerText = "";
            register.Click += RegisterAction;
        }
        public void RegisterCorporateuserCB() 
        {
            this.acc_register.RegisterCorporateUserBL(this.account,this.company);
        }
        public void RegisterAction(object sender, EventArgs e)
        {
            
            GetInput();
            if(IsAllFieldsOk()==false )
                this.isInputOk=false; 
             
            if (IsAMatch() == false)
                this.isInputOk = false;
            
            
            if (isDupCB(this.account.Acc_id) == true)
                this.isInputOk = false;
            
            if (this.isInputOk == true)
            {

                RegisterCorporateuserCB();
                Response.Redirect("http://localhost:26799/Pages/Corporate_Login.aspx");
                return;

            }
            SetErrMsg();
            ClearFields();

            
           
                
            
            
                
        }
       public void GetInput()
        {
            try
            {
                this.account.Acc_id = acc_id.Value;
                this.account.Acc_pass = acc_pass.Value;
                this.temp_pass = acc_pass_re.Value;

                this.company.Company_name = company_name.Value;
                this.company.Contact_person = contact_person.Value;
                this.company.Company_description = company_description.Value;
                this.company.Industry_type = industry_type.Value;
                this.company.Company_address = company_address.Value;
                this.company.Company_city = city.Value;
                this.company.Company_area = area.Value;
                this.company.Company_country = country.Value;
                this.company.Billing_address = billing_address.Value;
                this.company.Billing_contact_no = contact_phone.Value;
                this.company.Billing_email = email.Value;
            }
            catch (NullReferenceException) 
            {
                
            }   
       }
       public bool IsAllFieldsOk() 
       {
           if(this.account.Acc_id.Length==0)
             return false;
           if(this.account.Acc_pass.Length==0)
             return false;
           if (this.temp_pass.Length == 0) 
              return false;
           if (this.company.Company_name.Length == 0) 
              return false;
           if (this.company.Contact_person.Length == 0) 
              return false;
           if (this.company.Company_description.Length == 0) 
              return false;
           if (this.company.Industry_type.Length == 0) 
              return false;
           if (this.company.Company_address.Length == 0) 
              return false;
           if (this.company.Company_city.Length == 0) 
              return false;
           if (this.company.Company_area.Length == 0) 
              return false;
           if (this.company.Company_country.Length == 0)
               return false;
           if (this.company.Billing_address.Length == 0)
               return false;
           if (this.company.Billing_contact_no.Length == 0)
               return false;
           if (this.company.Billing_email.Length == 0)
               return false;
           return true;
       }
       public bool IsAMatch()
       {
           if (temp_pass == this.account.Acc_pass)
               return true;
           return false;
       }
      
       public void ClearFields() 
       {
           acc_pass.Value = "";
           acc_pass_re.Value = "";

       }
       public  void SetErrMsg() 
       {
           err_div.Visible = true; 
       }
       public bool isDupCB(string str) 
       {
           return acc_register.isDupBL(str);
       }
    }
}