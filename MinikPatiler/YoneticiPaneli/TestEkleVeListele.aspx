<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPaneli/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="TestEkleVeListele.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.TestEkleVeListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/TestSitil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="tasiyici">
     <div class="baslik">
         <h4>Kategori Ekle</h4>
     </div>
          <div class="icerikkapsasyicisi">
      <asp:Button ID="btn_testOluştur" runat="server" Text="Test Oluştur" CssClass="btn" OnClick="btn_testOluştur_Click" />
      <asp:Button ID="btn_testListele" runat="server" Text="Test Listele" CssClass="btn" OnClick="btn_testListele_Click" />

      <!-- Test Oluştur/Düzenle Paneli -->
      <asp:Panel id="pnl_testolusturr" runat="server" CssClass="panel" Visible="false">
        <h2 >Test Oluştur</h2>
        <label for="testTitle">Test Başlığı</label>
        <asp:TextBox ID="tb_testBaslik" runat="server" CssClass="testbaslik" placeholder="Test başlığı girin"></asp:TextBox><br />

        <div id="sorukapsacicisi">
          <h3>Sorular</h3>
        </div>
        <asp:Button ID="btn_yenisoru" runat="server" Text="Soru Ekle" OnClick="btn_yenisoru_Click" CssClass="btn" />

        <div class="panel">
          <h3>Resim Yükle</h3>
          <input type="file" id="image" accept="image/*" onchange="previewImage(event)" />
          <div id="ongosterim" style="margin-top: 10px"></div>
        </div>

        <asp:Button ID="btn_kaydet" runat="server" Text="Testi Kaydet" CssClass="btn" OnClick="btn_kaydet_Click"/>
        <asp:Label ID="lbl_basarili" runat="server" Text="" ForeColor="Green" Visible="false"></asp:Label>
      </asp:Panel>

      <!-- Test Listeleme Paneli -->
      <div id="pnl_listele" runat="server" class="panel" style="display: none">
        <h3>Oluşturulan Testler</h3>
        <asp:Repeater ID="rpt_test" runat="server">
          <ItemTemplate>
            <div class="testverisi">
              <h4><%# Eval("Title") %></h4>
              <asp:Button ID="btn_duzenle" runat="server" Text="Düzenle" CommandArgument='<%# Container.ItemIndex %>' OnClick="btn_duzenle_Click" />
              <asp:Button ID="btn_sil" runat="server" Text="Sil" CommandArgument='<%# Container.ItemIndex %>' OnClick="btn_sil_Click" />
            </div>
          </ItemTemplate>
        </asp:Repeater>
      </div>
    </div>
   </div>

</asp:Content>
