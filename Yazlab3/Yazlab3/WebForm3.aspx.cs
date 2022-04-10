using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.IO;

namespace Yazlab3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4SSIBJ2;Initial Catalog=yazlab;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadData();
            }
        }
        void LoadData()
        {
            var st = from s in db.kullanicilartablosu select s;
            GridView1.DataSource = st;
            GridView1.DataBind();

        }
      

        protected void eklebutonu_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "Insert INTO kullanicilartablosu(kullaniciid,kullaniciadi,sifre) VALUES('" + idalani.Text + "','" + adalani.Text + "','" + sifrealani.Text + "')";
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();

        }

        protected void silbutonu_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "delete from kullanicilartablosu where kullaniciid=@kullaniciid";
            cmd.Parameters.AddWithValue("@kullaniciid",idalani.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();

        }

        protected void guncellebutonu_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglan;
            cmd.CommandText = "update kullanicilartablosu set kullaniciid='" + idalani.Text + "', kullaniciadi='" + adalani.Text + "',sifre='" + sifrealani.Text + "'where kullaniciid=@kullaniciid";
            cmd.Parameters.AddWithValue("@kullaniciid", idalani.Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglan.Close();
        }
    }
}