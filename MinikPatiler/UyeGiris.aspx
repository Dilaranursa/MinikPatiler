<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="UyeGiris.aspx.cs" Inherits="MinikPatiler.UyeGiris" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/uyegirissitil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="genelkapsayicisol">
    <div class="formkaplayici">
        <h2>Üye Girişi</h2>
        <div>
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="panelBasarisiz" Visible="false">
                <asp:Label ID="lbl_mesaj" runat="server">Kullanıcı Bulunamadı</asp:Label>
            </asp:Panel>
        </div>
        <div class="Verikapsayici">
            <label>Eposta</label>
            <asp:TextBox ID="tb_mail" runat="server" CssClass="metinKutu" placeholder="minik@pati.com"></asp:TextBox>
        </div>
        <div class="Verikapsayici">
            <label>Şifre</label>
            <asp:TextBox ID="tb_sifre" runat="server" CssClass="metinKutu" placeholder="666?***" TextMode="Password"></asp:TextBox>
        </div>
        <div class="Verikapsayici">
            <asp:Button ID="btn_girisYapın" runat="server" OnClick="btn_girisYapın_Click1" Text="Üye Giriş" CssClass="girisbutton" />
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
               <asp:Button ID="uye" runat="server" OnClick="uye_Click" Text="Kayıt Ol" CssClass="kayitbutton" />
           </div>
        </div>
   </div>
</div>
</asp:Content>
