<%@ Page Title="" Language="C#" MasterPageFile="~/AnaEkran.Master" AutoEventWireup="true" CodeBehind="Yorumlary.aspx.cs" Inherits="MinikPatiler.Yorumlary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div>
        <h2>Tüm Yorumlar</h2>
        <asp:GridView ID="gridYorumlar" runat="server" AutoGenerateColumns="False" OnRowCommand="gridYorumlar_RowCommand">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Icerik" HeaderText="Yorum" />
                <asp:BoundField DataField="EklemeTarihi" HeaderText="Tarih" DataFormatString="{0:dd.MM.yyyy HH:mm}" />
                <asp:TemplateField HeaderText="İşlemler">
                    <ItemTemplate>
                        <asp:Button ID="btnSil" runat="server" Text="Sil" CommandName="Sil" CommandArgument='<%# Eval("ID") %>' />
                        <asp:Button ID="btnDuzenle" runat="server" Text="Düzenle" CommandName="Duzenle" CommandArgument='<%# Eval("ID") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

