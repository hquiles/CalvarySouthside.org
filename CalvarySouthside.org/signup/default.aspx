<%@ Page Title="" Language="C#" MasterPageFile="~/assets/master-pages/main.master" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="signup_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2><span>Register</span></h2>

    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" Text="FirstName" runat="server" AssociatedControlID="txtFirstName" />
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
                <asp:Label Text="Join Mailing List" runat="server" AssociatedControlID="chkEmailList" />
            </td>
            <td>
                <asp:CheckBox runat="server" ID="chkEmailList" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Phone Number" runat="server" AssociatedControlID="txtPhoneNumber" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPhoneNumber" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Address" runat="server" AssociatedControlID="txtAddress1" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAddress1" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Apt / Suite" runat="server" AssociatedControlID="txtAddress2" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtAddress2" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="City" runat="server" AssociatedControlID="txtCity" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtCity" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="State" runat="server" AssociatedControlID="txtState" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtState" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label Text="Zip" runat="server" AssociatedControlID="txtZip" />
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtZip" />
            </td>
        </tr>
    </table>

    <asp:Button runat="server" OnClick="SubmitRegistration" Text="Submit" />
</asp:Content>

