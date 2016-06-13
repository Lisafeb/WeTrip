<%@ Page Language="C#" masterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WeTripWebApp.LogIn" %>
<asp:Content ID="logInContent"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    
    <div class="container-fluid">
    <div class="logIn text-center" style="clear:left">
        <asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate" Height="217px" Width="798px">
            <LayoutTemplate>
                <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table cellpadding="0" class="auto-style2">
                                <tr>
                                    <td align="center" colspan="2">Log In</td>
                                </tr>
                                <tr>
                                    <td align="left" class="auto-style1">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" Width="391px">User Name:</asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td aria="right" class="auto-style1">
                                        <asp:TextBox ID="UserName" class="form-control" runat="server" Width="501px"></asp:TextBox>
                                    </td>
                                    <td>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="UserName" ErrorMessage="Username is required" ForeColor="Red"></asp:RequiredFieldValidator>
                                        
                                    </td>
                                </tr>
                            
                        </td>
                    </tr>
                    <tr>
                        <td align="left" class="auto-style1">
                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" Width="532px">Password:</asp:Label>
                            <br />
                        </td>
                        </tr>
                        <tr>
                        <td class="auto-style1">
                            <asp:TextBox ID="Password" class="form-control" runat="server" TextMode="Password" Width="499px"></asp:TextBox>
                        </td>
                            
                        
                        <td>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Password" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                
                    </tr>
                    <tr>
                        
                        <td class="auto-style1">
                            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2" style="color:Red;">
                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False" Text=" "></asp:Literal>
                        </td>
                    </tr>
                    <tr>
                        <td align="left" colspan="2">
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" CssClass="btn btn-primary" Text="Log In" ValidationGroup="Login1" Width="499px" OnClick="LoginButton_Click" />
                        </td>
                    </tr>
                </table>
                </td>
                </tr>
                </table>
            </LayoutTemplate>
        </asp:Login>
        </div>
    </div>
  

      </asp:Content>


