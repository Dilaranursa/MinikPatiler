<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MinikPatiler.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="lv_makaleler1" runat="server">
        <ItemTemplate>
            <div class="makale">
                <a href='MakaleGosterme.aspx?makale=<%# Eval("ID") %>'>
                <h2 style="margin: 10px 0;"><%# Eval("Baslik") %></h2>
                <img src='Resimler/MakaleResimleri/<%# Eval("KapakResim") %>'  />
                <div class="ayrac"></div>
                <div class="altbilgi">
                    Yazar: <%# Eval("Yazar") %> | Kategori: <%# Eval("Kategori") %>     
                    Yayınlama Tarihi: <%# Eval("EklemeTarihi") %> | Görüntüleme Sayısı: <%# Eval("GoruntulemeSayisi") %>
                    <p>Merak ettiyseniz tıklayın ve hemen okumaya başlayın</p>
                </div>                              
                   
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</asp:Content>
