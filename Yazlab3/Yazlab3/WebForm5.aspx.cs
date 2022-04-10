using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yazlab3
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            LoadData();

            }
        }
        void LoadData()
        {
            var st = from s in db.bolumlertablosu select s;
            GridView1.DataSource = st;
            GridView1.DataBind();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4SSIBJ2;Initial Catalog=yazlab;Integrated Security=True");
            baglan.Open();

            SqlCommand komut = new SqlCommand("Select * from bolumlertablosu where adisoyadi like  '%" + TextBox1.Text + "%' or baslik like '%" + TextBox1.Text + "%' or dersadi like '%" + TextBox1.Text + "%' or anahtarkelimeler like '%" + TextBox1.Text + "%' or baslik like '%" + TextBox1.Text + "%'  or tarih like '%" + TextBox1.Text + "%' ", baglan);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            //  SqlDataAdapter da = new SqlDataAdapter("Select * from pdflertablosu2",baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //baglan.Close();
        }
    }
}