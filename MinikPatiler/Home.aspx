<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MinikPatiler.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/HomeTasarım.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="ilan-baslık">
        <p>Minik patili dostlarımızdan birine yuva olmak istermisiniz?</p>
    </div>
    <div class="ilan-kapsayici">
        <div class="sahiplenme-ilani">
            <h2>Hayvan Sahiplendirme İlanı</h2>
            <div class="hayvan-bilgileri">
                <h3>
                    <asp:Label ID="lbl_HayvanAdi" runat="server" Text="Minik"></asp:Label></h3>
                <p>
                    <strong>Cinsiyet:</strong>
                    <asp:Label ID="lbl_Cinsiyet" runat="server" Text="Dişi"></asp:Label>
                </p>
                <p>
                    <strong>Kilo:</strong>
                    <asp:Label ID="lbl_Kilo" runat="server" Text="4 kg"></asp:Label>
                </p>
                <p>
                    <strong>Yaş:</strong>
                    <asp:Label ID="lbl_Yas" runat="server" Text="2 yaşında"></asp:Label>
                </p>
                <p>
                    <strong>Hastalığı:</strong>
                    <asp:Label ID="lbl_Hastalik" runat="server" Text="Yok"></asp:Label>
                </p>
            </div>
            <div class="sahiplenme-cagrisi">
                <p>
                    <asp:Label ID="lbl_Mesaj" runat="server" Text="Minik'e sıcak bir yuva arıyoruz! Sahiplenmek için arayınız: 0555 xxx xxx xxx"></asp:Label>
                </p>
             
            </div>
        </div>
        <div class="sahiplenme-ilani">
            <h2>Hayvan Sahiplendirme İlanı</h2>
            <div class="hayvan-bilgileri">
                <h3>
                    <asp:Label ID="lbl_HayvanAdi2" runat="server" Text="Karakız"></asp:Label></h3>
                <p>
                    <strong>Cinsiyet:</strong>
                    <asp:Label ID="lbl_Cinsiyet2" runat="server" Text="Dişi"></asp:Label>
                </p>
                <p>
                    <strong>Kilo:</strong>
                    <asp:Label ID="lbl_Kilo2" runat="server" Text="4 kg"></asp:Label>
                </p>
                <p>
                    <strong>Yaş:</strong>
                    <asp:Label ID="lbl_Yas2" runat="server" Text="2 yaşında"></asp:Label>
                </p>
                <p>
                    <strong>Hastalığı:</strong>
                    <asp:Label ID="lbl_Hastalik2" runat="server" Text="Alerjik"></asp:Label>
                </p>
            </div>
            <div class="sahiplenme-cagrisi">
                <p>
                    <asp:Label ID="lbl_Mesaj2" runat="server" Text="Karakız'a sıcak bir yuva arıyoruz! Sahiplenmek için arayınız: 0555 xxx xxx xxx "></asp:Label>
                </p>
                
            </div>
        </div>
    </div>

</asp:Content>
