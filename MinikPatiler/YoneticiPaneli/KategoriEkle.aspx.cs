using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class KategoriEkle : System.Web.UI.Page
    {
        VeriModeli vm =new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ltbn_ekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_isim.Text))
            {
                lbl_mesaj.Text = "Kategori adı boş bırakılamaz";
                pnl_basarili.Visible = false;
                pnl_basarisizpanel.Visible = true;
                return;
            }

            if (tb_isim.Text.Length > 50)
            {
                lbl_mesaj.Text = "Kategori adı 50 karakteri geçemez";
                pnl_basarili.Visible = false;
                pnl_basarisizpanel.Visible = true;
                return;
            }

            Kategori ka = new Kategori
            {
                Isim = tb_isim.Text,
                Aciklama = tb_aciklama.Text,
                Silinmis = false,
                Durum = cb_aktif.Checked
            };

            if (vm.KategoriEkle(ka))
            {
                pnl_basarili.Visible = true;
                pnl_basarisizpanel.Visible = false;

                tb_isim.Text = string.Empty;
                tb_aciklama.Text = string.Empty;
                cb_aktif.Checked = false;
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_basarisizpanel.Visible = true;
                lbl_mesaj.Text = "Kategori Eklerken bir hata oluştu";
            }
        }
    }
}