<%@ Page Title="Messages" Language="C#" MasterPageFile="~/assets/master-pages/admin.master"
    AutoEventWireup="true" CodeFile="messages.aspx.cs" Inherits="admin_default" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="span12">
            <h1>Messages</h1>

            <asp:ListView runat="server" ID="lvMessages" ItemPlaceholderID="lvMessagesPlaceHolder">
                <LayoutTemplate>
                    <ul>
                        <asp:PlaceHolder runat="server" ID="lvMessagesPlaceHolder" />
                    </ul>
                </LayoutTemplate>
                <ItemTemplate>
                    <li>
                        <%# Eval("MessageType") %>
                        <%# Eval("LastName") %>
                        <%# Eval("FirstName") %>
                        <%# Eval("EmailAddress") %>
                        <%# Eval("MessageBody") %>
                        <%# Eval("Date") %>
                    </li>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
