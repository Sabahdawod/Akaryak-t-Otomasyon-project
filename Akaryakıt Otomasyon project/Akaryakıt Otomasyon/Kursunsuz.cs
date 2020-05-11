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
    // make an inheritance
    class Kursunsuz : Benzin
    {
        // special properties
        //private string degisken1;
        //private string degisken2;
        //private string degisken3;
        //private string degisken4;
        //private int degisken5;

        // initialization constructor
        public Kursunsuz(string ad, string marka, string model, string ozellik, int hamFiyat, int secilenadet)

            : base(ad, marka, model, ozellik, hamFiyat, secilenadet)
        {

            
        }


    }
}
