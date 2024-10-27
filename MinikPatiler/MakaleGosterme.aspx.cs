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
            if (Request.QueryString.Count == 0)
            {
                Response.Redirect("Default.aspx");
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["makale"]);
                vm.MakaleGoruntulemeArttir(id);
                Makale m = vm.MakaleGetir(id);
                ltrl_baslik.Text = m.Baslik;
                ltrl_icerik.Text = m.Icerik;
                ltrl_kategori.Text = m.Kategori;
                ltrl_yayinlama.Text = Convert.ToString(m.EklemeTarihi);
                ltrl_yazar.Text = m.Yazar;
                ltrl_goruntuleme.Text = Convert.ToString(m.GoruntulemeSayisi);
                img_resim.ImageUrl = "Resimlerr/MakaleResimleri/" + m.KapakResim;
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
                }
                else
                {
                    pnl_bilgi.Visible = true;
                    lbl_bilgiMesaji.Visible = true;
                    lbl_bilgiMesaji.Text = "Yorum eklenirken bir hata oluştu.";
                }
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


    
