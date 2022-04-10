<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Yazlab3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            width: 100%;
            height: 77px;
        }
        .auto-style4 {
            width: 180px;
        }
        .auto-style5 {
            width: 180px;
            height: 40px;
        }
        .auto-style6 {
            height: 40px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700; text-align: center; font-size: x-large">
            <span class="auto-style1">HOSGELDINIZ</span></div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">KULLANICI ADI:</td>
                    <td>
                        <asp:TextBox ID="kullaniciadialani" runat="server" Width="302px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">SIFRE:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="sifrealani" runat="server" Width="299px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="yoneticibutonu" runat="server" OnClick="yoneticibutonu_Click" Text="YONETICI GIRISI" Width="152px" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="kullanicibutonu" runat="server" OnClick="kullanicibutonu_Click" Text="KULLANICI GIRISI" Width="147px" />
    </form>
</body>
</html>
