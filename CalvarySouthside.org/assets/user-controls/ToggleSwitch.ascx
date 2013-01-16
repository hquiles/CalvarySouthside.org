<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ToggleSwitch.ascx.cs" Inherits="assets_user_controls_ToggleSwitch" %>

<%-- 
    TODO:
    - initialize hidden field and display to given value
    - Property to change display mode from on/off to yes/no
--%>

<div class="ToggleSwitch">
    <div>
        <asp:HyperLink NavigateUrl="#" ID="hlnkToggleSwitch" runat="server">
            <asp:HiddenField runat="server" ID="hdnToggleSwitch" />
        </asp:HyperLink>
    </div>
</div>