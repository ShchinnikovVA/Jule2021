<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AchivmentsSystem.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" media="all" type="text/css" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WELCOME TO YOUR ACHIEVEMENTS WORLD<br />
            <br />
            Login
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Password
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp; <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Accept" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            Dont have an account?&nbsp;
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Create" />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Login
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" ForeColor="Maroon">Поле не может быть пустым!</asp:RequiredFieldValidator>
                <br />
                Password
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" ForeColor="Maroon">Поле не может быть пустым!</asp:RequiredFieldValidator>
                <br />
                Repeat Password
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="CompareValidator" ForeColor="Maroon">Пароли должны совпадать!</asp:CompareValidator>
                <br />
                Name
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator" ForeColor="Maroon">Поле не может быть пустым!</asp:RequiredFieldValidator>
                <br />
                Surname
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="RequiredFieldValidator" ForeColor="Maroon">Поле не может быть пустым!</asp:RequiredFieldValidator>
                <br />
                Middle name, if any
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                e-mail address
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ForeColor="Maroon" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="TextBox9">Адрес почты указан неверно!</asp:RegularExpressionValidator>
                <br />
                Phone number&nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Create!" OnClick="Button3_Click" />
                &nbsp;<asp:Button ID="Button4" runat="server" Text="Cancel" OnClick="Button4_Click" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
