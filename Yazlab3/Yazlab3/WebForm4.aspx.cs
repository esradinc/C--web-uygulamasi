using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yazlab3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        public static string dosyaadi;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();

            }

        }

        void LoadData()
        {
            var st = from s in db.pdflertablosu2 select s;
            GridView1.DataSource = st;
            GridView1.DataBind();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int rowIndex = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
            string dosyakonumu = GridView1.Rows[rowIndex].Cells[3].Text;
            dosyaadi = GridView1.Rows[rowIndex].Cells[2].Text;
            // System.Diagnostics.Process.Start("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" +dosyaadi+ ".txt");
            System.Diagnostics.Process.Start("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/" + dosyakonumu);
            Response.Redirect("~/WebForm6.aspx");
        }
    }
}