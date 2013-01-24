<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/assets/master-pages/main.master"
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="contact_default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2><span>Contact Us</span></h2>

    <div class="group">
        <div class="grid golden-long">
            <p>
                Please join us at:
            </p>
            <p>
                Please contact us via e-mail at <a href="mailto:calvarysouthside@gmail.com">calvarysouthside@gmail.com</a> or at <strong>(727) 593-4782</strong>
            </p>

            <hr />

            <asp:Label Text="First Name" runat="server" AssociatedControlID="txtFirstName" />
            <asp:TextBox runat="server" ID="txtFirstName" />

            <asp:Label Text="Last Name" runat="server" AssociatedControlID="txtLastName" />
            <asp:TextBox runat="server" ID="txtLastName" />

            <asp:Label Text="Email Address" runat="server" AssociatedControlID="txtEmailAddress" />
            <asp:TextBox runat="server" ID="txtEmailAddress" />

            <asp:Label Text="Message" runat="server" AssociatedControlID="txtMessage" />
            <asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" />

            <asp:Button ID="Button1" runat="server" OnClick="SubmitForm" Text="Submit" CssClass="btn" />

        </div>
        <div class="grid golden-short">
            <a href="http://goo.gl/maps/mj5md"><asp:Image Tooltip="4250 6th Street South St. Petersburg, Florida" runat="server" ImageUrl="~/assets/img/ui/map.gif" /></a>
        </div>
    </div>
</asp:Content>
