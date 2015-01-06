<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SSNdetails.aspx.cs" Inherits="WebApplication3.SSNdetails" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
</script>


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
    <form id="form2" runat="server">
        <div>
            <span class="auto-style1"><strong>Student SSN Number </strong></span>
            <br />
            <br />
            <strong>Enter SSN in the below mentioned format:<br />
            Eg: 1234&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 56789<br />
            </strong>First 4 digits of SSN&nbsp;&nbsp;&nbsp; Last 5 digits of SSN<br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="194px"></asp:TextBox>
            &nbsp;<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="196px"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Submit (Encrypt)" />
            <br />
            Secret SSN code -&nbsp; <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <strong>Enter your Secret SSN code as per the generated format in the fields below:
            <br />
            Eg: 875770417&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 943142453<br />
            </strong>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            &nbsp;-
            <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" Text="Get SSN (Decrypt)" />
            <br />
            <br />
            SSN generated from Secret code -
            <asp:Label ID="Label4" runat="server"></asp:Label>
        &nbsp;</div>
    </form>
</body>
</html>
