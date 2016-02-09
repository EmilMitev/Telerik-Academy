<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeesGrid.aspx.cs" Inherits="Employees.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:GridView ID="GridView"
                runat="server"
                SelectMethod="GridViewEmployees_GetData"
                AllowPaging="True"
                AllowSorting="True"
                DataKeyNames="EmployeeID"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="First name" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="Last name" SortExpression="LastName" />
                    <asp:BoundField DataField="HireDate" HeaderText="Hire date" SortExpression="HireDate" />
                    <asp:HyperLinkField Text="View details" DataNavigateUrlFields="EmployeeID" DataNavigateUrlFormatString="EmployeeViewDetails.aspx?id={0}" />
                </Columns>
            </asp:GridView>
        </div>

    </form>
</body>
</html>
