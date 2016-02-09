<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Playlists.Account.Manage" %>

<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>

    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <div>
                    <h4>Profile page</h4>
                    <asp:ListView ID="ListViewProfile" runat="server"
                        DataKeyNames="Id"
                        ItemType="Playlists.Models.User"
                        SelectMethod="ListViewProfile_GetData"
                        UpdateMethod="ListViewProfile_UpdateItem"
                        InsertItemPosition="None">
                        <LayoutTemplate>
                            <div class="container">
                                <div class="col-xs-12 col-sm-6 col-md-6">
                                    <div class="well well-sm">
                                        <div class="row">
                                            <div class="row" id="itemPlaceholder" runat="server"></div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="col-sm-6 col-md-4">
                                <img src="<%#: Item.ImageUrl %>" alt="" class="img-rounded img-responsive" />
                            </div>
                            <div class="col-sm-6 col-md-8">
                                <h4><%#: Item.FirstName %></h4>
                                <p>
                                    <i class="glyphicon glyphicon-envelope"></i>Email: <%#: Item.Email %>
                                    <br />
                                    <i class="glyphicon glyphicon-globe"></i>Facebook: <%#: Item.FacebookUrl %>
                                    <br />
                                    <i class="glyphicon glyphicon-globe"></i>Youtube: <%#: Item.YouTubeUrl %>
                                </p>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>


                    <h4>Change your account settings</h4>
                    <hr />
                    <dl class="dl-horizontal">
                        <dt>Password:</dt>
                        <dd>
                            <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                            <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                        </dd>
                        <dt>External Logins:</dt>
                        <dd><%: LoginsCount %>
                            <asp:HyperLink NavigateUrl="/Account/ManageLogins" Text="[Manage]" runat="server" />

                        </dd>
                        <dt>Two-Factor Authentication:</dt>
                        <dd>
                            <p>
                                There are no two-factor authentication providers configured. See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                                for details on setting up this ASP.NET application to support two-factor authentication.
                            </p>
                            <% if (TwoFactorEnabled)
                                { %>
                            <%--
                        Enabled
                        <asp:LinkButton Text="[Disable]" runat="server" CommandArgument="false" OnClick="TwoFactorDisable_Click" />
                            --%>
                            <% }
                                else
                                { %>
                            <%--
                        Disabled
                        <asp:LinkButton Text="[Enable]" CommandArgument="true" OnClick="TwoFactorEnable_Click" runat="server" />
                            --%>
                            <% } %>
                        </dd>
                    </dl>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
