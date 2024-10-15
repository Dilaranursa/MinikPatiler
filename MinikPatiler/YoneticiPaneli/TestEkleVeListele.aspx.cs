using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class TestEkleVeListele : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //pnl_listele.Visible = false;
                //pnl_testolusturr.Visible = false;
            }
        }

        protected void lbtn_ekle_Click(object sender, EventArgs e)
        {
            string soru = tb_soru.Text;
            string acevabi = tb_acevabi.Text;
            string bcevabi = tb_bcevabi.Text;
            string cevabi = tb_cevabi.Text;
            string devabi = tb_devabi.Text;

            // Soru ekleme işlemi
            Soru s = new Soru();
            s.SoruMetni = soru;
            s.A = acevabi;
            s.B = bcevabi;
            s.C = cevabi;
            s.D = devabi;
            vm.SoruEkle(s);



        }
    }
}
