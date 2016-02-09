<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeViewDetails.aspx.cs" Inherits="Employees.EditEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:DetailsView ID="DetailsViewEmployee" runat="server"></asp:DetailsView>
            <asp:Button ID="ButtonBack" Text="Back" runat="server" OnClick="ButtonBack_Click" />
        </div>
    </form>
</body>
</html>
