<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Settings.aspx.cs" Inherits="WeTripWebApp.Settings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/ViewAccount.aspx">Account Info</asp:LinkButton>
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" PostBackUrl="~/UserProfile.aspx">Create profile</asp:LinkButton>
        <br />
        <asp:LinkButton ID="ProfileInfoLinkButton" runat="server" PostBackUrl="~/ViewProfile.aspx" Visible="False">Profile Info</asp:LinkButton>
        <br />
        View your trips<br />
        <asp:LinkButton ID="LinkButton3" runat="server" PostBackUrl="~/HomePageLoggedIn.aspx">Back</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
