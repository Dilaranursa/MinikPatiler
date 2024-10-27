using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler
{
    public partial class MakaleGosterme : System.Web.UI.Page
    {
        VeriModeli vm =new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) // Sayfa ilk kez yükleniyorsa
    {
                if (Request.QueryString.Count == 0)
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    int id = Convert.ToInt32(Request.QueryString["makale"]);
                    vm.MakaleGoruntulemeArttir(id);
                    Makale m = vm.MakaleGetir(id);

                    // Makale detaylarını göster
                    ltrl_baslik.Text = m.Baslik;
                    ltrl_icerik.Text = m.Icerik;
                    ltrl_kategori.Text = m.Kategori;
                    ltrl_yayinlama.Text = m.EklemeTarihi.ToString("dd.MM.yyyy");
                    ltrl_yazar.Text = m.Yazar;
                    ltrl_goruntuleme.Text = m.GoruntulemeSayisi.ToString();
                    img_resim.ImageUrl = "Resimlerr/MakaleResimleri/" + m.KapakResim;

                    // Yorumları göster
                    YorumlariGoster(id);
                }
            }

        }
        private void YorumlariGoster(int makaleID)
        {
            List<Yorum> yorumlar = vm.YorumlariGetir(makaleID);

            // Yorumları kontrol et ve Repeater'a bağla
            if (yorumlar != null && yorumlar.Count > 0)
            {
                rpt_yorumlar.DataSource = yorumlar;
                rpt_yorumlar.DataBind();
            }
            else
            {
                lbl_bilgiMesaji.Text = "Bu makaleye henüz yorum yapılmamıştır.";
                lbl_bilgiMesaji.Visible = true; // Bilgi mesajını görünür yap
            }
        }
             
        protected void lbtn_yorumGonder_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["makale"]);
            Uyeler u = (Uyeler)Session["GirisUye"];

            if (u != null)
            {
                Yorum y = new Yorum();
                y.MakaleID = id;
                y.UyeID = u.UyeID;
                y.Icerik = tb_yorumIcerik.Text;
                if (vm.YorumEkle(y))
                {
                    pnl_bilgi.Visible = true;
                    lbl_bilgiMesaji.Visible = true;
                    lbl_bilgiMesaji.Text = "Yorum başarıyla eklenmiştir.";
                    Response.Redirect(Request.RawUrl);
                }
                else
                {
                    pnl_bilgi.Visible = true;
                    lbl_bilgiMesaji.Visible = true;
                    lbl_bilgiMesaji.Text = "Yorum eklenirken bir hata oluştu.";
                }
                YorumlariGoster(id);
            }
            else
            {
                pnl_bilgi.Visible = true;
                lbl_bilgiMesaji.Visible = true;
                lbl_bilgiMesaji.Text = "Yorum eklemek için lütfen giriş yapın.";
            }
        }
    }
}


    
