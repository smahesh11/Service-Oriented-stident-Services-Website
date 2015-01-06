<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="WebApplication3.Courses" %>

<%@ Register TagPrefix = "cse" TagName="semester" 
			src="WebUserControl2.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-decoration: underline;
        }
    </style>
</head>
    <body>
        <form id="Form2" runat = "server">
			<p>
                <span class="auto-style1"><strong>Student Courses List this Semester</strong></span><asp:Calendar ID="Calendar1" runat="server" Height="16px" SelectedDate="11/22/2014 15:03:01" VisibleDate="2014-11-22" Width="16px"></asp:Calendar>
            </p>
            <p>
                &nbsp;</p>
&nbsp;<cse:semester runat = "server" />
		</form>
	</body>

    
</html>
