﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Yonetici
    {
        public int ID { get; set; }
        public int YoneticiTurID { get; set; }
        public string YoneticiTur { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string KullaniciAdi { get; set; }
        public string Eposta { get; set; }
        public string Sifre { get; set; }
        public bool Durum { get; set; }
        public bool Silinmis { get; set; }
    }
}