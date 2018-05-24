<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Emgmt.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.2/jquery.min.js"></script>  
    <script src="js/bootstrap.min.js"></script>    
    <link href="css/bootstrap.min.css" rel="stylesheet" />     
    <link rel="stylesheet" runat="server" media="screen" href="StyleSheet1_webform.css" />
    <title>LOGIN</title>

</head>
<body>
    <form id="form1" runat="server">

        <div class="wrap">

             <asp:DropDownList ID="DropDownList1" class="wrap" runat="server" CssClass="wrap">
                 <asp:ListItem Value>Select</asp:ListItem>

            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Employee</asp:ListItem>
        </asp:DropDownList>

            <div class="avatar">
                <img src="http://cdn.ialireza.me/avatar.png" />
            </div>

            <asp:TextBox ID="TextBox1" runat="server" CssClass="wrap" placeholder="username" required> </asp:TextBox>

            <div class="bar">
			<i></i>
		</div>

            <asp:TextBox ID="TextBox2" CssClass="wrap" type="password" runat="server" placeholder="password" required></asp:TextBox>
            <a href="" class="forgot_link">forgot ?</a>

           
            <asp:Button ID="Button1" class="button"  Text="LOGIN" runat="server" onClick="Button1_Click" BackColor="#A4E250" ></asp:Button>
           
            <%--<button onclick="Button1_Click">LOGIN</button>--%>
        </div>
    </form>
</body>
</html>
