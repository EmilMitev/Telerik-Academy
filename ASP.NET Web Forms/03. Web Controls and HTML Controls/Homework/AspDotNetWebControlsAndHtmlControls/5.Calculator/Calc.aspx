<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="Calculator.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 30%;">
                <tr>
                    <td colspan="4">
                        <input id="input" runat="server" type="number" style="width: 100%; text-align: right" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="id1" runat="server" Text="1" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id2" runat="server" Text="2" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id3" runat="server" Text="3" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="idPlus" runat="server" Text="+" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="id4" runat="server" Text="4" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id5" runat="server" Text="5" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id6" runat="server" Text="6" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="idMinus" runat="server" Text="-" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="id7" runat="server" Text="7" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id8" runat="server" Text="8" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id9" runat="server" Text="9" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="idMultiply" runat="server" Text="*" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="idClear" runat="server" Text="C" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="id0" runat="server" Text="0" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="idDevision" runat="server" Text="/" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                    <td>
                        <asp:Button ID="idSqrt" runat="server" Text="&radic;" OnClick="Button_Click" Style="width: 90%;" />
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button ID="Equals" runat="server" Text="=" OnClick="Button_Click" Style="width: 100%; vertical-align: central" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <asp:TextBox ID="idNumber" runat="server" Visible="false" Text="0"></asp:TextBox>
    <asp:TextBox ID="idSign" runat="server" Visible="false" Text=""></asp:TextBox>
</body>
</html>
