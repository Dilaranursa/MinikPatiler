using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;



namespace MinikPatiler.YoneticiPaneli
{
    public partial class GirisPaneli : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_girisYap_Click(object sender, EventArgs e)
        {
            Yonetici y = new Yonetici();

            if (!string.IsNullOrEmpty(tb_eposta.Text))
            {
                if (!string.IsNullOrEmpty(tb_sifre.Text))
                {
                    y = vm.YoneticiGiris(tb_eposta.Text, tb_sifre.Text);
                    if (y != null)
                    {
                        Session["GirisYapanYonetici"] = y;
                        Response.Redirect("YoneticiDefault.aspx");
                    }
                    else
                    {
                        pnl_basarisiz.Visible = true;
                        lbl_mesaj.Text = "Kullanıcı Bulunamadı";
                    }
                }
                else
                {
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Şifre adresi boş bırakılamaz";
                }
            }
            else
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Eposta adresi boş bırakılamaz";
            }
        }

      

        protected void uye_Click1(object sender, EventArgs e)
        {
            Response.Redirect("UyeKayitol.aspx");
        }
    }
}