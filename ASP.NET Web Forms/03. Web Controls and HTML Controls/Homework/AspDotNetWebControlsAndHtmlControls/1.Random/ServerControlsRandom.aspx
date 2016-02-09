<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerControlsRandom.aspx.cs" Inherits="RandomExercise.WebServerRandom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            Min:<asp:TextBox ID="TextMin" runat="server"></asp:TextBox> 
            <br />
            Max:<asp:TextBox ID="TextMax" runat="server"></asp:TextBox> 
            <br />
            <asp:Button ID="ButtonGenerate" runat="server" Text="Generate" OnClick="ButtonGenerate_Click" />
            <br />
            <asp:Label ID="LabelRandom" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

