<%@ Page Title="" Language="C#" MasterPageFile="~/assets/master-pages/main.master"
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="about_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2><span>About Us</span></h2>

    <p>
        Calvary Chapel Southside is a non-denominational, come as you are ministry located
        on the south side of St Petersburg, FL. We have a mission to reach the surrounding
        area with the love of Christ. We offer full band, contemporary praise and worship
        music and an energetic message from God's Holy Word. Please come join us on Sunday
        nights at 6 p.m., and bring a friend.
    </p>
    <p>
        Our Shepherd Doug Dodge
    </p>
    <p>
        <asp:Image runat="server" ImageUrl="~/assets/images/photos/oldsite/191_dougbecky.jpg" />
        Pastor Doug and his wife Becky
    </p>
    Board of Elders
    <ul>
        <li>Doug Dodge</li>
        <li>Jim McFall</li>
        <li>Larry Kaser</li>
        <li>Ben Schantz</li>
        <li>Tim Wolter</li>
    </ul>
</asp:Content>
