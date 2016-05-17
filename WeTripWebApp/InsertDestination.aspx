<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertDestination.aspx.cs" Inherits="WeTripWebApp.InsertDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Trip Name:<br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        Destination:<br />
        <asp:TextBox ID="DestinationTextBox" runat="server"></asp:TextBox>
        <br />
        Stops:<br />
        <asp:TextBox ID="StopsTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
