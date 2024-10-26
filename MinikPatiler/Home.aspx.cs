using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MinikPatiler
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl_HayvanAdi.Text = "Minik";
                lbl_Cinsiyet.Text = "Dişi";
                lbl_Kilo.Text = "4 kg";
                lbl_Yas.Text = "2 yaşında";
                lbl_Hastalik.Text = "Yok";

                lbl_HayvanAdi2.Text = "Karakız";
                lbl_Cinsiyet2.Text = "Dişi";
                lbl_Kilo2.Text = "3 kg";
                lbl_Yas2.Text = "1 yaşında";
                lbl_Hastalik2.Text = "Alerjik";
            }
        }

       
    }
}