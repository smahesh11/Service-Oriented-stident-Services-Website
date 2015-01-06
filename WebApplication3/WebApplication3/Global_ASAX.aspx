<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Global_ASAX.aspx.cs" Inherits="WebApplication3.Global_ASAX" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <strong>Student Login</strong><br />
        <br />
        ASU ID&nbsp;&nbsp; :
        <asp:TextBox ID="TextBox1" runat="server" Width="266px"></asp:TextBox>
        &nbsp;(1207250300)<br />
        <br />
        Password:
        <asp:TextBox ID="TextBox2" runat="server" Width="268px"></asp:TextBox>
        &nbsp;(password)<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign In" />
    
    </div>
    </form>
</body>
</html>
