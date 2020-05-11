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
using System.Windows.Forms;

namespace Akaryakıt_Otomasyon
{
    class Fatura
    {

        // function to add items to listboxes
        public static void SepeteUrunEkle(Benzin Benzin, ListBox listBox1, ListBox listBox2, ListBox listBox3)
        {
            // add product items to listbox if choosen products > 0
            if (Benzin.Get_secilenadet() > 0)
            {
                listBox1.Items.Add(Benzin.Get_secilenadet());
                listBox2.Items.Add(Benzin.Get_Name());
                listBox3.Items.Add(Math.Round(Benzin.KdvUygula(Benzin.Get_Name()), 2));
            }
        }

        public static void SepeteTemizle(ListBox l1, ListBox l2, ListBox l3)
        {

            // clear listboxes
            l1.Items.Clear();
            l2.Items.Clear();
            l3.Items.Clear();

        }
    }
}
