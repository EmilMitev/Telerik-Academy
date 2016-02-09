<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStudent.aspx.cs" Inherits="RegisterForm.RegisterStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" visible="true" runat="server">
        <div>
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name:"></asp:Label>&nbsp;
            <asp:TextBox ID="TextBoxFirstName" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name:"></asp:Label>&nbsp;
            <asp:TextBox ID="TextBoxLastName" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelFacNumber" runat="server" Text="Faculty №:"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="TextBoxFacNumber" runat="server" Width="140px"></asp:TextBox>
            <br />
            <asp:Label ID="LabelUniversity" runat="server" Text="University:"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListUniversity" runat="server" Width="140px">
                <asp:ListItem>Technical University</asp:ListItem>
                <asp:ListItem>Sofia University</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelSpecialty" runat="server" Text="Specialty:"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownListSpecialty" runat="server" Width="140px">
                <asp:ListItem>KST</asp:ListItem>
                <asp:ListItem>Software engineer</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="LabelCourses" runat="server" Text="Courses:"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxListCourses" runat="server">
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>HTML</asp:ListItem>
                <asp:ListItem>JS</asp:ListItem>
                <asp:ListItem>CSS</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        </div>
    </form>
    <form id="form2" visible="false" runat="server">
        <div>
            <asp:Button ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click" />
        </div>
    </form>
</body>
</html>
