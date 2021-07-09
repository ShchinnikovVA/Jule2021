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
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Редактировать" />
        </div>
        <div id="ce2" class="cont_elem">
            <asp:ListBox ID="ListBox1" runat="server" Height="206px" Width="481px">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Добавить награду" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Удалить профиль" />
            <asp:Panel ID="Panel2" runat="server" Visible="False">
                Вы уверены?<br />
                <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Да" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Нет" />
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel1" runat="server" Height="275px" Visible="False" Width="488px">
            Редактировать профиль:<br /> Логин:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Пароль:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Имя:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Фаммилия:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            Отчество:
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            Почта:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            Номер телефона:
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Сохранить" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Отмена" />
        </asp:Panel>
    </div>
    </form>
    </body>
</html>
