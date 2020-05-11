/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............:Sabah Dawod
** ÖĞRENCİ NUMARASI.......:b191200554
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakıt_Otomasyon
{
    abstract class Benzin
    {
        // properties
        protected string Ad;
        protected string country;
        protected string Model;
        protected string Ozellik;
        protected int LitreAdedi;
        protected int HamFiyat, SecilenAdet;

        // initialization constructor
        public Benzin(string ad, string country, string model, string ozellik, int hamFiyat, int secilenadet)
        {
            this.Ad = ad;
            this.country = country;
            this.Model = model;
            this.Ozellik = ozellik;
            this.LitreAdedi = 0;
            this.HamFiyat = hamFiyat;
            this.SecilenAdet = secilenadet;
        }
        // set choosen number
        public void Set_secilenadet(int secilenAdet)
        {
            this.SecilenAdet = secilenAdet;
        }
        // get choosen number
        public int Get_secilenadet()
        {
            return this.SecilenAdet;
        }
        // get name
        public string Get_Name()
        {
            return this.Ad;
        }
        // get raw price
        public int Get_Ham_Fiyat()
        {
            return this.HamFiyat;
        }

        // set stokadedi
        public void Set_LitreAdedi(int new_Litre)
        {
            this.LitreAdedi = new_Litre;
        }
        // get stokadedi
        public int Get_LitreAdedi()
        {
            return this.LitreAdedi;
        }

        // // kdvuygula function for every project
        public double KdvUygula(string Urun_Adi)
        {
            if (Urun_Adi == "V Power")
            {
                return this.HamFiyat * 1.18 * this.SecilenAdet;
            }
            else if (Urun_Adi == "AutoGas")
            {
                return this.HamFiyat * 1.18 * this.SecilenAdet;
            }
            else if (Urun_Adi == "95 oktan kurşunsuz")
            {
                return this.HamFiyat * 1.18 * this.SecilenAdet;
            }
            else if (Urun_Adi == "Diesel")
            {
                return this.HamFiyat * 1.18 * this.SecilenAdet;
            }
            else
            {
                return 0;
            }
        }


    }
}
