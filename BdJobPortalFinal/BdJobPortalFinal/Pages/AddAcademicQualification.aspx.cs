using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_object_layer;
using BdJobPortalFinal.Helpers;
using BdJobPortalFinal.Business_layer;


namespace BdJobPortalFinal.Pages
{
    public partial class AddAcademicQualification : System.Web.UI.Page, IClientSiteHandler
    {
        
        public AcademicQualification qualification=new AcademicQualification();
        public CVInfoAdder adder = new CVInfoAdder();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (ViewState["qualification"]!=null)
                this.qualification=(AcademicQualification)ViewState["qualification"];
          
           addAnother.Click+= AddAnotherAction;
           removeAnother.Click+= RemoveLastAction;
           finish.Click+= FinishListener;
           Logger logger = new Logger();
           logger.IsLoggout();
        }
        public void FinishListener(object sender, EventArgs e) 
        {
            if (ViewState["qualification"] != null)
            {
                this.qualification = (AcademicQualification)ViewState["qualification"];
                string acc_id = (string)Session["acc_id"];
                this.qualification.Cv_id = GetCvIdFromAccount(acc_id); ;
                this.adder.AddAcademicQualificationBL(this.qualification);
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
                ViewState["qualification"] = null;
                ViewState["qualification"] = this.qualification;
                ClearFields();
                err_msg.InnerText = "";
            }
            else
                SetErrMsg();

        }
        public void GetInput() 
        {
            this.qualification.Degree_name.Add(deg.Value);
            this.qualification.Score.Add(score.Value);
            this.qualification.Year.Add(year.Value);
            this.qualification.Academic_Institute.Add(institute.Value);
            this.qualification.counter++;
        }
        public void RemoveLastAction(object sender, EventArgs e) 
        {
            if (ViewState["qualification"] != null) 
            {
                this.qualification=(AcademicQualification)ViewState["qualification"];
                RemoveCurrentItem(this.qualification.counter-1);
                ViewState["qualification"] = this.qualification;
                

            }
        }
        public void RemoveCurrentItem(int i) 
        {
            if (i >= 0)
            {
                this.qualification.Academic_Institute.RemoveAt(i);
                this.qualification.Degree_name.RemoveAt(i);
                this.qualification.Score.RemoveAt(i);
                this.qualification.Year.RemoveAt(i);
                this.qualification.counter--;
            }
        }
        
        public void ClearFields()
        {
            deg.Value ="";
            score.Value ="";
            institute.Value ="";
            year.Value = "";
        }
        public void SetErrMsg() 
        {
            err_msg.InnerText = "Fill all the Fields";
        }
        public bool IsAllFieldsOk()
        {
            if (deg.Value.Length == 0)
                return false;
            if (score.Value.Length == 0)
                return false;
            if (institute.Value.Length == 0)
                return false;
            if (year.Value.Length == 0)
                return false;
            return true;
        }
        

    }
}