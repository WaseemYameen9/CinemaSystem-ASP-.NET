<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginaspx.aspx.cs" Inherits="Cinema.Views.Loginaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style type="text/css">
.auto-style1 {
	width: 100%;
	height: 242px;
}
.auto-style2 {
	width: 608px;
}
.auto-style3 {
	width: 456px;
}
.auto-style4 {
	width: 335px;
	height: 30px;
}
.auto-style5 {
	width: 327px;
	height: 30px;
}
.button-container {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
}

.btn-login {
  background-color: #007bff;
  border-color: #007bff;
  color: #fff;
  padding: 10px 20px;
  border-radius: 5px;
  font-size: 16px;
  text-align: center;
  margin: 10px 0;
}


</style>
</head>
<body>
    <form id="form1" runat="server">
    <p style="font-family: Garamond; font-size: 42px; font-weight: bold">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Page</p>
	<table class="auto-style1">
		<tr>
			<td class="auto-style2" colspan="1" style="font-family: Garamond">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Username:</td>
			<td class="auto-style3">
				<input id="emailTxt" runat="server" name="emailtxt" class="auto-style4" type="text" /></td>
			<td>&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style2" style="font-family: Garamond">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Enter Password:</td>
			<td class="auto-style3">
				<input id="passwordTxt"  runat="server" class="auto-style5" type="text" /></td>
			<td>&nbsp;</td>
		</tr>
		</table>
		<div class="button-container">
		<asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn-login" OnClick="btnLogin_Click" />
		<asp:Button ID="Button2" runat="server" Text="Sign Up" CssClass="btn-login" OnClick="SignUpBtn_Click"/>
		</div>
	</form>
</body>
</html>
