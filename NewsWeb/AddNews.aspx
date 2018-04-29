<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="AddNews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加新闻</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: right;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">新闻标题：</td>
                <td>
                    <asp:TextBox ID="TXT_Title" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">新闻类型：</td>
                <td>
                    <asp:DropDownList ID="DDL_Type" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">作者：</td>
                <td>
                    <asp:TextBox ID="TXT_Author" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">正文：</td>
                <td>
                    <asp:TextBox ID="TXT_Con" runat="server" Height="118px" TextMode="MultiLine" Width="228px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="BTN_Add" runat="server" Text="添加" OnClick="BTN_Add_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
