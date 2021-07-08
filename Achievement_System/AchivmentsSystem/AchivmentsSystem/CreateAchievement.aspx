<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAchievement.aspx.cs" Inherits="AchivmentsSystem.CreateAchievement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Создать достижение:<br />
            Название:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Описание:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Кол-во очков:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                    <asp:BoundField DataField="Points" HeaderText="Points" SortExpression="Points" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AchievementSystemConnectionString %>" SelectCommand="SELECT * FROM [Achievement]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
