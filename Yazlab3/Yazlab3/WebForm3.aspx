<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Yazlab3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 592px;
        }
        .auto-style2 {
            margin-bottom: 0px;
        }
        .auto-style3 {
            height: 658px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="ID : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="idalani" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Kullanici Adi : "></asp:Label>
            <asp:TextBox ID="adalani" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="eklebutonu" runat="server" CssClass="auto-style2" OnClick="eklebutonu_Click" Text="Ekle" Width="193px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="silbutonu" runat="server" OnClick="silbutonu_Click" Text="SIL" Width="169px" />
&nbsp;&nbsp;
            <asp:Button ID="guncellebutonu" runat="server" OnClick="guncellebutonu_Click" Text="GUNCELLE" Width="141px" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Sifre : "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sifrealani" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
</body>
</html>
