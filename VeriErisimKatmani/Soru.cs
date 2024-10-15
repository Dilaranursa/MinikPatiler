using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriErisimKatmani
{
    public  class Soru
    {
        public int ID { get; set; }
        public int TestID { get; set; }
        public string SoruMetni { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
    }
}
