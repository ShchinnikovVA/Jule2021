<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="AchivmentsSystem.Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" media="all" type="text/css" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="title">
            Добро пожаловать,
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
        </div>
    <div class="container">
        <div id="ce1" class="cont_elem">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
&nbsp;<br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </div>
        <div id="ce2" class="cont_elem">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id_user" HeaderText="Id_user" SortExpression="Id_user" />
                    <asp:BoundField DataField="Id_achievement" HeaderText="Id_achievement" SortExpression="Id_achievement" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AchievementSystemConnectionString %>" SelectCommand="SELECT [Id_user], [Id_achievement] FROM [Map] WHERE ([Id_achievement] = @Id_achievement)">
                <SelectParameters>
                    <asp:CookieParameter CookieName="This User" Name="Id_achievement" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </div>
    </form>
    </body>
</html>
