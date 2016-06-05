<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WeTripWebApp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 384px;
            width: 633px;
        }
    </style>
</head>
<body style="width: 631px; height: 381px">
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        Username:<br />
        <asp:TextBox ID="userNameText" runat="server" Height="22px" style="margin-top: 0px" Width="236px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="userNameText" ErrorMessage="Please fill in username" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Email:<br />
        <asp:TextBox ID="emailText" runat="server" Width="236px" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="emailText" ErrorMessage="Please fill in email address" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="emailText" ErrorMessage="Please enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        Password:<br />
        <asp:TextBox ID="passwordText" runat="server" Width="232px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" 
            runat="server" ControlToValidate="passwordText" 
            ErrorMessage="Please fill in a password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        Confirm password:<br />
        <asp:TextBox ID="repeatPasswordText" runat="server" Width="230px" Height="22px" TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordText" ControlToValidate="repeatPasswordText" ErrorMessage="Passwords do not match" ForeColor="Red" ValueToCompare="passwordText"></asp:CompareValidator>
        <br />
        <asp:Button ID="signUpButton" runat="server" OnClick="signUpButton_Click" Text="SignUp" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
