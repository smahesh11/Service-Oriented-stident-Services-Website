<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication3.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <center>   
        <h1>
        Welcome to Student Services</h1>
     
 
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            To go to Default page-
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Click Here</asp:LinkButton>
        </p>
        <p>
            To go to Login page-&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Click Here</asp:LinkButton>
        </p>
        <p>
            &nbsp;</p>
           </center>
    </form>
 
</body>
</html>