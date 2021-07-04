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
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" HorizontalAlign="Center" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="Имя" HeaderText="Имя" SortExpression="Имя" />
                    <asp:BoundField DataField="Фамилия" HeaderText="Фамилия" SortExpression="Фамилия" />
                    <asp:BoundField DataField="Отчество" HeaderText="Отчество" SortExpression="Отчество" />
                    <asp:BoundField DataField="column1" HeaderText="Эл. Почта" SortExpression="column1" />
                    <asp:BoundField DataField="Телефон" HeaderText="Телефон" SortExpression="Телефон" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AchievementsConnectionString %>" SelectCommand="SELECT [Имя], [Фамилия], [Отчество], [Эл. Почта] AS column1, [Телефон] FROM [User]"></asp:SqlDataSource>
        </div>
        <div id="ce2" class="cont_elem">
            <asp:GridView ID="GridView2" runat="server" HorizontalAlign="Center">
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
        </div>
    </div>
    </form>
    </body>
</html>
