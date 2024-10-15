using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public class Test
    {

        public int ID { get; set; }
        public int YoneticiID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklemeTarihi { get; set; }
        public bool Durum { get; set; }
        public bool Silinmis { get; set; }
        public string Cevap { get; set; }
    }
}

