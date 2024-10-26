using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler
{
    public partial class Yorumlary : System.Web.UI.Page
    {
        VeriModeli vm =new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["GirisUye"] != null)
            //{
            //    Uyeler uye = (Uyeler)Session["GirisUye"];
            //    int makaleID = 1000; // Dinamik olarak ayarlayın (örneğin, URL'den alınabilir)
            //    Yorum yeniYorum = new Yorum
            //    {
            //        MakaleID = makaleID,
            //        UyeID = uye.UyeID,
            //        Icerik = tb_yorum.Text,
            //        EklemeTarihi = DateTime.Now,
            //        Durum = true,

            //    };

            //    bool eklemeBasarili = vm.YorumEkle(yeniYorum);
            //    if (eklemeBasarili)
            //    {
            //        Response.Redirect(Request.RawUrl); // Sayfayı yenileyin
            //    }
            //    else
            //    {
            //        pnl_basarisiz.Visible = true;
            //        lbl_hatamesaj.Text = "Yorum eklenirken bir hata oluştu. Lütfen tekrar deneyin.";
            //    }
            //}
            //else
            //{
            //    pnl_basarisiz.Visible = true;
            //    lbl_hatamesaj.Text = "Yorum yapabilmek için giriş yapmalısınız.";
            //}

        }
    }
}