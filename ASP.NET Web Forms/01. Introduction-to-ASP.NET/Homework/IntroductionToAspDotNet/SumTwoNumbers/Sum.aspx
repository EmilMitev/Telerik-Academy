<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sum.aspx.cs" Inherits="SumTwoNumbers.Sum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Text1" runat="server" type="number" />
        +
        <input id="Text2" runat="server" type="number" />
        <asp:Button ID="Button" runat="server" Text="=" OnClick="Button_Click" />
        <asp:Label ID="LabelResult" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
