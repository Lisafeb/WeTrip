<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUpdateProfile.aspx.cs" Inherits="WeTripWebApp.CreateUpdateProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Create Profile<br />
        <br />
        Gender:<br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem Selected="True">Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:ListBox>
        <br />
        Age:<br />
        <asp:TextBox ID="Age" runat="server" Width="238px"></asp:TextBox>
        <br />
        Budget:<br />
        <asp:TextBox ID="Budget" runat="server" Width="235px"></asp:TextBox>
        <br />
        Country:<br />
        <asp:TextBox ID="Country" runat="server" Width="235px"></asp:TextBox>
        <br />
        Bio:<br />
        <asp:TextBox ID="Bio" runat="server" Height="92px" Width="229px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" Width="235px" />
        <br />
    
    </div>
    </form>
</body>
</html>
