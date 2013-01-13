<%@ Page Title="" Language="C#" MasterPageFile="~/assets/master-pages/main.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="prayer_requests_default" %>

<%@ Register Src="~/assets/user-controls/ToggleSwitch.ascx" TagName="ToggleSwitch" TagPrefix="bh" %>

<%-- 
    TODO:

    - modified form for signed in users
    - toggle switch between prayer requests and praise report

--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2><span>Prayer Requests</span></h2>

    <table class="align-top">
        <tr>
            <td style="width:20%;">
                <asp:Label Text="Prayer Request" runat="server" AssociatedControlID="txtFirstName" />
            </td>
            <td style="width:80%;">
                <asp:RadioButtonList runat="server" ID="chklstPrayerOrPraise">
                    <asp:ListItem Text="Prayer Request" Value="0" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Praise Report" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="First Name" runat="server" AssociatedControlID="txtFirstName" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtFirstName" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Last Name" runat="server" AssociatedControlID="txtLastName" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtLastName" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Email Address" runat="server" AssociatedControlID="txtEmailAddress" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtEmailAddress" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Message" runat="server" AssociatedControlID="txtMessage" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Remain Anonymous" runat="server" AssociatedControlID="chkAnonymous" />
            </td>
            <td>
                <asp:CheckBox runat="server" ID="chkAnonymous" />
                <bh:ToggleSwitch runat="server" ID="tsAnonymous" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button runat="server" OnClick="SubmitForm" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>

