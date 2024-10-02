<%@ Page Title="" Language="C#" MasterPageFile="~/YoneticiPaneli/YoneticiMaster.Master" AutoEventWireup="true" CodeBehind="Kullanicilar.aspx.cs" Inherits="MinikPatiler.YoneticiPaneli.Kullanicilar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Css/ListeTasarimi.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="sayfaBaslik">
     <h3>Kullanıcı Listele</h3>
 </div>
 <div class="tabloTasiyici">
     <asp:ListView ID="lv_Kullanicilar" runat="server" OnItemCommand="lv_Kullanıcılar_ItemCommand">
         <LayoutTemplate>
             <table cellspacing="0" cellpadding="0" class="tablo">
                 <tr>
                     <th>UyeID</th>
                     <th>İsim</th>
                      <th>Soyisim</th>
                     <th>Epostaları</th>
                     <th>Seçenekler</th>
                 </tr>
                 <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
             </table>
         </LayoutTemplate>
         <ItemTemplate>
             <tr>
                 <td><%# Eval("UyeID") %></td>
                 <td><%# Eval("Isim") %></td>
                  <td><%# Eval("Soyisim") %></td>
                 <td><%# Eval("Eposta") %></td>
                 <td class="ikon">
                 <asp:LinkButton ID="lbtn_sil" runat="server" class="tablobutton sil" CommandArgument='<%# Eval("UyeID") %>' CommandName="sil"> 
                          <img src="Resimler/pngwing.com.png" />
                         </asp:LinkButton>
                 </td>
             </tr>
         </ItemTemplate>
       </asp:ListView>
 </div>
</asp:Content>
