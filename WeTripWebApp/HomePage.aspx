e<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WeTripWebApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        WeTrip<br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SignUp.aspx">SignUp</asp:LinkButton>
    
    </div>
        <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/LogIn.aspx">LogIn</asp:LinkButton>
    </form>
</body>
</html>
