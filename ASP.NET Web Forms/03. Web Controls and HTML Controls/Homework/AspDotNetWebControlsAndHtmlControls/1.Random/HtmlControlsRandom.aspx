<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlControlsRandom.aspx.cs" Inherits="RandomExercise.HtmlControlsRandom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            Min: <input id="TextMin" runat="server" type="number" />
            <br />
            Max:<input id="TextMax"  runat="server" type="number" />
            <br />
            <input id="ButtonGenerate" type="button" onserverclick="ButtonGenerate_ServerClick" runat="server" value="Generate" />
            <br />
            <span id="LabelRandom" runat="server"></span>
        </div>
    </form>
</body>
</html>
