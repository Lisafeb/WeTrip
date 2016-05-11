<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WeTripWebApp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 384px">
    
        Username:<br />
        <asp:TextBox ID="userNameText" runat="server" Height="22px" style="margin-top: 0px" Width="236px"></asp:TextBox>
        <br />
        <br />
        Email:<br />
        <asp:TextBox ID="emailText" runat="server" Width="236px"></asp:TextBox>
        <br />
        <br />
        Password:<br />
        <asp:TextBox ID="passwordText" runat="server" Width="232px"></asp:TextBox>
        <br />
        <br />
        Repeat password:<br />
        <asp:TextBox ID="repeatPasswordText" runat="server" Width="230px"></asp:TextBox>
        <br />
        <asp:Button ID="signUpButton" runat="server" OnClick="signUpButton_Click" Text="SignUp" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
