<%@ Page Title="Inbox" Language="C#" MasterPageFile="~/assets/master-pages/admin.master"
    AutoEventWireup="true" CodeFile="inbox.aspx.cs" Inherits="Admin.Inbox" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="span12">
            <h1>Inbox</h1>

            <asp:ListView runat="server" ID="lvMessages" ItemPlaceholderID="lvMessagesPlaceHolder">
                <LayoutTemplate>
                    <table class="table">
                        <asp:PlaceHolder runat="server" ID="lvMessagesPlaceHolder" />
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# string.Format("{0:MM/dd/yy h:mmtt}", Eval("Date")) %></td>
                        <td><%# Eval("MessageType") %></td>
                        <td>
                            <%# RenderName(Container.DataItem) %>
                        </td>
                        <td></td>
                        <td><%# Eval("MessageBody") %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
