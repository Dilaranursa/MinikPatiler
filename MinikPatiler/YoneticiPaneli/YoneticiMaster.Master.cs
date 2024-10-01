﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class YoneticiMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["GirisYapanYonetici"] != null)
            {
                Yonetici y = (Yonetici)Session["GirisYapanYonetici"];
                lbl_kullanici.Text = y.KullaniciAdi + " (" + y.YoneticiTur + ")";
            }
            else
            {
                Response.Redirect("Giris.aspx");
            }
        }

       
    }
}