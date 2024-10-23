using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MinikPatiler
{
    public partial class AnaEkran : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnadminlogin_Click(object sender, EventArgs e)
        {

        }
        protected void btn_admin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/YoneticiPaneli/GirisPaneli.aspx");
        }
    }
}