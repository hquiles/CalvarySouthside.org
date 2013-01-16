<%@ Page Title="Welcome" Language="C#" MasterPageFile="~/assets/master-pages/main.master"
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2><span>Welcome</span></h2>

    <div class="group">
        <div class="grid golden-short">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/assets/img/photos/oldsite/360_worship2.jpg" />
        </div>

        <div class="grid golden-long">
            <p>
                Calvary Chapel Southside is a non-denominational, come as you are ministry located
                on the south side of St Petersburg, Florida. We have a mission to reach the surrounding
                area with the love of Christ.
            </p>
            <p>
                We meet every Sunday at 6 p.m. and offer full band, contemporary praise and worship
                music and an message from God's Word. Childcare is provided through age 5. We are
                located at:
            </p>
            <p>
                4250 6th Street South St. Petersburg, Florida
            </p>
        </div>
    </div>

</asp:Content>
