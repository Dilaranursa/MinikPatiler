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
        VeriModeli vm =new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_girisYapın_Click1(object sender, EventArgs e)
        {
            Uyeler u = new Uyeler();

            if (!string.IsNullOrEmpty(tb_mail.Text))
            {
                if (!string.IsNullOrEmpty(tb_sifre.Text))
                {
                    u = vm.UyeGiris(tb_mail.Text, tb_sifre.Text);
                    if (u != null)
                    {
                        Session["GirisUye"] = u;
                        Response.Redirect("UyeGiris.aspx");
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

            Response.Redirect("~/Default.aspx");
        }

        protected void uye_Click(object sender, EventArgs e)
        {
            Response.Redirect("UyeKayitol.aspx");
        }
    }
}