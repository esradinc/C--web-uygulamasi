<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Yazlab3.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" Text='<%# Bind("dosyaadi") %>' OnClick="LinkButton1_Click" >LinkButton</asp:LinkButton></body>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>   
        </asp:GridView> 
        
    </form>
   
</html>
