<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TTTGame.aspx.cs" Inherits="TicTacToe.TTTGame" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label" runat="server"></asp:Label>
            <table>
                <tr>
                    <td>
                        <asp:Button ID="id1" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id2" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id3" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="id4" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id5" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id6" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="id7" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id8" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                    <td>
                        <asp:Button ID="id9" runat="server" OnClick="Button_Click" Style="width: 100px; height: 100px;" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
