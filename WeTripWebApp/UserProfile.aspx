<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="WeTripWebApp.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Edit your information"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="CurrentUserName" runat="server" Text="Current username:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="UserName" runat="server"></asp:Label>
        <br />
        Change username to:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Gender" runat="server" Text="Gender:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBoxGender" runat="server"></asp:TextBox>
        <br />
&nbsp;<asp:Label ID="Age" runat="server" Text="Age:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBoxAge" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <asp:Label ID="Country" runat="server" Text="Country:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Budget" runat="server" Text="Budget:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="TextBoxBudget" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Rating" runat="server" Text="Rating:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="UserRating" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Bio" runat="server" Text="Bio:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="129px" Width="286px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="ButtonUpdateProfile" runat="server" OnClick="ButtonUpdateProfile_Click" Text="Save" />
    
    </div>
    </form>
</body>
</html>
