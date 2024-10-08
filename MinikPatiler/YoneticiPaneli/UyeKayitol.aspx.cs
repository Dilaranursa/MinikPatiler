﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class UyeGiris : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_hesabımvar_Click(object sender, EventArgs e)
        {

        }

        protected void btn_girisYap_Click2(object sender, EventArgs e)
        {
            // Başarısızlık panelini gizle
            pnl_basarisiz.Visible = false;

            Uyeler u = new Uyeler();

            // İsim kontrolü
            if (string.IsNullOrEmpty(tb_isim.Text))
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "İsim boş bırakılamaz.";
                return;
            }
            else
            {
                lbl_mesaj.Text = ""; // Önceki mesajı temizle
            }

            // Soyisim kontrolü
            if (string.IsNullOrEmpty(tb_soyisim.Text))
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Soyisim boş bırakılamaz.";
                return;
            }
            else
            {
                lbl_mesaj.Text = ""; // Önceki mesajı temizle
            }

            // E-posta kontrolü
            if (string.IsNullOrEmpty(tb_eposta.Text))
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "E-posta adresi boş bırakılamaz.";
                return;
            }
            else
            {
                lbl_mesaj.Text = ""; // Önceki mesajı temizle
            }

            // Kullanıcı adı kontrolü
            if (string.IsNullOrEmpty(tb_kullaniciadi.Text))
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Kullanıcı adı boş bırakılamaz.";
                return;
            }
            else
            {
                lbl_mesaj.Text = ""; // Önceki mesajı temizle
            }

            // Şifre kontrolü
            if (string.IsNullOrEmpty(tb_sifre.Text))
            {
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Şifre boş bırakılamaz.";
                return;
            }
            else
            {
                lbl_mesaj.Text = ""; // Önceki mesajı temizle
            }

            Uyeler uyeler = new Uyeler();
            uyeler.Isim = tb_isim.Text;
            uyeler.Soyisim=tb_soyisim.Text;
            uyeler.KullaniciAdi = tb_kullaniciadi.Text;
            uyeler.Eposta=tb_eposta.Text;   
            uyeler.Sifre=tb_sifre.Text;

            if (vm.UyeKayit(uyeler))
            {
                pnl_basarili.Visible = true;
                lbl_mesaj.Text = "Kayıt işlemi başarılı.";
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Kayıt işlemi başarızı.";

            }
        }

            // Kayıt başarılı mı?
            //if (u != null)
            //{
            //    Session["GirisYapanUyeler"] = u;
            //    Response.Redirect("UyeGiris.aspx");
            //}
         
        
    }
}