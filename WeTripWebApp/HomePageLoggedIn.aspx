<%@ Page Language="C#" masterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HomePageLoggedIn.aspx.cs" Inherits="WeTripWebApp.HomePageLoggedIn" %>

<asp:Content ID="homePageLoggedInContent"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div style="clear:left">
        <div class="welcome">
            <a href="Settings.aspx"><img id="settings" src="photos/settings.png" /></a>
            <p class="welcome">!</p>
    <p class="welcome"><asp:LoginName ID="LoginName1" runat="server" Font-Bold = "true" Font-Size ="30px"/></p>
       <p class="welcome">Welcome,&nbsp;</p>

        </div>
        <div id="createTrip">
           <a href="InsertTrip.aspx"><button onclick="" type="button" class="btn btn-primary">I want to create a trip!</button></a> 
        </div>
        <div id="searchTrip">
           <a href="SearchTrip.aspx"><button type="button" class="btn btn-success">I want to search a trip!</button></a> 
        </div> 
       
    <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <br />
    </div>
    
    </asp:Content>
