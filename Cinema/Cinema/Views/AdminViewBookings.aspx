<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminViewBookings.aspx.cs" Inherits="Cinema.Views.AdminViewBookings" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

nav {
  background-color: black;
  padding: 10px;
}

ul {
  list-style: none;
  margin: 0;
  padding: 0;
  display: flex;
  justify-content: center;
}

li {
  margin: 0 20px;
}

a {
  text-decoration: none;
  color: white;
  font-weight: bold;
  font-size: 18px;
  transition: all 0.3s ease;
}

a:hover {
  color: #ffcc00;
}

@media (max-width: 768px) {
  li {
    margin: 0 10px;
  }
  a {
    font-size: 14px;
  }
}


.auto-style10 {
	width: 869px;
	right: 0px;
	height: 104px;
}
.auto-style11 {
	width: 949px;
	height: 104px;
}
.auto-style12 {
	height: 104px;
}
.auto-style13 {
	width: 869px;
	right: 0px;
	height: 81px;
}
.auto-style14 {
	width: 949px;
	height: 81px;
}
.auto-style15 {
	height: 81px;
}
.auto-style16 {
	width: 869px;
	right: 0px;
	height: 82px;
}
.auto-style17 {
	width: 949px;
	height: 82px;
}
.auto-style18 {
	height: 82px;
}
.auto-style20 {
	width: 341px;
	height: 30px;
}


.auto-style21 {
	width: 340px;
	height: 30px;
			
}
.btn{
	margin-top:60px;
	background-color: #007bff;
	border-color: #007bff;
	color: #fff;
	padding: 5px 10px;
	border-radius: 5px;
	font-size: 13px;
}
.btn1-css{
	margin-left:370px;
}
.btn2-css{
	margin-left:80px;
}
.btn3-css{
	margin-left:80px;
}
#Gridview1 {
	font-family: Arial, sans-serif;
	border-collapse: collapse;
	background-color: #f8f8f8;
	width: 100%; /* Set table width to 100% */
	margin-top:100px;
}
	/* Set font and background color for the table header */
#Gridview1 th {
	background-color: #006699;
	color: #fff;
	font-weight: bold;
	padding: 10px;
	text-align: left;
	border-bottom: 2px solid #ddd;
}
	/* Set font and background color for the table cells */
#Gridview1 td {
	padding: 8px;
	border-bottom: 1px solid #ddd;
}
/* Set background color for alternate rows */
#Gridview1 tr:nth-child(even) {
	background-color: #e6e6e6;
}

/* Set background color for table rows on mouse hover */
#Gridview1 tr:hover {
	background-color: #ddd;
}

	/* Remove fixed widths on the columns */
#Gridview1 td, #Gridview1 th {
	width: auto !important;
	max-width: none !important;
}



.auto-style22 {
	width: 100%;
	height: 350px;
}

header {
	 background-color: black;
	 padding: 10px;
}

h1 {
	color: white;
	font-size: 36px;
	margin: 0;
	text-align: center;
}
.btnn
{
	margin-left:1000px;
}

</style>
</head>
<body>
    <form id="form1" runat="server">
         <header>
			  <h1>Cinema System</h1>
		</header>
		<asp:Button ID="GoBack" runat="server" Text="Go Back" CssClass="btn1-css btn btnn" OnClick="GoBackBtn_Click"  />
        <asp:GridView ID="Gridview1" runat="server" >
			</asp:GridView>
    </form>
</body>
</html>
