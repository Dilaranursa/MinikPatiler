<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPaneli/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="KategoriDuzenle.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.KategoriDuzenle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/KategoriEkleTasarimi.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tasiyici">
        <div class="baslik">
            <h4>Kategori Düzenle</h4>
        </div>
        <div class="icerik">
            <asp:Panel ID="pnl_basarili" runat="server" CssClass="basarilipanel" Visible="false">
                <strong>Başarılı!</strong> Kategori Başarıyla Düzenlenmiştir
            </asp:Panel>
            <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisizpanel" Visible="false">
                <strong>Başarısız!</strong>
                <asp:Label ID="lbl_mesaj" runat="server">deneme</asp:Label>
            </asp:Panel>
            <div class="satir">
                <label>Kategori Adı</label><br />
                <asp:TextBox ID="tb_isim" runat="server" CssClass="metinkutu"></asp:TextBox>
            </div>
            <div class="satir">
                <label>Kategori Açıklama</label><br />
                <asp:TextBox ID="tb_aciklama" runat="server" CssClass="metinkutu" TextMode="MultiLine"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:CheckBox ID="cb_aktif" runat="server" Text="  Kategori Aktif" />
            </div>
            <div class="satir">
                <asp:LinkButton ID="lbtn_duzenle" runat="server" CssClass="islembutonu" OnClick="lbtn_duzenle_Click">Kategori Düzenle</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
