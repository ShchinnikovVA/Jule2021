<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="AchivmentsSystem.LogIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            WELCOME TO YOUR ACHIEVEMENTS WORLD<br />
            <br />
            Login
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            Password
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server"></asp:Label>
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
&nbsp;<asp:Label ID="Label4" runat="server" ForeColor="Maroon"></asp:Label>
                <br />
                Password
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label5" runat="server" ForeColor="Maroon"></asp:Label>
                <br />
                Repeat Password
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label6" runat="server" ForeColor="Maroon"></asp:Label>
                <br />
                Name
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label7" runat="server" ForeColor="Maroon"></asp:Label>
                <br />
                Surname
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label8" runat="server" ForeColor="Maroon"></asp:Label>
                <br />
                Middle name, if any
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                e-mail address
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                <br />
                Phone number&nbsp;
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Create!" />
                &nbsp;<asp:Button ID="Button4" runat="server" Text="Cancel" />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
