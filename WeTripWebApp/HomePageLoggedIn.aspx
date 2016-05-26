<%@ Page Language="C#" masterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePageLoggedIn.aspx.cs" Inherits="WeTripWebApp.HomePageLoggedIn" %>

<asp:Content ID="homePageLoggedInContent"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div style="clear:left">
    Welcome
    <asp:LoginName ID="LoginName1" runat="server" Font-Bold = "true" />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/SearchTrip.aspx">Search trip</asp:LinkButton>
        <br />
        <asp:LinkButton ID="gwrss" runat="server" PostBackUrl="~/Settings.aspx">Settings</asp:LinkButton>
    <br />
    <br />
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <br />
    </div>
    
    </asp:Content>
