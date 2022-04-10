using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Yazlab3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static string kullaniciidsi;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void yoneticibutonu_Click(object sender, EventArgs e)
        {
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from yoneticitablosu where kullaniciadi='"+kullaniciadialani.Text+"' and sifre ='"+sifrealani.Text+"'",con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                sda.Fill(dt);   
                cmd.ExecuteNonQuery();  
                if(dt.Rows[0][0].ToString()=="1")
                {
                    //Response.Write("<script>alert('basarili')</script");
                    Response.Redirect("~/yoneticisayfasi.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Kullanici adi veya sifre hatali.')</script");
                }

            }catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void kullanicibutonu_Click(object sender, EventArgs e)
        {
            

            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string kullaniciidsi2 = kullaniciadialani.Text;
                SqlCommand cmd = new SqlCommand("select count(*) from kullanicilartablosu where kullaniciadi='" +kullaniciidsi2 + "' and sifre ='" + sifrealani.Text + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows[0][0].ToString() == "1")
                {   
                      kullaniciidsi = kullaniciidsi2;
                    //Response.Write("<script>alert('basarili')</script");
                    Response.Redirect("~/kullanicisayfasi.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Kullanici adi veya sifre hatali.')</script");
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    }
}