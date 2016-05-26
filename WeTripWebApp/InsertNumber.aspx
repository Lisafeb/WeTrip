<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertNumber.aspx.cs" Inherits="WeTripWebApp.InsertNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">Welcome
    <asp:LoginName ID="LoginName1" runat="server" Font-Bold = "true" />
    <div>
    
        <input id="testField" type="text" /><asp:Button ID="testButton" runat="server" OnClick="testButton_Click" Text="Insert" />
    
    </div>
        <div>
    
    <br />
    <br />
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
</div>
    </form>
</body>
</html>
