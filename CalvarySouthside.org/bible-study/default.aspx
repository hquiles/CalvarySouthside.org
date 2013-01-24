<%@ Page Title="Bible Study" Language="C#" MasterPageFile="~/assets/master-pages/main.master"
    AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="bible_study_default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2>
        <span>Bible Study</span></h2>
    <p>
        Men's and Ladies' Bible Studies 1st and 3rd Thursday, 7 p.m. - Ladies' Bible Study
    </p>
    <p>
        2nd and 4th Thursday, 7 p.m., Men's Bible Study
    </p>
    <p>
        Bible studies meet at the church to discuss the previous week's Sunday message,
        pray and get to know one another.
    </p>

    <asp:ListView runat="server" ID="lvBibleStudy" ItemPlaceholderID="lvBibleStudyPlaceHolder" Visible="false">
        <LayoutTemplate>
            <ul>
                <asp:PlaceHolder runat="server" ID="lvBibleStudyPlaceHolder" />
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <%# Eval("Date") %>
                <%# Eval("Scripture") %>
                <%# Eval("Description") %>
                <%# Eval("Hyperlink") %>
            </li>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
