<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UyeKayitol.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.UyeGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Üye Kayıt Sayfası</title>
    <link href="Css/UyeKayitSitil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="genelkapayici">
            <div class="logo">
                <img src="Resimler/logo.png" class="t_dog" />
            </div>
            <div class="formkaplayici">
                <h2>Kayıt Ol</h2>
                <asp:Panel ID="pnl_basarili" runat="server" CssClass="panelBasarili" Visible="false">
                    <asp:Label ID="lbl_mesaj" runat="server">Kayıt Işlemi Başarılı</asp:Label>
                </asp:Panel>
                <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="panelBasarisiz" Visible="false">
                    <asp:Label ID="Label1" runat="server">Kayıt Işlemi Başarısız</asp:Label>
                </asp:Panel>
                <div class="Verikapsayici">
                    <label>Isim</label>
                    <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu" placeholder="Isminizi Yazınız"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <label>Soyisim</label>
                    <asp:TextBox ID="tb_soyisim" runat="server" CssClass="metinKutu" placeholder="Soyadınızı Yazınız"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <label>Kullanıcı Adı</label>
                    <asp:TextBox ID="tb_kullaniciadi" runat="server" CssClass="metinKutu" placeholder="Kullanıcı Adı Giriniz"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <label>Mail</label>
                    <asp:TextBox ID="tb_eposta" runat="server" CssClass="metinKutu" placeholder="minik@pati.com"></asp:TextBox>
                </div>

                <div class="Verikapsayici">
                    <label>Şifre</label>
                    <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="666?***" TextMode="Password"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <asp:Button ID="btn_girisYap" runat="server" OnClick="btn_girisYap_Click2" Text="Kayıt Ol" CssClass="kayitbutton" />
                </div>
                <div class="Verikapsayici">
                    <h2>Zaten Hesabın Var Mı?</h2>
                    <asp:Button ID="btn_hesabımvar" runat="server" OnClick="btn_hesabımvar_Click" Text="Giriş Yap" CssClass="girisbutton" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
