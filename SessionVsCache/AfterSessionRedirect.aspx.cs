using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVsCache
{
    public partial class AfterSessionRedirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UName"] != null && Session["Pwd"] != null)
            {
                lblUsr.Text = Session["UName"].ToString();
                lblPwd.Text = Session["Pwd"].ToString();
            }
            else
            {
                lblUsr.Text = "Session of UName key is not set";
                lblPwd.Text = "Session of Pwd key is not set";
            }
        }
    }
}