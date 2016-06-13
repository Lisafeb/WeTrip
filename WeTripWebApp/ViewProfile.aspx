<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="WeTripWebApp.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Id:<br />
        <asp:Label ID="LabelId" runat="server" Text="LabelId"></asp:Label>
        <br />
        Gender:<br />
        <asp:Label ID="LabelGender" runat="server" Text="LabelGender"></asp:Label>
        <br />
        Age:<br />
        <asp:Label ID="LabelAge" runat="server" Text="LabelAge"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownListAge" runat="server">
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>19</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>21</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
            <asp:ListItem>23</asp:ListItem>
            <asp:ListItem>24</asp:ListItem>
            <asp:ListItem>25</asp:ListItem>
            <asp:ListItem>26</asp:ListItem>
            <asp:ListItem>27</asp:ListItem>
            <asp:ListItem>28</asp:ListItem>
            <asp:ListItem>29</asp:ListItem>
            <asp:ListItem>30</asp:ListItem>
            <asp:ListItem>31</asp:ListItem>
        </asp:DropDownList>
        <br />
        Budget:<br />
        <asp:Label ID="LabelBudget" runat="server" Text="LabelBudget"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxBudget" runat="server"></asp:TextBox>
        <br />
        Country:<br />
        <asp:Label ID="LabelCountry" runat="server" Text="LabelCountry"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxCountry" runat="server"></asp:TextBox>
        <br />
        Bio:<br />
        <asp:Label ID="LabelBio" runat="server" Text="LabelBio"></asp:Label>
        <br />
        <asp:TextBox ID="TextBoxBio" runat="server"></asp:TextBox>
        <br />
        Rating:<br />
        <asp:Label ID="LabelRating" runat="server" Text="LabelRating"></asp:Label>
        <br />
        <asp:Button ID="SaveButton" runat="server" Text="Save" OnClick="SaveButton_Click" />
        <asp:Button ID="CancelButton" runat="server" PostBackUrl="~/Settings.aspx" Text="Cancel" />
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
        <br />
        <br />
        <br />
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
