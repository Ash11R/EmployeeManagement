<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employee_registration.aspx.cs" Inherits="ep.Employee_registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="abc" runat="server">

    <link href="StyleSheet1.css" rel="stylesheet" />
    <style>
    .class1{
        background-image:url("")
    }
        .auto-style1 {
            margin-left: 0px;
        }
    .auto-style2 {
        list-style-type: square;
    }
    </style>
    <form id="form1" runat="server"> 
         <div class="content">
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image2" src="images/emp.JPG" runat="server" Width="515px" CssClass="auto-style1" Height="125px" />
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
             <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
             <ul class="auto-style2">
                 <li>
                     <asp:Label ID="Label15" runat="server" Font-Size="Large" ForeColor="#0033CC" Text="Browse photo" Font-Underline="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:FileUpload ID="FileUpload1" runat="server" Font-Names="fed" Width="193px" />
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
             <br />
             <br />
                 <li>
                     <asp:Label ID="Label14" runat="server" Font-Size="Larger" ForeColor="#0033CC" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox13" runat="server" Height="19px" Width="174px" BackColor="White"></asp:TextBox>
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox13" ErrorMessage="Username is required" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <br />
                 <li>
                     <asp:Label ID="Label1" runat="server" Text="First name" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox1" runat="server" Font-Size="Larger" MaxLength="15" BackColor="White" ForeColor="#003399"></asp:TextBox>

                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

             <br />
             <br />
                 <li>
                     <asp:Label ID="Label2" runat="server" Text="Last name" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;
             <asp:TextBox ID="TextBox2" runat="server" MaxLength="15" Font-Size="Larger" BackColor="White" ForeColor="#003399"></asp:TextBox>
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Last name is required" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
                 <li>
                     <asp:Label ID="Label11" runat="server" Text="Gender" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="DropDownList1" runat="server" Font-Size="Larger" BackColor="White" Width="186px">
                 <asp:ListItem></asp:ListItem>
                 <asp:ListItem>Male</asp:ListItem>
                 <asp:ListItem>Female</asp:ListItem>
             </asp:DropDownList>
                 </li>
             </ul>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Gender required" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
             <ul class="auto-style2">
                 <li>
                     <asp:Label ID="Label3" runat="server" Text="Date of Birth" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;
             <asp:TextBox ID="TextBox11" runat="server" MaxLength="15" OnTextChanged="TextBox11_TextChanged" Font-Size="Larger" TextMode="Date" BackColor="White" ForeColor="#003399" Width="181px"></asp:TextBox>
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="DOB required" ControlToValidate="TextBox11" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
             <br />
                 <li>
                     <asp:Label ID="Label4" runat="server" Text="Date of Joining" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
                     <asp:TextBox ID="TextBox12" runat="server" MaxLength="15" OnTextChanged="TextBox12_TextChanged" Font-Size="Larger" TextMode="Date" BackColor="White" ForeColor="#003399" Width="171px"></asp:TextBox>
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="DOJ required" ControlToValidate="TextBox12" ForeColor="Red">*</asp:RequiredFieldValidator>
                 <br />
                 <br />
                 <br />
                 <li>
                     <asp:Label ID="Label5" runat="server" Text="Department" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="DropDownList2" runat="server" Font-Size="Larger" BackColor="White" Width="185px">
                 <asp:ListItem></asp:ListItem>
                 <asp:ListItem>Mobility</asp:ListItem>
                 <asp:ListItem>IT</asp:ListItem>
                 <asp:ListItem>HR</asp:ListItem>
                 <asp:ListItem>Marketing</asp:ListItem>
                 <asp:ListItem>Technical</asp:ListItem>
             </asp:DropDownList>
                 </li>
             </ul>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Department is required" ControlToValidate="DropDownList2" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
             <ul class="auto-style2">
                 <li>
                     <asp:Label ID="Label6" runat="server" Text="Primary Address" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
             <asp:TextBox ID="TextBox6" runat="server" MaxLength="50" Font-Size="Larger" BackColor="White" ForeColor="#003399" Width="183px"></asp:TextBox>
                 </li>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Primary Address is required" ControlToValidate="TextBox6" ForeColor="Red">*</asp:RequiredFieldValidator>
             <br />
             <br />
             <br />
             <asp:CheckBox ID="CheckBox1" runat="server" AutoPostBack="True" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Primary address same as secondary address" BackColor="White" ForeColor="Black" />
             <br />
             <br />
             <br />
                 <li>
                     <asp:Label ID="Label7" runat="server" Text="Secondary Address" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
                     <asp:TextBox ID="TextBox7" runat="server" MaxLength="50" Font-Size="Larger" BackColor="White" ForeColor="#003399"></asp:TextBox>
                 </li>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Secondary Address required" ControlToValidate="TextBox7" ForeColor="Red">*</asp:RequiredFieldValidator>
                 <br />
                 <br />
                 <br />
                 <li>
                     <asp:Label ID="Label8" runat="server" Font-Size="Larger" Text="Mobile number" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="TextBox8" runat="server" Font-Size="Larger" BackColor="White" ForeColor="#003399"></asp:TextBox>
&nbsp;&nbsp;
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Enter mobile number" ControlToValidate="TextBox8" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Invalid number" MaximumValue="9999999999" MinimumValue="1000000000" ControlToValidate="TextBox8" Type="Double"></asp:RangeValidator>
                 </li>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 <br />
                 <li>
                     <asp:Label ID="Label9" runat="server" Text="E-mail ID" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="TextBox9" runat="server" Font-Size="Larger" BackColor="White" ForeColor="#003399"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="Email required" ControlToValidate="TextBox9" ForeColor="Red">*</asp:RequiredFieldValidator>
&nbsp;
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid E-mail" ControlToValidate="TextBox9" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                 </li>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 <br />
                 <li>
                     <asp:Label ID="Label10" runat="server" Text="Salary" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:TextBox ID="TextBox10" runat="server" Font-Size="Larger" BackColor="White" ForeColor="#003399"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="Salary required" ControlToValidate="TextBox10" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </li>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <br />
                 <br />
                 <li>
                     <asp:Label ID="Label12" runat="server" Text="Office Timings" Font-Size="Larger" ForeColor="#3333CC"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:DropDownList ID="DropDownList3" runat="server" Font-Size="Larger" BackColor="White" ForeColor="#003399">
                 <asp:ListItem></asp:ListItem>
                 <asp:ListItem>Shift 1 (8:00 AM)</asp:ListItem>
                 <asp:ListItem>Shift 2 (9:30 AM)</asp:ListItem>
             </asp:DropDownList>
             <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Select Office Timings" ForeColor="Red">*</asp:RequiredFieldValidator>
                 </li>
             </ul>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;
             <br />
             <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" CssClass="button" Font-Size="Larger" BackColor="#3399FF" ForeColor="Black" />
        </div>
    </form>

</asp:Content>
