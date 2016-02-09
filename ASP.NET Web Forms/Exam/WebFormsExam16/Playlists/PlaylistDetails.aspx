<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PlaylistDetails.aspx.cs" Inherits="Playlists.PlaylistDetails" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="FormViewPlaylist" ItemType="Playlists.Models.Playlist" SelectMethod="FormViewPlaylist_GetItem">
        <ItemTemplate>
            <h2><%#: Item.Title %> <small>Category: <%#: Item.Category.Name %></small></h2>
            <p><%#: Item.Description %></p>
            <p>

                <asp:ListView runat="server" ID="ListViewVideos"
                    ItemType="Playlists.Models.Video"
                    DataKeyNames="Id"
                    SelectMethod="ListViewVideos_GetData"
                    InsertMethod="ListViewVideos_InsertItem"
                    UpdateMethod="ListViewVideos_UpdateItem"
                    DeleteMethod="ListViewVideos_DeleteItem"
                    InsertItemPosition="LastItem">
                    <LayoutTemplate>
                        <div class="row" runat="server" id="itemPlaceHolder"></div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <li>
                            <%# Item.Url %>
                        </li>
                        <asp:Button Text="Edit" CommandName="Edit" runat="server" CssClass="btn btn-info" />
                        <asp:Button Text="Delete" CommandName="Delete" runat="server" CssClass="btn btn-danger" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <li>
                            <%# Item.Url %>
                        </li>
                        <asp:LinkButton runat="server" ID="ButtonEdit" Text="Save" CssClass="btn btn-success" CommandName="Update" ValidationGroup="EditCategory" CausesValidation="true" />
                        <asp:LinkButton runat="server" ID="LinkButton1" Text="Cancel" CssClass="btn btn-danger" CommandName="Cancel" CausesValidation="false" />
                    </EditItemTemplate>
                    <InsertItemTemplate>
                        <a href="#" id="buttonShowInsertPanel" class="btn btn-info pull-right" onclick="(function (ev) { $('#panelInsertVideo').show(); $('#buttonShowInsertPanel').hide(); }())">Insert new video</a>
                        <div id="panelInsertVideo" style="display: none;">
                            <li>
                                <asp:TextBox runat="server" ID="TextBox1" Width="300" Text="<%#: BindItem.Url %>"></asp:TextBox>
                            </li>
                            <div>
                                <asp:LinkButton runat="server" ID="ButtonInsertPlaylist" CssClass="btn btn-success" CommandName="Insert" Text="Insert" CausesValidation="true" ValidationGroup="InsertPlaylist" />
                                <asp:LinkButton runat="server" ID="LinkButton1" CssClass="btn btn-danger" CommandName="Cancel" Text="Cancel" CausesValidation="false" />
                            </div>
                        </div>
                    </InsertItemTemplate>
                </asp:ListView>

            </p>
            <p>
                <span>Author: <%#: Item.Author.UserName %></span>
                <span class="pull-right"><%#: Item.DateCreated %></span>
            </p>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
