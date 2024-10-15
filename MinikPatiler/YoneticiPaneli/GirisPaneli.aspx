<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisPaneli.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.GirisPaneli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Yonetici Giriş Sayfası</title>
    <link href="Css/GirisSitil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="genelkapsayicisol">
            <div class="logo">
                <img src="Resimler/logo.png" class="t_dog" />
            </div>
            <div class="formkaplayici">
                <h2>Yonetici Girişi</h2>
                <div>
                    <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="panelBasarisiz" Visible="false">
                        <asp:Label ID="lbl_mesaj" runat="server">Kullanıcı Bulunamadı</asp:Label>
                    </asp:Panel>
                </div>
                <div class="Verikapsayici">
                    <label>Eposta</label>
                    <asp:TextBox ID="tb_eposta" runat="server" CssClass="metinKutu" placeholder="minik@pati.com"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <label>Şifre</label><br />
                    <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="666?***" TextMode="Password"></asp:TextBox>
                </div>
                <div class="Verikapsayici">
                    <asp:Button ID="btn_girisYap" runat="server" OnClick="btn_girisYap_Click" Text="Yönetici Giriş" CssClass="girisbutton" />
                    <p><a href="#" class="unuttum">Şifremi Unuttum?</a></p>
                </div>
            </div>
            <div class="genelkapsayicisag">
                <div class="verisag">
                    <p>
                        "Yeni misiniz? Sadece birkaç dakikanızı alacak kayıt formumuzu
                        doldurun ve ayrıcalıklı dünyamıza katılın!
                    </p>
                   <div class="uye"> 
                       <asp:Button ID="uye" runat="server" OnClick="uye_Click1" Text="Kayıt Ol" CssClass="kayitbutton" />
                   </div>
                </div>
           </div>
        </div>
    </form>
</body>
</html>
