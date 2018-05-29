<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ApplyLeave.aspx.cs" Inherits="ep.ApplyLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="abc" runat="server">
  
     <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>  
       
    <script src="js/bootstrap.min.js"></script>    

    <script src="https://unpkg.com/feather-icons/dist/feather.min.js">
    </script>
    <link href="css/bootstrap.min.css" rel="stylesheet" /> 

    <script src="//use.typekit.net/zrq4gvu.js"></script>
    <script>try{Typekit.load();}catch(e){}</script>

    <link rel="stylesheet" runat="server" media="screen" href="Content/Leave.css" />
    <script src="Scripts/applyLeave.js"></script> 

    <link type="text/css" href="css/jquery-ui-1.8.19.custom.css" rel="stylesheet" />
   

    <script src="Scripts/calendar.js" type="text/javascript"></script>

    <meta name="viewport" content="width=device-width, initial-scale=1"/>

    <style type="text/css">
    .ui-datepicker { font-size:8pt !important}
    </style>


    <!-- Remember to check Pens for the files they include in the header. You can find this if you click on the settings button -->

<label id="Status" class="centered">Apply For Leave</label>
<form runat="server">

    <div class="proper">

     <div class="select-dropdown">

         <asp:DropDownList ID="DropDownList2" runat="server" CssClass="dropdown" >
                 <asp:ListItem >Select Type Of Leave</asp:ListItem>

            <asp:ListItem>Sick Leave</asp:ListItem>
            <asp:ListItem>Casual Leave</asp:ListItem>
            <asp:ListItem>Sectional/National Leave</asp:ListItem>
            <asp:ListItem>Earned/PL Leave</asp:ListItem>
            <asp:ListItem>Maternity Leave</asp:ListItem>
            <asp:ListItem>Transfer Leave</asp:ListItem>
            <asp:ListItem>Study/Sabbatical Leave</asp:ListItem>

        </asp:DropDownList>

  </div>

  <div class="input-field half">
      <p>


      </p>
      &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="#FFCC99" Text="Start Date:"></asp:Label>
      <asp:TextBox ID="TextBox1" runat="server" placeholder="Start Date" ForeColor="#FFCC99" TextMode="Date"/>
   
  </div>
  <div class="input-field half">
       <p>
      </p>
       <asp:Label ID="Label2" runat="server" ForeColor="#FFCC99" Text="End Date"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" placeholder="End Date" ForeColor="#FFCC99" TextMode="Date">End Date</asp:TextBox>

  </div>
 
        <div class="proper2">
     <asp:Button ID="Button2"  Cssclass="button" Text="SUBMIT" runat="server" onClick="Button2_Click" ></asp:Button>

        </div>
        <asp:Label ID="Label3" runat="server" Text="" ForeColor="Green"></asp:Label>

        </div>
</form>

</asp:Content>
