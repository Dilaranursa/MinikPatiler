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
        VeriModeli vm= new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl_listele.Visible = false;
                pnl_testolusturr.Visible = false;
            }
        }

        protected void btn_testOluştur_Click(object sender, EventArgs e)
        {
            pnl_testolusturr.Visible = true;
            pnl_listele.Visible = false;
        }

        protected void btn_testListele_Click(object sender, EventArgs e)
        {
           
        }

        protected void btn_yenisoru_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnl_listele.Visible = false;
                pnl_testolusturr.Visible = false;
            }
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            //string testBaslik = tb_testBaslik.Text;
            //bool result = vm.SoruEkle(testBaslik); 

            //lbl_basarili.Text = result ? "Test başarıyla kaydedildi!" : "Test kaydetme sırasında hata oluştu.";
            //lbl_basarili.Visible = true;

            //// Test listeyi güncelle
            //LoadTestler();
        }

        protected void btn_duzenle_Click(object sender, EventArgs e)
        {

        }

        protected void btn_sil_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadTestler()
        {
            // Testleri yüklemek için veri modelinden testleri çekin
            //List<Test> testler = vm.TumTestleriGetir(); // TumTestleriGetir metodunu tanımlamalısınız
            //rpt_test.DataSource = testler;
            //rpt_test.DataBind();
        }
    }
}
