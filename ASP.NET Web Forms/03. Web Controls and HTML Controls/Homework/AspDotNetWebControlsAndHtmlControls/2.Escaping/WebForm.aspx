<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="EscapingExercise.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextInput" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="ButtonConvert" runat="server" Text="Convert" OnClick="ButtonConvert_Click" />
            <br />
            <asp:TextBox ID="TextOutput" Mode="Encode" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="LabelOutput" Mode="Encode" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
