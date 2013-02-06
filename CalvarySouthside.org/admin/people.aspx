<%@ Page Title="People" Language="C#" MasterPageFile="~/assets/master-pages/admin.master"
    AutoEventWireup="true" CodeFile="people.aspx.cs" Inherits="Admin.People" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="Server">
    <asp:DataGrid runat="server" ID="dgPeople" AutoGenerateColumns="false" CssClass="table table-bordered" HeaderStyle-CssClass="header">
        <Columns>
            <asp:TemplateColumn HeaderText="Admin" SortExpression="Admin" HeaderStyle-Width="32px">
                <ItemTemplate>
                    <div style="text-align:center;">
                        <i class="icon-check" runat="server" visible='<%# Eval("Admin") %>' 
                        title='This person has administrator privileges.'></i>
                    </div>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Name" SortExpression="LastName">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("Id", "~/admin/user-profile.aspx?id={0}") %>'>
                        <%# Eval("LastName") %>, <%# Eval("FirstName") %>
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:BoundColumn DataField="EmailAddress" HeaderText="Email Address" SortExpression="EmailAddress" />
            <asp:BoundColumn DataField="PhoneNumber" HeaderText="Phone" SortExpression="PhoneNumber" />
        </Columns>
    </asp:DataGrid>
</asp:Content>
