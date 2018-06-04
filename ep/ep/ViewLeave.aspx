﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewLeave.aspx.cs" Inherits="ep.ViewLeave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="abc" runat="server">
    <meta charset="UTF-8"/>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/>
        <link rel="stylesheet" href="https://www.w3schools.com/lib/w3-theme-blue-grey.css"/>
        <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Open+Sans'/>
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"/>
        <link href="css/bootstrap.min.css" rel="stylesheet" /> 
        <link href="Content/ResponsiveGrid.css" rel="stylesheet" type="text/css" /> 
        
        <style>
        html,body,h1,h2,h3,h4,h5 {font-family: "Open Sans", sans-serif}
        </style>

     <form id="form1" runat="server">
    <div>
    
         <div class="w3-card w3-round w3-white w3-center p-4">
        <div class="w3-container col-md-12 align-items-center p-4">
            
            <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="false" AllowPaging="true" 
                 OnPageIndexChanging="OnPaging" PageSize="6" CssClass="table table-striped table-bordered table-hover">
                <Columns>
                    <asp:BoundField ItemStyle-Width="150px" DataField="username" HeaderText="Employee Username " />
                    <asp:BoundField ItemStyle-Width="150px" DataField="Purpose" HeaderText="Purpose" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="StartDate" HeaderText="Start Date" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="EndDate" HeaderText="End Date" />
                   

                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="AcceptButton"  CommandName="Accept" Text="Accept" runat="server" class="btn btn-success" CommandArgument="<%# Container.DataItemIndex %>"/>
                            <asp:Button ID="DeclineButton"  CommandName="Decline" Text="Decline" CommandArgument="<%# Container.DataItemIndex %>" runat="server" class="btn btn-danger"/>
                        </ItemTemplate>
                    </asp:TemplateField>

                 <%--   <asp:BoundField ItemStyle-Width="150px" DataField="" HeaderText="" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="" HeaderText="" />--%>
                </Columns>
            </asp:GridView>




          <%--   <asp:BoundField ItemStyle-Width="150px" DataField="" HeaderText="" />
                    <asp:BoundField ItemStyle-Width="150px" DataField="" HeaderText="" />--%>
        </div>
      </div>
      <br/>
    </div>
    </form>
</asp:Content>
