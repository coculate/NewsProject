<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewsTitle.aspx.cs" Inherits="NewsTitle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body style="border-style: solid; border-width: 1px; padding: 1px 4px">
    <form id="form1" runat="server">
        <div>

            <asp:Repeater ID="RPT_Title" runat="server">
                <HeaderTemplate><ul></HeaderTemplate>
                <ItemTemplate>
                    <li><a href="NewsContent.aspx?ID=<%#Eval("NewsId") %>"><%#Eval("Title") %></a></li>
                </ItemTemplate>
                <FooterTemplate></ul></FooterTemplate>
            </asp:Repeater>

        </div>
    </form>
</body>
</html>
