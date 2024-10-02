using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class Kullanicilar : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_Kullanicilar.DataSource = vm.KullaniciListe();
            lv_Kullanicilar.DataBind();

        }
               
        protected void lv_Kullanıcılar_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "sil")
            {
                vm.KullaniciSilHardDelete(id); 
            }
                      
        }
    }
}