<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="MakaleGosterme.aspx.cs" Inherits="MinikPatiler.MakaleGosterme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/MakaleGosterme.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="makale">
        <h2 style="margin: 10px 0;">
            <asp:Literal ID="ltrl_baslik" runat="server"></asp:Literal>
        </h2>
        <asp:Image ID="img_resim" runat="server" Style="width:250px; height:250px;" />
        <div class="ayrac"></div>
        <div class="altbilgi">
            Yazar :<asp:Literal ID="ltrl_yazar" runat="server"></asp:Literal>| 
            Kategori :<asp:Literal ID="ltrl_kategori" runat="server"></asp:Literal>
            Yayınlama Tarihi:<asp:Literal ID="ltrl_yayinlama" runat="server"></asp:Literal>
            Görüntüleme Sayısı :<asp:Literal ID="ltrl_goruntuleme" runat="server"></asp:Literal>
        </div>
        <div class="ayrac"></div>
        <div style="margin: 10px 0; text-align:justify">
            <asp:Literal ID="ltrl_icerik" runat="server"></asp:Literal>
        </div>
    </div>

    <div class="yorumlar">
        <div class="yorumBaslik">
            Yorum Yaz
        </div>
        <div class="yorumIcerik">
            <asp:TextBox ID="tb_yorumIcerik" runat="server" TextMode="MultiLine" placeholder="Yorum yaz..." CssClass="tbIcerik">

            </asp:TextBox><br />
            <asp:LinkButton ID="lbtn_yorumGonder" runat="server" Text="Yorum Gönder" CssClass="gonderButon" OnClick="lbtn_yorumGonder_Click">

            </asp:LinkButton> 
            <div style="clear:both"></div>
            <asp:Panel ID="pnl_bilgi" runat="server" Visible="false" CssClass="bilgiPaneli">
                <asp:Label ID="lbl_bilgiMesaji" runat="server" Text="text"></asp:Label>
            </asp:Panel>
        </div>



    </div>

      
</asp:Content>
