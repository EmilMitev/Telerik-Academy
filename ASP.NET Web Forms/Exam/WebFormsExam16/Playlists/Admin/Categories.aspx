<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Playlists.Admin.Categories" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Categoies</h1>
    <asp:ListView ID="ListViewCategory" runat="server"
        DataKeyNames="Id"
        ItemType="Playlists.Models.Category"
        SelectMethod="ListViewCategory_GetData"
        UpdateMethod="ListViewCategory_UpdateItem"
        InsertMethod="ListViewCategory_InsertItem"
        InsertItemPosition="None">
        <LayoutTemplate>
            <div class="row">
                <asp:LinkButton runat="server" CssClass="btn btn-default" ID="ButtonSortbyName" Text="Sort by Name" CommandName="Sort" CommandArgument="Name" />
            </div>
            <div class="row" id="itemPlaceholder" runat="server"></div>
            <br />
            <asp:DataPager runat="server" PageSize="5">
                <Fields>
                    <asp:NextPreviousPagerField ShowPreviousPageButton="true" ShowNextPageButton="false" ButtonCssClass="btn btn-success" />
                    <asp:NumericPagerField />
                    <asp:NextPreviousPagerField ShowPreviousPageButton="false" ShowNextPageButton="true" ButtonCssClass="btn btn-success" />
                </Fields>
            </asp:DataPager>
            <asp:Button Text="Insert new category" runat="server" OnClick="ShowInsert_Click" CssClass="btn btn-info pull-right" />
        </LayoutTemplate>
        <ItemTemplate>
            <div class="row">
                <div class="col-md-3"><%#: Item.Id %></div>
                <div class="col-md-3"><%#: Item.Name %></div>
                <div class="col-md-3"><%#: Item.Playlists.Count %></div>
                <asp:Button Text="Edit" CommandName="Edit" runat="server" CssClass="btn btn-info" />
            </div>
        </ItemTemplate>
        <InsertItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox Text="<%# BindItem.Name %>" ID="TextBoxInsertCategory" runat="server" />
                </div>
                <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
                <asp:Button Text="Cancel" CommandName="Cancel" runat="server" CssClass="btn btn-danger" />
            </div>
        </InsertItemTemplate>
        <EditItemTemplate>
            <div class="row">
                <div class="col-md-3">
                    <asp:TextBox Text="<%# BindItem.Name %>" ID="TextBoxInsertCategory" runat="server" />
                    <asp:RequiredFieldValidator ErrorMessage="You cannot post an empty category!" ControlToValidate="TextBoxInsertCategory" runat="server" />
                </div>
                <asp:Button Text="Save" CommandName="Update" runat="server" CssClass="btn btn-success" />
                <asp:Button Text="Cancel" CommandName="Cancel" runat="server" CssClass="btn btn-danger" />
            </div>
        </EditItemTemplate>
    </asp:ListView>
</asp:Content>
