<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCar.aspx.cs" Inherits="Cars.SearchCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Cars</title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:Label ID="LabelProducer" Text="Producer:" runat="server" />
            <asp:DropDownList ID="DropDownListProducer" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownListProducer_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <asp:Label ID="LabelModel" Text="Model:" runat="server" />
            <asp:DropDownList ID="DropDownListModel" runat="server" AutoPostBack="true"></asp:DropDownList>
            <br />
            <asp:Label ID="LabelTypeOfEngine" Text="Type of engine:" runat="server" />
            <asp:RadioButtonList ID="RadioButtonListTypeOfEngine" runat="server"></asp:RadioButtonList>
            <br />
            <asp:Label ID="LabelExtra" Text="Extra:" runat="server" />
            <asp:CheckBoxList ID="CheckBoxListSetOfExtras" runat="server"></asp:CheckBoxList>
            <br /> 
            <asp:Button ID="ButtonSearch"  Text="Search" runat="server" OnClick="ButtonSearch_Click" />
            <asp:Literal ID="LiteralResult" runat="server" />
        </div>
    </form>
</body>
</html>
