using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class KategoriListe : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_Kategoriler.DataSource = vm.KategoriListeleme(false);
            lv_Kategoriler.DataBind();
        }

        protected void lv_Kategoriler_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "sil")
            {
                vm.KategoriSil(id);
            }
            if (e.CommandName == "durum")
            {
                vm.KategoriDurumDegistir(id);
            }

            lv_Kategoriler.DataSource = vm.KategoriListeleme(false);
            lv_Kategoriler.DataBind();
        }

    }
}
