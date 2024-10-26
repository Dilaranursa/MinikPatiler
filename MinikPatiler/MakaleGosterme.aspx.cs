﻿using System;
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
                img_resim.ImageUrl = "Resimler/MakaleResimleri/" + m.KapakResim;
            }

        }

        protected void buton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Yorumlary.aspx");
        }
    }
}


    
