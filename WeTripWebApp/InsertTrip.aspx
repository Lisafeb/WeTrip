<%@ Page Language="C#" masterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="InsertTrip.aspx.cs" Inherits="WeTripWebApp.InsertTrip" %>


    
        <asp:Content ID="homePageLoggedInContent"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="contentInsertTrip">
      <br />
        <br />
        <br />
        <asp:Label ID="Label2" class="customisedLabel"  runat="server" Text="Give this trip a name!" Font-Size="20px"></asp:Label>
        <br />
        <asp:TextBox ID="TripName" runat="server" Width="250px" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTripName" runat="server" ControlToValidate="TripName" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Ex. Tour of London, Backpackers around Europe" Font-Size="XX-Small"></asp:Label>
            <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Where to?" Font-Size="20px"></asp:Label>
        <br />
        <asp:TextBox ID="TripDestination" runat="server" Width="250px" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TripDestination" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="What's the duration?" Font-Size="20px"></asp:Label>
        <br />
        <asp:TextBox ID="TripDuration" runat="server" Width="250px" TextMode="Number" min="1" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Days"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="When does it start?" Font-Size="20px"></asp:Label>
        <asp:TextBox ID="datepicker" runat="server" Width="250px" CssClass="form-control" type="date" OnTextChanged="datepicker_TextChanged"></asp:TextBox>
        <br />





   

  <meta charset="utf-8">
  <title>jQuery UI Datepicker - Default functionality</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.11.4/themes/smoothness/jquery-ui.css">
  <script src="//code.jquery.com/jquery-1.10.2.js"></script>
  <script src="//code.jquery.com/ui/1.11.4/jquery-ui.js"></script>
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script>
  $(function() {
    $( "#datepicker" ).datepicker();
  });
  </script>


        <asp:Label ID="Label5" runat="server" Text="What's the budget?" Font-Size="20px"></asp:Label>



        <br />
        <asp:TextBox ID="TripBudget" runat="server" Width="250px" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="How many participants?" Font-Size="20px"></asp:Label>
        <br />
        <asp:TextBox ID="TripParticipants" runat="server" Width="250px" TextMode="Number" min="1" CssClass="form-control"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Describe it a bit more" Font-Size="20px"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Ex. Itinerary" Font-Size="Smaller"></asp:Label>
        <br />
    
        <asp:TextBox ID="TripDescription" runat="server" Height="117px" Width="250px" CssClass="auto-style2"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TripDescription" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    
        <br />
        <br />
        <asp:Button ID="ButtonSaveTrip" runat="server" Text="Save Trip" OnClick="ButtonSaveTrip_Click" CssClass="btn btn-success" />
    
        
    
        <br />
        <asp:Label ID="StatusLabel" runat="server" Text="Your trip was successfully inserted!" Visible="False"></asp:Label>
    
    </div>
            </asp:Content>

