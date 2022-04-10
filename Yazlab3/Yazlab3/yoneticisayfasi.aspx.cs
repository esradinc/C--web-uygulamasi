using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yazlab3
{
    public partial class yoneticisayfasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void kullanicieklebutonu_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm3.aspx");
        }

        protected void pdfgoruntule_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm4.aspx");
        }

        protected void listele_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm5.aspx");
        }
    }
}