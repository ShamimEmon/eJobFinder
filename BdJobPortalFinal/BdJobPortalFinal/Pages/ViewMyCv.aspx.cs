using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BdJobPortalFinal.Business_layer;


namespace BdJobPortalFinal.Pages
{
    public partial class ViewMyCv : System.Web.UI.Page
    {
        private CVInfoAdder adder = new CVInfoAdder();
        protected void Page_Load(object sender, EventArgs e)
        {
          string acc_id=(string)Session["acc_id"];
          string cv_id=adder.GetCvIDFromDbBL(acc_id);
          Response.Redirect("http://localhost:26799/Pages/ViewCvMaster2.aspx?id="+cv_id);
        }
    }
}