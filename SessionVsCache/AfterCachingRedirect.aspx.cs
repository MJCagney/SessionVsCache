using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVsCache
{
    public partial class AfterCachingRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["UName"] != null && Cache["Pwd"] != null)
            {
                lblUsr.Text = Cache["UName"].ToString();
                lblPwd.Text = Cache["Pwd"].ToString();
            }
            else
            {
                lblUsr.Text = "Caching of UName key is not set";
                lblPwd.Text = "Caching of Pwd key is not set";
            }
        }
    }
}