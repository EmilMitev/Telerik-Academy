<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hello.aspx.cs" Inherits="SayHello.Hello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your name:
            <input id="Text" runat="server" type="text" />
            <br />
            <asp:Button ID="Button" runat="server" Text="Say hello" OnClick="Button_Click" />
            <br />
            <asp:Label ID="Label" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
