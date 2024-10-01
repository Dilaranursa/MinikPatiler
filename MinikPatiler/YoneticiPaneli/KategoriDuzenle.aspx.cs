using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler.YoneticiPaneli
{
    public partial class KategoriDuzenle : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    int id = Convert.ToInt32(Request.QueryString["kategoriId"]);
                    Kategori kat = vm.KategoriGetir(id);
                    if (kat != null)
                    {
                        tb_isim.Text = kat.Isim;
                        tb_aciklama.Text = kat.Aciklama;
                        cb_aktif.Checked = kat.Durum;
                    }
                    else
                    {
                        Response.Redirect("KategoriListele.aspx");
                    }
                }
            }
            else
            {
                Response.Redirect("KategoriListele.aspx");
            }

        }

        protected void lbtn_duzenle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text))
            {
                int id = Convert.ToInt32(Request.QueryString["kategoriId"]);
                Kategori ka = vm.KategoriGetir(id);
                ka.Isim = tb_isim.Text;
                ka.Aciklama = tb_aciklama.Text;
                ka.Durum = cb_aktif.Checked;
                if (vm.KategoriGuncelle(ka))
                {
                    pnl_basarili.Visible = true;
                    pnl_basarisiz.Visible = false;
                }
                else
                {
                    pnl_basarili.Visible = false;
                    pnl_basarisiz.Visible = true;
                    lbl_mesaj.Text = "Kategori düzenleme başarısız.";
                }
            }
            else
            {
                pnl_basarili.Visible = false;
                pnl_basarisiz.Visible = true;
                lbl_mesaj.Text = "Kategori adı boş bırakılamaz";
            }
        }
    }
}