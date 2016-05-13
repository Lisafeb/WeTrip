<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAccount.aspx.cs" Inherits="WeTripWebApp.ViewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        UserName:<br />
        <asp:Label ID="userNameLabel" runat="server"></asp:Label>
        <asp:TextBox ID="userNamefield" runat="server"></asp:TextBox>
        <br />
        Email:</div>
        <asp:Label ID="emailLabel" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="emailField" runat="server"></asp:TextBox>
        <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="update" />
        <asp:ChangePassword ID="ChangePassword1" runat="server" OnChangedPassword="ChangePassword1_ChangedPassword">
        </asp:ChangePassword>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <p>
            Password<asp:TextBox ID="PasswordTextBox" runat="server"></asp:TextBox>
        </p>
        New Password<asp:TextBox ID="NewPasswordTextBox" runat="server"></asp:TextBox>
        <p>
            RepeatPassword<asp:TextBox ID="RepeatPasswordTextBox" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="ChangeButton" runat="server" OnClick="ChangeButton_Click" Text="Button" />
    </form>
</body>
</html>
