
/****************************************************************************
**					MUGLA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 3
**				ÖĞRENCİ ADI............: Cagatay
**                         DERSİN ALINDIĞI GRUP...: 
****************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Akaryakıt_Otomasyon
{


    public partial class Form1 : Form
    {
        // Pic



        // declaration UpDown values
        int ud1;
        int ud2;
        int ud3;
        int ud4;

        // initialization objects in public area
        Benzin VPower = new V_power("V Power", "Russa", "yarışma", "Yeni V-Power FuelSave 250’den fazla araç ve 3 milyon kilometreden fazla mesafede yapılan kapsamlı testlerin sonucunda geliştirilen, bugüne kadarki en gelişmiş yakıtlarımızdır.", 7, 0);
        Benzin AGaz = new AutoGas("AutoGas", "Katar", "normal", "Her dolumda aynı yüksek kaliteyi sunan, güvenli ve ekonomik Autogas ile paranızın karşılığını alırsınız.", 3, 0);
        Benzin kursunsuz = new Kursunsuz("95 oktan kurşunsuz", "Arabistan", "yarışma", "Super ve cok guclu", 6, 0);
        Benzin diesel = new Diesel("Diesel", "Russa", "normal", "En iyi temizleme performansımız için DYNAFLEX teknolojisiyle güçlendirilen yeni dizel formülümüz, motorunuzun performansının %100’e kadar geri kazanılmasına yardımcı olur.", 5, 0);
        public Form1()
        {

            // initialization setting

            InitializeComponent();
            // make a Random object
            Random RastgeleSayi = new Random();

            // set window size
            Width = 850;
            Height = 650;

            // variables to store UpDownMax

            ud1 = RastgeleSayi.Next(100, 1000);
            ud2 = RastgeleSayi.Next(100, 1000);
            ud3 = RastgeleSayi.Next(100, 1000);
            ud4 = RastgeleSayi.Next(100, 1000);

            // set label text with random numbers
            this.l1.Text = Convert.ToString(ud1);
            this.l2.Text = Convert.ToString(ud2);
            this.l3.Text = Convert.ToString(ud3);
            this.l4.Text = Convert.ToString(ud4);




            // set numaricupdown Maximum and make sure the numaric updown number should not be bigger than stok adedi
            n1.Maximum = ud1;
            n2.Maximum = ud2;
            n3.Maximum = ud3;
            n4.Maximum = ud4;


            // set numaricupdown Minimum 
            n1.Minimum = 0;
            n2.Minimum = 0;
            n3.Minimum = 0;
            n4.Minimum = 0;

            // set stok numbers
            VPower.Set_LitreAdedi(ud1);
            AGaz.Set_LitreAdedi(ud2);
            kursunsuz.Set_LitreAdedi(ud3);
            diesel.Set_LitreAdedi(ud4);

            // set products price
            l5.Text = "Ham Fiyat: " + Convert.ToString(VPower.Get_Ham_Fiyat());
            l6.Text = "Ham Fiyat: " + Convert.ToString(diesel.Get_Ham_Fiyat());
            l7.Text = "Ham Fiyat: " + Convert.ToString(AGaz.Get_Ham_Fiyat());
            l8.Text = "Ham Fiyat: " + Convert.ToString(kursunsuz.Get_Ham_Fiyat());


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // clear buttons in every click
            Fatura.SepeteTemizle(listBox1, listBox2, listBox3);


            // set choosen products
            VPower.Set_secilenadet(Convert.ToInt32(n1.Value));
            AGaz.Set_secilenadet(Convert.ToInt32(n2.Value));
            kursunsuz.Set_secilenadet(Convert.ToInt32(n3.Value));
            diesel.Set_secilenadet(Convert.ToInt32(n4.Value));



            // add info to listboxes
            Fatura.SepeteUrunEkle(VPower, listBox1, listBox2, listBox3);
            Fatura.SepeteUrunEkle(diesel, listBox1, listBox2, listBox3);
            Fatura.SepeteUrunEkle(AGaz, listBox1, listBox2, listBox3);
            Fatura.SepeteUrunEkle(kursunsuz, listBox1, listBox2, listBox3);


            // set new stokadedi
            VPower.Set_LitreAdedi(Convert.ToInt32(VPower.Get_LitreAdedi()) - VPower.Get_secilenadet());
            AGaz.Set_LitreAdedi(Convert.ToInt32(AGaz.Get_LitreAdedi()) - AGaz.Get_secilenadet());
            kursunsuz.Set_LitreAdedi(Convert.ToInt32(kursunsuz.Get_LitreAdedi()) - kursunsuz.Get_secilenadet());
            diesel.Set_LitreAdedi(Convert.ToInt32(diesel.Get_LitreAdedi()) - diesel.Get_secilenadet());

            // set new stokadedi
            l1.Text = Convert.ToString(VPower.Get_LitreAdedi());
            l2.Text = Convert.ToString(AGaz.Get_LitreAdedi());
            l3.Text = Convert.ToString(kursunsuz.Get_LitreAdedi());
            l4.Text = Convert.ToString(diesel.Get_LitreAdedi());


            // set numaricupdown Maximum and make sure the numaric updown number should not be bigger than stok adedi
            n1.Maximum = VPower.Get_LitreAdedi();
            n2.Maximum = AGaz.Get_LitreAdedi();
            n3.Maximum = kursunsuz.Get_LitreAdedi();
            n4.Maximum = diesel.Get_LitreAdedi();

            // calculate the total price
            double result = Math.Round((kursunsuz.KdvUygula(kursunsuz.Get_Name())) + (AGaz.KdvUygula(AGaz.Get_Name())) +
              (diesel.KdvUygula(diesel.Get_Name())) + (VPower.KdvUygula(VPower.Get_Name())), 2);

            if (result == 0)
            {
                l9.Text = result + "0 TL";
            }
            else
            {
                l9.Text = result + " TL";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // clear listboxes
            Fatura.SepeteTemizle(listBox1, listBox2, listBox3);




            // reset stokadedi
            l1.Text = Convert.ToString(ud1);
            l2.Text = Convert.ToString(ud2);
            l3.Text = Convert.ToString(ud3);
            l4.Text = Convert.ToString(ud4);


            // reset StokAdedi in objects
            VPower.Set_LitreAdedi(ud1);
            AGaz.Set_LitreAdedi(ud2);
            kursunsuz.Set_LitreAdedi(ud3);
            diesel.Set_LitreAdedi(ud4);


            // reset choosen products
            VPower.Set_secilenadet(0);
            AGaz.Set_secilenadet(0);
            kursunsuz.Set_secilenadet(0);
            diesel.Set_secilenadet(0);

            // reset max numaricupdown Maximum and make sure the numaric updown number should not be bigger than stok adedi
            n1.Maximum = ud1;
            n2.Maximum = ud2;
            n3.Maximum = ud3;
            n4.Maximum = ud4;

            // reset numaricupdown = 0
            n1.Value = 0;
            n2.Value = 0;
            n3.Value = 0;
            n4.Value = 0;

            // set total amount = 00 TL
            l9.Text = "00 TL";
        }
    }
}
