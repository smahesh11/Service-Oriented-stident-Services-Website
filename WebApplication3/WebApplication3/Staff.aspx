<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="WebApplication3.Staff" %>
<%@ Register src="~/Quotes1.ascx" tagname="Quotes1" tagprefix="uc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
           <uc1:Quotes1  ID="Quotes1" runat="server"/>
    <div>
     <p>Hi. This is Staff Page</p>
    </div>
    </form>
</body>
</html>
