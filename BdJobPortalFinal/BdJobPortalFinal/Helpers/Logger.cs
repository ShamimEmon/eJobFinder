using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BdJobPortalFinal.Helpers
{
    public class Logger : System.Web.UI.Page
    {
        public  void IsLoggout() 
        {
            string id = (string)Session["acc_id"];
            if(id==null)
               HttpContext.Current.Response.Redirect("http://localhost:26799/Pages/Default.aspx");
        }
    }
}