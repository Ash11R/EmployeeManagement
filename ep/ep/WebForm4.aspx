<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="ep.WebForm4" MasterPageFile="~/Site.Master" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="Emp_ID" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="Emp_ID" HeaderText="Emp_ID" InsertVisible="False" ReadOnly="True" SortExpression="Emp_ID" />
                <asp:BoundField DataField="F_name" HeaderText="F_name" SortExpression="F_name" />
                <asp:BoundField DataField="L_Name" HeaderText="L_Name" SortExpression="L_Name" />
                <asp:BoundField DataField="P_add" HeaderText="P_add" SortExpression="P_add" />
                <asp:BoundField DataField="S_add" HeaderText="S_add" SortExpression="S_add" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="Off_tm" HeaderText="Off_tm" SortExpression="Off_tm" />
                <asp:TemplateField HeaderText="DOJ" SortExpression="DOJ">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DOJ") %>' TextMode="Date"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("DOJ", "{0:d}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DOB" SortExpression="DOB">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("DOB") %>' TextMode="Date"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("DOB", "{0:d}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Salary" HeaderText="Salary" DataFormatString="{0:c}" SortExpression="Salary" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="Mobile_no" HeaderText="Mobile_no" SortExpression="Mobile_no" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="Dpt" HeaderText="Dpt" SortExpression="Dpt" />
                <asp:ImageField DataImageUrlField="Photo" HeaderText="Photo">
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sample2ConnectionString %>"    UpdateCommand="UPDATE [emp_tb] SET [F_name] = @F_name, [L_Name] = @L_Name, [P_add] = @P_add, [S_add] = @S_add, [Gender] = @Gender, [Off_tm] = @Off_tm, [DOJ] = @DOJ, [DOB] = @DOB, [Salary] = @Salary, [email] = @email, [Mobile_no] = @Mobile_no, [Username] = @Username, [Dpt] = @Dpt, [Photo] = @Photo WHERE [Emp_ID] = @Emp_ID" SelectCommand="SELECT * FROM [emp_tb]" DeleteCommand="DELETE FROM [emp_tb] WHERE [Emp_ID] = @Emp_ID" InsertCommand="INSERT INTO [emp_tb] ([F_name], [L_Name], [P_add], [S_add], [Gender], [Off_tm], [DOJ], [DOB], [Salary], [email], [Mobile_no], [Username], [Dpt], [Photo]) VALUES (@F_name, @L_Name, @P_add, @S_add, @Gender, @Off_tm, @DOJ, @DOB, @Salary, @email, @Mobile_no, @Username, @Dpt, @Photo)" >
   
            <DeleteParameters>
                <asp:Parameter Name="Emp_ID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="F_name" Type="String" />
                <asp:Parameter Name="L_Name" Type="String" />
                <asp:Parameter Name="P_add" Type="String" />
                <asp:Parameter Name="S_add" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Off_tm" Type="String" />
                <asp:Parameter DbType="Date" Name="DOJ" />
                <asp:Parameter DbType="Date" Name="DOB" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="Mobile_no" Type="String" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="Dpt" Type="String" />
                <asp:Parameter Name="Photo" Type="String" />
            </InsertParameters>
   
            <UpdateParameters>
                <asp:Parameter Name="F_name" Type="String" />
                <asp:Parameter Name="L_Name" Type="String" />
                <asp:Parameter Name="P_add" Type="String" />
                <asp:Parameter Name="S_add" Type="String" />
                <asp:Parameter Name="Gender" Type="String" />
                <asp:Parameter Name="Off_tm" Type="String" />
                <asp:Parameter DbType="Date" Name="DOJ" />
                <asp:Parameter DbType="Date" Name="DOB" />
                <asp:Parameter Name="Salary" Type="Decimal" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="Mobile_no" Type="String" />
                <asp:Parameter Name="Username" Type="String" />
                <asp:Parameter Name="Dpt" Type="String" />
                <asp:Parameter Name="Photo" Type="String" />
                <asp:Parameter Name="Emp_ID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
