using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler
{
    public partial class UyeGiris : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_girisYapın_Click1(object sender, EventArgs e)
        {
            {
                Uyeler u = new Uyeler();

                if (string.IsNullOrEmpty(tb_mail.Text))
                {
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Eposta adresi boş bırakılamaz";
                    return; // Hata durumunda buradan çık
                }

                if (string.IsNullOrEmpty(tb_sifre.Text))
                {
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Şifre adresi boş bırakılamaz";
                    return; // Hata durumunda buradan çık
                }

                // Eposta ve şifre boş değilse giriş kontrolü yapılır
                u = vm.UyeGiris(tb_mail.Text, tb_sifre.Text);
                if (u != null)
                {
                    Session["GirisUye"] = u;
                    Response.Redirect("~/Default.aspx"); // Başarılı giriş sonrası yönlendirme
                }
                else
                {
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Kullanıcı Bulunamadı";
                }
            }


           
        }
        protected void uye_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/YoneticiPaneli/UyeKayitol.aspx");
        }
    }   }  