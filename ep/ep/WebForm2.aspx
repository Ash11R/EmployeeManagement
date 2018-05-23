<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ep.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows">
            <HoverNodeStyle BackColor="Red" Font-Underline="True" ForeColor="#5555DD" />
            <Nodes>
                <asp:TreeNode NavigateUrl="~/Default.aspx" Target="_blank" Text="Site_Master" Value="Web_form1">
                    <asp:TreeNode ImageUrl="~/images/dog.png" SelectAction="Expand" Text="DogImage" Value="DogImage"></asp:TreeNode>
                </asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/WebForm1.aspx" Text="Webform_1" Value="New Node"></asp:TreeNode>
            </Nodes>
            <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
            <ParentNodeStyle Font-Bold="False" />
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
    </form>
</body>
</html>
