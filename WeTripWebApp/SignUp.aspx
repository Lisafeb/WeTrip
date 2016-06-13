<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WeTripWebApp.SignUp" %>




<asp:Content ID="homePageLoggedInContent"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="conainer-fluid">
    <div class="auto-style1">
    </br>
        </br>
        <h4>Username:</h4><br />
        <asp:TextBox CssClass="form-control" ID="userNameText" runat="server"  style="margin-top: 0px" Width="236px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername" runat="server" ControlToValidate="userNameText" ErrorMessage="Please fill in username" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <h4>Email:</h4><br />
        <asp:TextBox CssClass="form-control" ID="emailText" runat="server" Width="236px" TextMode="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="emailText" ErrorMessage="Please fill in email address" ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="emailText" ErrorMessage="Please enter a valid email address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <br />
        <br />
        <h4>Password:</h4><br />
        <asp:TextBox CssClass="form-control" ID="passwordText" runat="server" Width="232px" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" 
            runat="server" ControlToValidate="passwordText" 
            ErrorMessage="Please fill in a password" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <br />
        <h4>Confirm password:<br />
        <asp:TextBox CssClass="form-control" ID="repeatPasswordText" runat="server" Width="230px"  TextMode="Password"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="passwordText" ControlToValidate="repeatPasswordText" ErrorMessage="Passwords do not match" ForeColor="Red" ValueToCompare="passwordText"></asp:CompareValidator>
        <br />
            <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary" runat="server" OnClick="signUpButton_Click">Sign Up</asp:LinkButton>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    
    </div>
    </div>
    </asp:Content>
