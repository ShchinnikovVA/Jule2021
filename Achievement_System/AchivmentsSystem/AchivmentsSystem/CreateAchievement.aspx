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
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Вернуться" />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                    <asp:BoundField DataField="Points" HeaderText="Points" SortExpression="Points" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AchievementSystemConnectionString %>" SelectCommand="SELECT * FROM [Achievement]"></asp:SqlDataSource>
            &nbsp;Дочтижение №
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Получить" />
            <br />
            <br />
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
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Отмена" />
            <br />
            <br />
            Обновить достижение:<br />
            ID:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Название:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Описание:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Кол-во очков:
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Обновить" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Отмена" />
            <br />
            <br />
            Удалить достижение:<br />
            ID:
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Удалить" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Отмена" />
        </div>
    </form>
</body>
</html>
