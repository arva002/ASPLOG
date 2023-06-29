<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPLogin.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; STUDENT LOGIN<br />
        <br />
        UserName:<asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
&nbsp;<div>
            Password:<asp:TextBox TextMode="Password" ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="messagelbl" runat="server" Text="Label" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Login" Width="212px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="New Registration" OnClick="Button2_Click" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
