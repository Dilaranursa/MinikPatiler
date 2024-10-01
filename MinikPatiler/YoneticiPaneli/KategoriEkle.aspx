<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPaneli/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="KategoriEkle.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.KategoriEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/KategoriEkleTasarimi.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tasiyici">
        <div class="baslik">
            <h4>Kategori Ekle</h4>
        </div>
        <div class="icerik">
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                <strong>Başarılı</strong> Kategori Başarıyla Eklenmiştir 
            </asp:Panel>
            <asp:Panel ID="pnl_basarisizpanel" runat="server" CssClass="basarisizpanel" Visible="false">
                <strong>Başarısız</strong>
                <asp:Label ID="lbl_mesaj" runat="server">deneme</asp:Label>
            </asp:Panel>
            <div class="satir">
                <label>Kategori Adı</label>
                <asp:TextBox ID="tb_isim" runat="server" CssClass="metinkutu"></asp:TextBox>
            </div>
            <div class="satir">
                <label>Kategori Acıklama</label>
                <asp:TextBox ID="tb_aciklama" runat="server" CssClass="metinkutu" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:CheckBox ID="cb_aktif" runat="server" Text="aktif" />
            </div>
            <div class="satir">
                <asp:LinkButton ID="ltbn_ekle" runat="server" CssClass="islembutonu" OnClick="ltbn_ekle_Click">Kategori Ekle</asp:LinkButton>
            </div>
        </div>
        <div style="clear: both"></div>
    </div>
</asp:Content>
