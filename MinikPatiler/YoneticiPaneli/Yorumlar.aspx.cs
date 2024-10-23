using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class Yorumlar : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_yorumlar.DataSource = vm.TumYorumlariGetir();
            lv_yorumlar.DataBind();
        }

        protected void lv_yorumlar_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "sil")
            {
                vm.YorumSil(id);
            }
            if (e.CommandName == "durum")
            {
                vm.YorumDurumDegistir(id);
            }

            lv_yorumlar.DataSource = vm.TumYorumlariGetir();
            lv_yorumlar.DataBind();
        }
    }
}