<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Admin.ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="Contact_us_css.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div class="container">
        <div class="row">
            <h1>contact us</h1>
        </div>
        <div class="row">
            <h4 style="text-align:center">We'd love to hear from you!</h4>
        </div>
        <div class="row input-container">
            <div class="col-xs-12">
                <div class="styled-input wide">

                    <asp:TextBox ID="TextBox1" runat="server" placeholder="Name" type="text" required/>
                   
                </div>
            </div>
            <div class="col-md-6 col-sm-12">
                <div class="styled-input">
                     <asp:TextBox ID="TextBox2" runat="server" placeholder="Email" type="text" required/>
                    
                </div>
            </div>
            <div class="col-md-6 col-sm-12">
                <div class="styled-input" style="float:right;">
                   <asp:TextBox ID="TextBox3" runat="server" placeholder="Phone" type="text" required/>
                </div>
            </div>
            <div class="col-xs-12">
                <div class="styled-input wide">
                    <asp:TextBox ID="TextArea1" TextMode="MultiLine" Columns="50" Rows="5" runat="server" required placeholder="Message"/> 

           
                </div>
            </div>
            <div class="col-xs-12">
                <asp:Button ID="button1" CssClass="btn-lrg submit-btn" Text="Send Message" runat="server" OnClick="button1_Click" ></asp:Button>
               
            </div>
        </div>
    </div>

    </div>
    </form>
</body>
</html>
