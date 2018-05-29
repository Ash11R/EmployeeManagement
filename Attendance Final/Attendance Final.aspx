<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Attendance Final.aspx.cs" Inherits="P1.Attendance_Final" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Styling/StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <div class ="content">
    
        <asp:Label ID="Label1" runat="server" Text="Attendance" Font-Bold="True" Font-Size="XX-Large" BackColor="Aqua" Font-Names="Engravers MT" Font-Underline="True"></asp:Label>
        <br />
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Date:"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" BorderStyle="Outset" ></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Day:"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" BorderStyle="Outset"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Emp_ID"  ForeColor="#333333" >
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Emp_ID" HeaderText="Emp_ID" ReadOnly="True" SortExpression="Emp_ID" />
                <asp:BoundField DataField="Emp_Name" HeaderText="Emp_Name" SortExpression="Emp_Name" />
                <asp:BoundField DataField="Attendance_Status" HeaderText="Attendance_Status" SortExpression="Attendance_Status" />
                <asp:BoundField DataField="Attendance_Date" HeaderText="Attendance_Date" SortExpression="Attendance_Date" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:TemplateField HeaderText="First Half">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Mark" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Second Half">
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Mark" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Mark Attendance" CssClass =" button" BackColor="#66FFFF" BorderColor="Black" BorderStyle="Double" ForeColor="Black" OnClientClick="alert(&quot;Your Records will be saved&quot;)" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
            </div>
        
    </form>
</body>
</html>
