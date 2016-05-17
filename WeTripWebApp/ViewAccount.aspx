<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAccount.aspx.cs" Inherits="WeTripWebApp.ViewAccount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        Change User Name or/and Email:<br />
        <br />
    
        UserName:<br />
        <asp:Label ID="userNameLabel" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="userNamefield" runat="server"></asp:TextBox>
        <br />
        Email:</div>
        <asp:Label ID="emailLabel" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="emailField" runat="server"></asp:TextBox>
        <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="update" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <p>
            Password</p>
        <p>
        <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" />
        </p>
        <p>
            New Password</p>
        <p>
        <asp:TextBox ID="NewPasswordTextBox" runat="server" TextMode="Password" OnTextChanged="NewPasswordTextBox_TextChanged" />
        </p>
        <p>
            Repeat New Password</p>
        <p>
        <asp:TextBox ID="RepeatPasswordTextBox" runat="server" TextMode="Password" />
        </p>
        <p>
        <asp:Button ID="ChangeButton" runat="server" OnClick="ChangeButton_Click" Text="Change Password" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
