using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yazlab3
{
 
    public partial class WebForm6 : System.Web.UI.Page
    {   
        string pdf;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            pdf = WebForm4.dosyaadi;
            //Label1.Text = pdf;
            // pdf adına göre dosyayı çağır islemleri yap 
            string dosyayolu = @"C:/Users/Asus/OneDrive/Masaüstü/Yazlab3/Yazlab3/Text File/" + pdf + ".txt";
            string text = System.IO.File.ReadAllText(dosyayolu);

            //adsoyad kısmı
            string araadsoyadbas1 = "Adı Soyadı: ";
            var adsoyadbas1 = text.IndexOf(araadsoyadbas1, 0, text.Length - 1);
            string araadsoyadson1 = "İmza:";
            var adsoyadson1 = text.IndexOf(araadsoyadson1, 0, text.Length - 1);
            int uzunlukadsoyad = adsoyadson1 - adsoyadbas1;
            String adsoyad1;
            adsoyad1 = text.Substring(adsoyadbas1 + araadsoyadbas1.Length, uzunlukadsoyad - araadsoyadbas1.Length);
            adisoyadilabel.Text = adsoyad1;

            //numarakısmı
            string aranobas = "Öğrenci No: ";
            var nobas = text.IndexOf(aranobas, 0, text.Length - 1);
            string aranoson = "Adı Soyadı: ";
            var noson = text.IndexOf(aranoson, 0, text.Length - 1);
            int uzunlukno = noson - nobas;
            String no1;
            no1 = text.Substring(nobas + aranobas.Length, uzunlukno - aranobas.Length);
            ogrencinolabel.Text = no1;

            //ozet kısmını cekti
            string araozetbas = "ÖZET";
            string araozetson = "Anahtar kelimeler";
            var ozetbas = text.LastIndexOf(araozetbas, text.Length - 1);
            var ozetson = text.IndexOf(araozetson, 0, text.Length - 1);
            int uzunlukozet = ozetson - ozetbas;
            String ozetal;
            ozetal = text.Substring(ozetbas + araozetbas.Length, uzunlukozet - araozetbas.Length);
            ozetlabel.Text = ozetal;

            //ders adi kismi
            String dersadi = File.ReadAllLines(dosyayolu)[61];
            dersadilabel.Text = dersadi;

            //tarih kismi
            string aratarihbas = "Tezin Savunulduğu Tarih: ";
            string aratarihson = "ÖNSÖZ VE TEŞEKKÜR";

            var tarihbas = text.IndexOf(aratarihbas, 0, text.Length - 1);
            var tarihson = text.IndexOf(aratarihson, 0, text.Length - 1);
            int uzunluktarih = tarihson - tarihbas;
            String tarih;
            tarih = text.Substring(tarihbas + aratarihbas.Length, uzunluktarih - aratarihbas.Length);
            tarihlabel.Text = tarih;



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
            anahtarkelimelerlabel.Text = anahtarkelimeler;

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
            danismanlabel.Text = danismanadi;

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
            jurilabel.Text = juriler;

            // baslik ders adi ve isim arasinda

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
            basliklabel.Text = baslik;
        }

    }
}