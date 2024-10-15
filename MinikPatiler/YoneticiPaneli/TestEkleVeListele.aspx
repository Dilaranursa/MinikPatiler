<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPaneli/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="TestEkleVeListele.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.TestEkleVeListele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/TestSitil.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="formTasiyici">
            <div class="formBaslik">
                <h4>Soru Ekle</h4>
            </div>
            <div class="formIcerik">
                <asp:Panel ID="pnl_basarili" runat="server" CssClass="basariliPanel" Visible="false">
                    <strong>Başarılı!</strong> Soru Başarıyla Eklenmiştir.
                </asp:Panel>
                <asp:Panel ID="pnl_basarisiz" runat="server" CssClass="basarisizPanel" Visible="false">
                    <strong>Başarısız!</strong>
                    <asp:Label ID="lbl_mesaj" runat="server" Text=""></asp:Label>
                </asp:Panel>
                <div class="satir">
                    <label>Soru</label><br />
                    <asp:TextBox ID="tb_soru" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>A Şıkkı</label><br />
                    <asp:TextBox ID="tb_acevabi" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>B Şıkkı</label><br />
                    <asp:TextBox ID="tb_bcevabi" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>C Şıkkı</label><br />
                    <asp:TextBox ID="tb_cevabi" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <label>D Şıkkı</label><br />
                    <asp:TextBox ID="tb_devabi" runat="server" CssClass="metinKutu"></asp:TextBox>
                </div>
                <div class="satir">
                    <asp:LinkButton ID="lbtn_ekle" runat="server" CssClass="islemButton" OnClick="lbtn_ekle_Click">Soru Ekle</asp:LinkButton>
                </div>
            </div>
        </div>
        
</asp:Content>
