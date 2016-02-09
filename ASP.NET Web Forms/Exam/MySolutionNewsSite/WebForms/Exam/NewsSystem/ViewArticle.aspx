<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="NewsSystem.ViewArticle" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewArticle"
        SelectMethod="FormViewArticle_GetItem"
        ItemType="NewsSystem.Models.Article" Width="669px">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <div>
                                <div class="like-control col-md-1">
                                    <div>Likes</div>
                                    <div>
                                        <asp:LinkButton ID="ButtonLike" runat="server" OnClick="ButtonLike_Click" CssClass="btn btn-default glyphicon glyphicon-chevron-up"></asp:LinkButton>
                                        <asp:Label ID="LabelLikeResult" CssClass="like-value" runat="server" Text="<%#: Item.Likes.Count %>"></asp:Label>
                                        <asp:LinkButton ID="ButtonDislike" runat="server" OnClick="ButtonDislike_Click" CssClass="btn btn-default glyphicon glyphicon-chevron-down"></asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
                            <p><%#: Item.Content %></p>
                            <p>
                                <span>Author: <%#: Item.Author.Email %></span>
                                <span class="pull-right"><%#: Item.DateCreated %></span>
                            </p>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
