<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewRegistration.aspx.cs" Inherits="ASPLogin.NewRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; NEW STUDENT REGISTRATION<br />
            <br />
            FirstName -
            <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            LastName -
            <asp:TextBox ID="LastName" runat="server"></asp:TextBox>
            <br />
            <br />
            Password -
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            Mobile - <asp:TextBox ID="Mobile" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="REGISTER" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
