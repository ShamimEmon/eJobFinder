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
    public partial class AddSkill : System.Web.UI.Page
    {   
        public SkillSet skills = new SkillSet();
        private SkillAdder adder = new SkillAdder();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["skillset"] != null)
            {
                this.skills = (SkillSet)ViewState["skillset"];
            }
            addAnother.Click +=AddSkillListener;
            removeAnother.Click += RemoveLastAction;
            finish.Click += FinishListener;
            Logger logger = new Logger();
            logger.IsLoggout();
        }
        public void FinishListener(object sender, EventArgs e) 
        {

            if (ViewState["skillset"] != null)
            {
                this.skills = (SkillSet)ViewState["skillset"];
                string acc_id = (string)Session["acc_id"];
                this.skills.cv_id = this.adder.GetCvIDFromDbBL(acc_id);
                this.adder.AddSkillBL(this.skills);
                Response.Redirect("http://localhost:26799/Pages/CvHomePage.aspx");

            }
            else
                err_msg.InnerText = "Type your skills";

        }
        public void AddSkillListener(object sender, EventArgs e) 
        {
            
            string acc_id=(string)Session["acc_id"];
            this.skills.cv_id=adder.GetCvIDFromDbBL(acc_id);
            if (skill.Value.Length != 0)
            {
                this.skills.Description.Add(skill.Value);
                this.skills.Counter++;
                ViewState["skillset"] = this.skills;
                skill.Value = "";
                err_msg.InnerText = "";
            }
            else
                err_msg.InnerText = "Type your skills";
        }

        public void RemoveLastAction(object sender, EventArgs e)
        {
            if (ViewState["skillset"] != null)
            {
                this.skills = (SkillSet)ViewState["skillset"];
                RemoveCurrentItem(this.skills.Counter-1);
                ViewState["skillset"] = this.skills;


            }
        }
        public void RemoveCurrentItem(int i)
        {
            if (i >= 0)
            {
                this.skills.Description.RemoveAt(i);
                this.skills.Counter--;
            }
        }
    }
}