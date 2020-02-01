using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionVsCache
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Session["UName"] = txtUser.Text;
            Session["Pwd"] = txtPwd.Text;
            Response.Redirect("AfterSessionRedirect.aspx");
        }
    }
}