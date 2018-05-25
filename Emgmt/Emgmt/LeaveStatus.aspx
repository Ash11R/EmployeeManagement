<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveStatus.aspx.cs" Inherits="Emgmt.LeaveStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Status</title>
    <link href="css/bootstrap.min.css" rel="stylesheet" /> 

</head>
<body>
    <form id="form1" runat="server">
   

        <div>
    
         <div class="w3-card w3-round w3-white w3-center p-4">
        <div class="w3-container col-md-12 align-items-center p-4">
            
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true" 
                 OnPageIndexChanging="OnPaging" PageSize="6" CssClass="table table-striped table-bordered table-hover">
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="username" HeaderText="Employee Username " />
                    <asp:BoundField ItemStyle-Width="150px" DataField="Purpose" HeaderText="Purpose" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="StartDate" HeaderText="Start Date" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="EndDate" HeaderText="End Date" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="StatusNotif" HeaderText="Status" />
                </Columns>
            </asp:GridView>
        </div>
      </div>
      <br/>
    </div>
    
   
    </form>
</body>
</html>
