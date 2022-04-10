using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace Yazlab3
{
    // kullanici adina uygun kolonları getir

    public partial class kullanicisayfasi : System.Web.UI.Page
    {
        public static string dosyaadi;
        string dokuman;
        string kullaniciadi;
       
              protected void Page_Load(object sender, EventArgs e)
        {
        

            kullaniciadi = WebForm1.kullaniciidsi;
          //  TextBox3.Text = kullaniciadi;
            ad.Text= kullaniciadi;
            DataClasses1DataContext db = new DataClasses1DataContext();
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-4SSIBJ2;Initial Catalog=yazlab;Integrated Security=True");
            baglan.Open();

            SqlCommand komut = new SqlCommand("Select * from pdflertablosu2 where kullaniciid like  '%" + ad.Text + "%'  ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //  SqlDataAdapter da = new SqlDataAdapter("Select * from pdflertablosu2",baglan);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
            //baglan.Close();



        }
    
        DataClasses1DataContext db = new DataClasses1DataContext();

  
        protected void Button1_Click1(object sender, EventArgs e)
        {
            /*
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from kullanicilartablosu ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                 kullanici = reader.GetString(0);
                }
            }
           
            string fname = FileUpload1.FileName;
            string flocation = "Pdf File/";
            string pathstring = System.IO.Path.Combine(flocation, fname);
          
            
            var st = new pdflertablosu2
            {
                kullaniciid = kullanici,
                dosyaadi = TextBox1.Text,
                dosyakonumu = pathstring,
                
            };         
            db.pdflertablosu2.InsertOnSubmit(st);
            db.SubmitChanges();
            FileUpload1.SaveAs(MapPath(pathstring));
            Label1.Text = "basarili";
            LoadData();
           
            //yuklenen pdfi texte donusturup klasore atiyor
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/" + pathstring);
            f.ToText("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" + TextBox1.Text + ".txt");

            string dosyayolu = @"C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" + TextBox1.Text + ".txt";
            string text = System.IO.File.ReadAllText(dosyayolu);
            */
            /*
            string constr = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand("select * from kullanicilartablosu ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read() == true)
                {
                    kullanici = reader.GetString(0);
                }
            }

*/          
                      
            string fname = FileUpload1.FileName;
            string flocation = "Pdf File/";
            string pathstring = System.IO.Path.Combine(flocation, fname);


            var st = new pdflertablosu2
            {
                kullaniciid = kullaniciadi,
                dosyaadi = TextBox1.Text,
                dosyakonumu = pathstring,

            };
            db.pdflertablosu2.InsertOnSubmit(st);
            db.SubmitChanges();
            FileUpload1.SaveAs(MapPath(pathstring));
            Label1.Text = "basarili";
           

            //yuklenen pdfi texte donusturup klasore atiyor
            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            f.OpenPdf("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/" + pathstring);
            f.ToText("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" + TextBox1.Text + ".txt");

            string dosyayolu = @"C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" + TextBox1.Text + ".txt";
            string text = System.IO.File.ReadAllText(dosyayolu);
            //adsoyad kısmı
            string araadsoyadbas1 = "Adı Soyadı: ";
            var adsoyadbas1 = text.IndexOf(araadsoyadbas1, 0, text.Length - 1);
            string araadsoyadson1 = "İmza:";
            var adsoyadson1 = text.IndexOf(araadsoyadson1, 0, text.Length - 1);
            int uzunlukadsoyad = adsoyadson1 - adsoyadbas1;
            String adsoyad1;
            adsoyad1 = text.Substring(adsoyadbas1 + araadsoyadbas1.Length, uzunlukadsoyad - araadsoyadbas1.Length);
            //numarakısmı
            string aranobas = "Öğrenci No: ";
            var nobas = text.IndexOf(aranobas, 0, text.Length - 1);
            string aranoson = "Adı Soyadı: ";
            var noson = text.IndexOf(aranoson, 0, text.Length - 1);
            int uzunlukno = noson - nobas;
            String no1;
            no1 = text.Substring(nobas + aranobas.Length, uzunlukno - aranobas.Length);

            //ozet kısmını cekti
            string araozetbas = "ÖZET";
            string araozetson = "Anahtar kelimeler";
            var ozetbas = text.LastIndexOf(araozetbas, text.Length - 1);
            var ozetson = text.IndexOf(araozetson, 0, text.Length - 1);
            int uzunlukozet = ozetson - ozetbas;
            String ozetal;
            ozetal = text.Substring(ozetbas + araozetbas.Length, uzunlukozet - araozetbas.Length);
            // Console.WriteLine(ozet);
            //ders adi kismi
            String dersadi = File.ReadAllLines(dosyayolu)[61];
            // tarih Tezin Savunulduğu Tarih: ve ÖNSÖZ VE TEŞEKKÜR

            string aratarihbas = "Tezin Savunulduğu Tarih: ";
            string aratarihson = "ÖNSÖZ VE TEŞEKKÜR";

            var tarihbas = text.IndexOf(aratarihbas, 0, text.Length - 1);
            var tarihson = text.IndexOf(aratarihson, 0, text.Length - 1);
            int uzunluktarih = tarihson - tarihbas;
            String tarih;
            tarih = text.Substring(tarihbas + aratarihbas.Length, uzunluktarih - aratarihbas.Length);




            //anahtar kelimeler
            //anahtar kelimeler pozisyonu abstrac pozisyonu arasındalilerden anahtar kelime pozisyonu ve . pozisyonu
            string araanahtarbas = "Anahtar kelimeler: ";
            string araanahtarson = "ABSTRACT";// last index yapilacak

            var anahtarbas = text.IndexOf(araanahtarbas, 0, text.Length - 1);
            var anahtarson = text.LastIndexOf(araanahtarson, text.Length - 1);
            int uzunlukanahtar = anahtarson - anahtarbas;
            String anahtar;
            anahtar = text.Substring(anahtarbas + araanahtarbas.Length, uzunlukanahtar - araanahtarbas.Length);

            //cekilen stringten . ya kadar olan kısmı 
            string cekilen = anahtar;
            string araanahtarson2 = ".";
            var anahtarson2 = cekilen.IndexOf(araanahtarson2, 0, cekilen.Length);
            String anahtarkelimeler;
            anahtarkelimeler = cekilen.Substring(0, anahtarson2);


            //danışman adi 
            // ogrenci adından danışman kelimesine kadar olan kısmı al 
            //ogrenci adisoyadi

            string araadsoyadbas = "Adı Soyadı:";
            string araadsoyadson = "İmza:";
            var adsoyadbas = text.IndexOf(araadsoyadbas, 0, text.Length - 1);
            var adsoyadson = text.IndexOf(araadsoyadson, 0, text.Length - 1);
            int uzunlukdanisman = adsoyadson - adsoyadbas;
            String adsoyadd;
            adsoyadd = text.Substring(adsoyadbas + 12, uzunlukdanisman - 12);
            string buyukadsoyad = adsoyadd.ToUpper(); // tüm karakterleri büyük harf yapar 

            string aradanismanbas = buyukadsoyad;//last indec-x
            string aradanismanson = "Danışman";
            var danismanbas = text.LastIndexOf(aradanismanbas, text.Length - 1);
            var danismanson = text.IndexOf(aradanismanson, 0, text.Length - 1);

            int uzunlukdanisman2 = danismanson - danismanbas;
            String danismanadi;
            danismanadi = text.Substring(danismanbas + aradanismanbas.Length, uzunlukdanisman2 - aradanismanbas.Length);

            //juriler 
            //juri adlari 1. juri adi
            string juriler;
            string arajuri1bas = "Danışman, Kocaeli Üniv";
            string arajuri1son = "Jüri Üyesi";
            var juri1bas = text.IndexOf(arajuri1bas, 0, text.Length - 1);
            var juri1son = text.IndexOf(arajuri1son, 0, text.Length - 1);
            int uzunlukjuri1 = juri1son - juri1bas;
            String juri1;
            juri1 = text.Substring(juri1bas + arajuri1bas.Length, uzunlukjuri1 - arajuri1bas.Length);

            //2. juri
            string arajuri2bas = "Jüri Üyesi, Kocaeli Üniv.";
            string arajuri2son = "Jüri Üyesi";
            var juri2bas = text.IndexOf(arajuri2bas, 0, text.Length - 1);
            var juri2son = text.LastIndexOf(arajuri2son, text.Length - 1);
            int uzunlukjuri2 = juri2son - juri2bas;
            String juri2;
            juri2 = text.Substring(juri2bas + arajuri2bas.Length, uzunlukjuri2 - arajuri2bas.Length);
            juriler = juri1 + juri2;

            //dersadi
            String dersadi2 = File.ReadAllLines(dosyayolu)[61];
            //ogrenci adisoyadi
            string araadsoyadbas2 = "Adı Soyadı:";
            string araadsoyadson2 = "İmza:";
            var adsoyadbas2 = text.IndexOf(araadsoyadbas2, 0, text.Length - 1);
            var adsoyadson2 = text.IndexOf(araadsoyadson2, 0, text.Length - 1);
            int uzunlukbaslik = adsoyadson2 - adsoyadbas2;
            String adsoyad;
            adsoyad = text.Substring(adsoyadbas2 + 12, uzunlukbaslik - 12);
            string buyukadsoyad2 = adsoyad.ToUpper(); // tüm karakterleri büyük harf yapar   


            string arabaslikbas = dersadi;
            string arabaslikson = buyukadsoyad;
            var baslikbas = text.IndexOf(arabaslikbas, 0, text.Length - 1);
            var baslikson = text.LastIndexOf(arabaslikson, text.Length - 1);
            int uzunlukbaslik2 = baslikson - baslikbas;
            String baslik;
            baslik = text.Substring(baslikbas + arabaslikbas.Length, uzunlukbaslik2 - arabaslikbas.Length);

            /*
            string constr2 = WebConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con2 = new SqlConnection(constr2);
            SqlCommand cmd2 = new SqlCommand("select * from pdflertablosu ", con2);
            con2.Open();
            SqlDataReader reader2 = cmd2.ExecuteReader();
           
            if (reader2.HasRows)
            {
                while (reader2.Read() == true)
                {
                    dokuman = reader2.GetString(0);
                }
            }
            con2.Close(); 
            */
            var st3 = new bolumlertablosu
            {
                adisoyadi = adsoyad1,
                ograncino = no1,
                ozet = ozetal,
                dersadi = dersadi,
                tarih = tarih,
                anahtarkelimeler = anahtarkelimeler,
                danisman = danismanadi,
                juri = juriler,
                baslik = baslik,
                
             //   dokumanid=dokuman,

            };
            db.bolumlertablosu.InsertOnSubmit(st3);
            db.SubmitChanges();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            int rowIndex = ((GridViewRow)((sender as Control)).NamingContainer).RowIndex;
            string dosyakonumu = GridView1.Rows[rowIndex].Cells[3].Text;
            dosyaadi = GridView1.Rows[rowIndex].Cells[2].Text;
            //  System.Diagnostics.Process.Start("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" +dosyaadi+ ".txt");
            System.Diagnostics.Process.Start("C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/" + dosyakonumu);
            Response.Redirect("~/WebForm2.aspx");

        }


    }
}
