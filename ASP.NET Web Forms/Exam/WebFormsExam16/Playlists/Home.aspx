<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Playlists.Home" %>
<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        <asp:ListView runat="server" 
            ID="ListViewPopularPlaylists" ItemType="Playlists.Models.Playlist" SelectMethod="ListViewPopularPlaylists_GetData">
        <LayoutTemplate>
            <h2>Most popular playlists</h2>
            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
        </LayoutTemplate>
        <ItemTemplate>
            <ItemTemplate>
            <div class="row">
                <h3><asp:hyperlink navigateurl='<%# "~/Playlistdetails?id=" + Item.Id %>' runat="server" Text="<%#: Item.Title %>" /> <small><%#: Item.Category.Name %></small></h3>
                <p>
                    <%# Item.Description.Length > 300 ? Item.Description.Substring(0, 300) + "..." : Item.Description  %>
                </p>
                <p>Rating: <%#: Item.RatingValue%></p>
                <div>
                    <i>by <%#: Item.Author.UserName ?? "" %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
        </ItemTemplate>
    </asp:ListView>
    </div>
</asp:Content>
