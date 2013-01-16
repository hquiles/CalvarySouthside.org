<%@ Page Title="Contact Us" Language="C#" MasterPageFile="~/assets/master-pages/main.master"
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="contact_default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>
        <span>Contact Us</span></h2>
    <p>
        Please join us at:
    </p>
    <p>
        4250 6th Street South St. Petersburg, Florida <a href="https://maps.google.com/maps?q=4250+6th+Street+South+St.+Petersburg,+Florida&hnear=4250+6th+St+S,+St+Petersburg,+Pinellas,+Florida+33705&gl=us&t=h&z=16">
            Map</a>
    </p>
    <p>
        Please contact us via e-mail at <a href="mailto:info@calvarysouthside.com">info@calvarysouthside.com</a> or at 727-593-4782
    </p>

    <asp:Label Text="First Name" runat="server" AssociatedControlID="txtFirstName" />
    <asp:TextBox runat="server" ID="txtFirstName" />

    <asp:Label Text="Last Name" runat="server" AssociatedControlID="txtLastName" />
    <asp:TextBox runat="server" ID="txtLastName" />

    <asp:Label Text="Email Address" runat="server" AssociatedControlID="txtEmailAddress" />
    <asp:TextBox runat="server" ID="txtEmailAddress" />

    <asp:Label Text="Message" runat="server" AssociatedControlID="txtMessage" />
    <asp:TextBox runat="server" ID="txtMessage" TextMode="MultiLine" />

    <asp:Button ID="Button1" runat="server" OnClick="SubmitForm" Text="Submit" CssClass="btn" />

</asp:Content>
