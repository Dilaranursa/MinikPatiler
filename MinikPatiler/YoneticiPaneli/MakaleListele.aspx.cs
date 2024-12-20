﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class MakaleListele : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_Makaleler.DataSource = vm.MakaleListele();
            lv_Makaleler.DataBind();
        }

        protected void lv_Makaleler_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int makid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "sil")
            {
                vm.MakaleSil(makid);
            }
            lv_Makaleler.DataSource = vm.MakaleListele();
            lv_Makaleler.DataBind();
        }
    }
}