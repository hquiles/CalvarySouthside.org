<%@ Page Language="C#" MasterPageFile="~/assets/master-pages/admin.master"
    AutoEventWireup="true" CodeFile="user-profile.aspx.cs" Inherits="Admin.UserProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphContent" runat="Server">

    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="First Name" AssociatedControlID="txtFirstName" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtFirstName" placeholder="First Name" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Last Name" AssociatedControlID="txtLastName" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtLastName" placeholder="Last Name" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Email Address" AssociatedControlID="txtEmailAddress" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtEmailAddress" placeholder="Email Address" />

                <label class="checkbox">
                    <asp:CheckBox runat="server" ID="chkEmailConfirmed" /> Confirmed
                </label>
                <label class="checkbox">
                    <asp:CheckBox runat="server" ID="chkMailingList" /> Mailing List
                </label>
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Phone Number" AssociatedControlID="txtPhoneNumber" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtPhoneNumber" placeholder="Phone Number" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Address" AssociatedControlID="txtAddress1" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtAddress1" placeholder="Address" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Apt / Suite" AssociatedControlID="txtAddress2" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtAddress2" placeholder="Apt / Suite" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="City" AssociatedControlID="txtCity" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtCity" placeholder="City" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="State" AssociatedControlID="txtState" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtState" placeholder="State" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Zip" AssociatedControlID="txtZip" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtZip" placeholder="Zip" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Password" AssociatedControlID="txtPassword" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:TextBox runat="server" ID="txtPassword" placeholder="Password" /><br />
                <asp:TextBox runat="server" ID="txtPasswordConfirm" placeholder="Confirm" style="margin-top:0.5em;" />
            </div>
        </div>
    </div>
    <div class="form-horizontal">
        <div class="control-group">
            <asp:Label Text="Admin" AssociatedControlID="chkAdmin" runat="server" CssClass="control-label" />
            <div class="controls">
                <asp:CheckBox runat="server" ID="chkAdmin" />
            </div>
        </div>
    </div>

    <div class="form-horizontal">
        <div class="control-group">
            <div class="controls">
                <asp:Button ID="btnSave" runat="server" CssClass="btn" Text="Save" OnClick="SaveUser" />
            </div>
        </div>
    </div>
    

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphFooter" runat="Server">
</asp:Content>
