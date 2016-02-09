<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaylistsPage.aspx.cs" Inherits="Playlists.Private.PlaylistsPage" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView runat="server" ID="ListViewPlaylists"
        ItemType="Playlists.Models.Playlist"
        DataKeyNames="Id"
        SelectMethod="ListViewPlaylists_GetData"
        InsertMethod="ListViewPlaylists_InsertItem"
        UpdateMethod="ListViewPlaylists_UpdateItem"
        DeleteMethod="ListViewPlaylists_DeleteItem"
        InsertItemPosition="LastItem">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" ID="ButtonSortByTitle" CssClass="col-md-2 btn btn-default" Text="Sort by Title" CommandArgument="Title" CommandName="Sort" />
                <asp:LinkButton runat="server" ID="ButtonSortByDate" CssClass="col-md-2 btn btn-default" Text="Sort by Date" CommandArgument="DateCreated" CommandName="Sort" />
            </div>
            <div runat="server" id="itemPlaceHolder"></div>
            <div class="row">
                <asp:DataPager runat="server" ID="DataPagerPlaylists" PagedControlID="ListViewPlaylists" PageSize="10">
                    <Fields>
                        <asp:NextPreviousPagerField ShowNextPageButton="false" ShowPreviousPageButton="true" />
                        <asp:NumericPagerField />
                        <asp:NextPreviousPagerField ShowNextPageButton="true" ShowPreviousPageButton="false" />
                    </Fields>
                </asp:DataPager>
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <h3><a href="../PlaylistDetails.aspx?id=<%#: Item.Id %>"><%#: Item.Title %></a>
                </h3>
                <p>Category: <%#: Item.Category.Name %></p>
                <p>
                    <%#: Item.Description.Length > 300 ? Item.Description.Substring(0, 300) + "..." : Item.Description  %>
                </p>
                <p>
                    <asp:ListView runat="server" 
                        ID="ListViewVideos" 
                        ItemType="Playlists.Models.Video" 
                        DataSource="<%# Item.Videos %>">
                        <LayoutTemplate>
                            <ul>
                                <li runat="server" id="itemPlaceHolder"></li>
                            </ul>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <li>
                                <%# Item.Url %>
                            </li>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            No videos.
                        </EmptyDataTemplate>
                    </asp:ListView>
                </p>
                <p>Rating: <%#: Item.RatingValue %></p>
                <div>
                    <i>by <%#: Item.Author.UserName ?? "" %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
        <InsertItemTemplate>
            <a href="#" id="buttonShowInsertPanel" class="btn btn-info pull-right" onclick="(function (ev) { $('#panelInsertArticle').show(); $('#buttonShowInsertPanel').hide(); }())">Insert new Article</a>
            <div id="panelInsertArticle" style="display: none;">

                <div class="row">
                    <h3>Title: 
                   
                        <asp:TextBox runat="server" ID="TextBoxInsertTitle" Width="300" Text="<%#: BindItem.Title %>"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Title is required!" ValidationGroup="InsertPlaylist" ControlToValidate="TextBoxInsertTitle" ForeColor="Red" runat="server" />
                    </h3>
                    <p>
                        Category: 
                   
                        <asp:DropDownList runat="server" ID="DropDownListCategories" ItemType="Playlists.Models.Category" DataTextField="Name" SelectedValue="<%#: BindItem.CategoryId %>" DataValueField="Id" SelectMethod="DropDownListCategories_GetData">
                        </asp:DropDownList>
                    </p>
                    <p>
                        Content: 
                   
                        <asp:TextBox runat="server" ID="TextBoxInsertDescription" Width="300" TextMode="MultiLine" Text="<%#: BindItem.Description %>" Rows="6"></asp:TextBox>
                        <asp:RequiredFieldValidator ErrorMessage="Description is Required!" ValidationGroup="InsertPlaylist" ControlToValidate="TextBoxInsertDescription" ForeColor="Red" runat="server" />
                    </p>
                    <div>
                        <asp:LinkButton runat="server" ID="ButtonInsertPlaylist" CssClass="btn btn-success" CommandName="Insert" Text="Insert" CausesValidation="true" ValidationGroup="InsertPlaylist" />
                        <asp:LinkButton runat="server" ID="LinkButton1" CssClass="btn btn-danger" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                    </div>
                </div>
            </div>
        </InsertItemTemplate>
    </asp:ListView>
</asp:Content>
