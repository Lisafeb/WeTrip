<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertTrip.aspx.cs" Inherits="WeTripWebApp.InsertTrip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 212px;
        }
        .auto-style2 {
            margin-top: 1px;
        }
        .auto-style3 {
            width: 592px;
            height: 707px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style3">
    
        <asp:Label ID="Label1" runat="server" Text="Create a new trip" Font-Size="Larger"></asp:Label>
    
        <br />
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Give this trip a name!"></asp:Label>
        <br />
        <asp:TextBox ID="TripName" runat="server" Width="250px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidatorTripName" runat="server" ControlToValidate="TripName" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Ex. Tour of London, Backpackers around Europe" Font-Size="XX-Small"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Where to?"></asp:Label>
        <br />
        <asp:TextBox ID="TripDestination" runat="server" Width="250px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TripDestination" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="What's the duration?"></asp:Label>
        <br />
        <asp:TextBox ID="TripDuration" runat="server" Width="250px" TextMode="Number"></asp:TextBox>
        <asp:Label ID="Label11" runat="server" Text="Days"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="When does it start?"></asp:Label>
        <asp:TextBox ID="datepicker" runat="server" Width="250px" CssClass="auto-style1" OnTextChanged="datepicker_TextChanged"></asp:TextBox>
<p>Date: <input type="text" id="datepicker" class="auto-style1"></p>
        <br />





        <html lang="en">
<head>
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
</head>
<body>
 
</body>
</html>
        <asp:Label ID="Label5" runat="server" Text="What's the budget?"></asp:Label>



        <br />
        <asp:TextBox ID="TripBudget" runat="server" Width="250px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="How many participants?"></asp:Label>
        <br />
        <asp:TextBox ID="TripParticipants" runat="server" Width="250px" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Describe it a bit more"></asp:Label>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Ex. Itinerary" Font-Size="Smaller"></asp:Label>
        <br />
    
        <asp:TextBox ID="TripDescription" runat="server" Height="117px" Width="250px" CssClass="auto-style2"></asp:TextBox>
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TripDescription" ErrorMessage="Please fill in this field" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    
        <br />
        <br />
        <asp:Button ID="ButtonSaveTrip" runat="server" Text="Save Trip" OnClick="ButtonSaveTrip_Click" />
    
    </div>
    </form>
</body>
</html>
