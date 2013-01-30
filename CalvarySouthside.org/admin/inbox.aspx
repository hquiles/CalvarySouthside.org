<%@ Page Title="Inbox" Language="C#" MasterPageFile="~/assets/master-pages/admin.master"
    AutoEventWireup="true" CodeFile="inbox.aspx.cs" Inherits="Admin.Inbox" %>

<asp:Content ContentPlaceHolderID="cphContent" runat="Server">
    <div class="row">
        <div class="span12">
            <h1>Inbox</h1>

            <asp:ListView runat="server" ID="lvMessages" ItemPlaceholderID="lvMessagesPlaceHolder">
                <LayoutTemplate>
                    <table class="table table-bordered">
                        <tr>
                            <th>Date</th>
                            <th>Name</th>
                            <th>Message Type</th>
                        </tr>
                        <asp:PlaceHolder runat="server" ID="lvMessagesPlaceHolder" />
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <a href="#" class="toggle-message" data-messageid='<%# Eval("Id") %>'>
                                <i class="icon-circle-arrow-right"></i>
                            </a>
                            
                            <%# string.Format("{0:MM/dd/yy h:mmtt}", Eval("Date")) %>
                        </td>
                        <td>
                            <%# RenderName(Container.DataItem) %>
                        </td>
                        <td><%# Eval("MessageType") %></td>
                    </tr>
                    <tr class="inbox-message" id='inbox-message-<%# Eval("Id") %>'>
                        <td colspan="3">
                            <div>
                                <%# Eval("MessageBody") %>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>

<asp:Content ContentPlaceHolderID="cphFooter" runat="server">
    <script type="text/javascript">
        $(document).ready(function(){
            $('a.toggle-message').on('click', function(e){
                var $iconLink = $(this);
                var messageId = $(this).data('messageid');
                $('#inbox-message-' + messageId).slideToggle(0, function(){
                    if ($(this).is(':hidden'))
                    {
                        $iconLink.find('i').attr('class', 'icon-circle-arrow-right');
                    } else {
                        $iconLink.find('i').attr('class', 'icon-circle-arrow-down');
                    }
                });

                e.preventDefault();
            });
        });
    </script>
</asp:Content>