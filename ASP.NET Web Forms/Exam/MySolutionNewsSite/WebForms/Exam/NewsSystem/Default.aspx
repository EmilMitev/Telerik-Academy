<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NewsSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--Most popular Articles--%>
    <div>
        <h1>News </h1>
        <h2>Most popular articles </h2>
        <asp:Repeater ID="RepeaterHomeArticles"
            runat="server"
            SelectMethod="RepeaterHomeArticles_GetData"
            ItemType="NewsSystem.Models.Article">
            <ItemTemplate>
                <div class="row">
                    <h3>
                        <a href="ViewArticle.aspx?id=<%# Item.Id %>"><%#: Item.Title %></a>
                        <small><%#: Item.Category.Name %></small>
                    </h3>
                    <p> <%#: Item.Content.Length >= 300 ? Item.Content.Substring(0, 300) + "..." : Item.Content%></p>
                    <p>Likes: <%#: Item.Likes.Count %></p>
                    <div>
                        <i><%#: Item.Author.Email %></i>
                        <i>created on: <%#: Item.DateCreated %></i>
                    </div>
                </div>
                <br />
            </ItemTemplate>
        </asp:Repeater>
    </div>

    <h2>All category</h2>
    <div class="row">
        <asp:Repeater ID="RepeaterAllCategories" runat="server"
            SelectMethod="RepeaterAllCategories_GetData"
            ItemType="NewsSystem.Models.Category">
            <ItemTemplate>
                <div class="col-md-6">
                    <h3><%#: Item.Name %></h3>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
