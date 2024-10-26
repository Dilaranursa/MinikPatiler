using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VeriErisimKatmani;

namespace MinikPatiler
{
    public partial class Default : System.Web.UI.Page
    {
        VeriModeli vm = new VeriModeli();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack) // Sayfa yenilenmediyse
            {
                if (Request.QueryString.Count == 0)
                {
                    lv_makaleler1.DataSource = vm.MakaleListele();
                    lv_makaleler1.DataBind();
                }
                else
                {
                    int makaleID = Convert.ToInt32(Request.QueryString["makale"]);
                    // Görüntüleme sayısını artır
                    vm.MakaleGoruntulemeArttir(makaleID);
                    // Makaleyi getir
                    lv_makaleler1.DataSource = vm.MakaleListele(makaleID);
                    lv_makaleler1.DataBind();
                }
            }
        }
      
    }
}