<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yoneticisayfasi.aspx.cs" Inherits="Yazlab3.yoneticisayfasi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 281px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        Kullanini Islemleri Icın Tiklayiniz&nbsp;&nbsp;&nbsp;
        <asp:Button ID="kullanicieklebutonu" runat="server" OnClick="kullanicieklebutonu_Click" Text="GIT" Width="143px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Eklenen pdfleri görmek için tiklayin : "></asp:Label>
        <asp:Button ID="pdfgoruntule" runat="server" OnClick="pdfgoruntule_Click" Text="GIT" Width="140px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Pdf bölümlerini listelemek için tiklayin :"></asp:Label>
        <asp:Button ID="listele" runat="server" OnClick="listele_Click" Text="GIT" Width="119px" />
        <br />
    </form>
</body>
</html>
