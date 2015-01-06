<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>



<%@ Register TagPrefix = "cse" TagName="semester" 
			src="WebUserControl1.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>User Control</title> </head>
<body>
	<h2>Building names in ASU for new students</h2>
		<form id="Form1" runat = "server">
			<cse:semester runat = "server" />
		</form>
	</body>
</html>

