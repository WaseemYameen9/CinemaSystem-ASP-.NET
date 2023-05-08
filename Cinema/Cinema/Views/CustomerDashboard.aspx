<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerDashboard.aspx.cs" Inherits="Cinema.Views.CustomerDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <style type="text/css">

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
.btn{
	margin-top:60px;
	background-color: #007bff;
	border-color: #007bff;
	color: #fff;
	padding: 5px 10px;
	border-radius: 5px;
	font-size: 18px;
}
.btn1-css{
	margin-left:500px;
}
/* Set font and background color for the entire table */
#Gridview1 {
  font-family: Arial, sans-serif;
  border-collapse: collapse;
  background-color: #f8f8f8;
  width: 100%; /* Set table width to 100% */
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
.auto-style22 {
	width: 100%;
	height: 350px;
}

</style>
</head>
<body>
    <header>
        <h1>Cinema System</h1>
     </header>
	
    <form id="form1" runat="server">
		<asp:Button ID="BookingsBtn" runat="server" Text="View Bookings" CssClass="btn1-css btn btnn" OnClick="ViewBookingsBtn_Click"  />
        <table class="auto-style22">
			<tr>
				<td class="auto-style16">Movie Name:</td>
				<td class="auto-style17">
					<input id="Nametxt" class="auto-style21" type="text" runat="server"/></td>
				<td class="auto-style18"></td>
			</tr>
            <tr>
				<td class="auto-style16">Number of Seats:</td>
				<td class="auto-style17">
					<input id="NoOfSeatsTxt" class="auto-style21" type="text" runat="server"/></td>
				<td class="auto-style18"></td>
			</tr>
            </table>
        <asp:Button ID="AddBtn" runat="server" Text="Book" CssClass="btn1-css btn" OnClick="AddBtn_Click"  />
         <asp:GridView ID="Gridview1" runat="server"  OnRowCommand="Gridview1_RowCommand" >
		<Columns>
        <asp:ButtonField ButtonType="Button" CommandName="CellClick" Text="Select" />
        </columns>
			</asp:GridView>
    </form>
    

</body>
</html>
