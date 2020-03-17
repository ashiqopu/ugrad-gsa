<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cost.aspx.cs" Inherits="Cost" %>

<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Cost</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <meta charset="UTF-8"/>
  <link rel="stylesheet" type="text/css" href="css/style.css" />
  <script type="text/javascript" src="js/modernizr-1.5.min.js"></script>
  <script type="text/javascript" src="js/chkvalrestrict.js"></script>

    <style type="text/css">
        #Reset1 {
            text-align: right;
        }
        #ButtonReset {
            width: 45px;
        }
        .auto-style5 {
            width: 642px;
            height: 45px;
        }
        .auto-style22 {
            text-align: center;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
  <div id="main">		

    <header>
	  <div id="strapline">
	    <div id="welcome_slogan">
	      <h3>Welcome To <span>FS</span></h3>
	    </div>
      </div>		  
	  <nav>
	    <div id="menubar">
          <ul id="nav">
            <li><a href="Usage.aspx">Usage</a></li>
            <li><a href="Stock.aspx">Stock</a></li>
            <li class="current"><a href="Cost.aspx">Cost</a></li>
            <li><a href="Edit.aspx">Edit</a></li>
            <li><a href="Feedback.aspx">Feedback</a></li>
            <li><a Target="_blank" href="outline/report.aspx">Report</a></li>
            <li><a href="Logout.aspx">Logout</a></li>
          </ul>
        </div>
      </nav>
    </header>
    
	<div id="site_content">		  
           
	  <div id="content">
        <div class="content_item">

         <h1>&nbsp;</h1>
        <h1># Update Price : </h1> 
        <table class="auto-style5" align="center">
            <tr>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Select Item :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Price (Tk.):</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">To Update :</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:DropDownList ID="ddlCost" runat="server" AutoPostBack="True" DataSourceID="SqldsCost" DataTextField="Items" DataValueField="Items" OnSelectedIndexChanged="ddlCost_SelectedIndexChanged"></asp:DropDownList>
                    <asp:SqlDataSource ID="SqldsCost" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items FROM details"></asp:SqlDataSource>
                </td>
                <td class="auto-style22">
                        <asp:TextBox ID="TextBoxCost" runat="server" onkeypress="validate(event)" Width="92px" Height="23px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="TextBoxCost" ErrorMessage="RegularExpressionValidator" ValidationExpression="([.][0-9]+)|([0-9]+([.][0-9]+)?)" ForeColor="Red" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Large">?</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bUpdateCost" runat="server" Text="Update" Width="92px" Height="23px" OnClick="bUpdateCost_Click" />
                </td>
            </tr>
        </table>

		<h1>&nbsp;</h1>
        <h1># Daily Cost : </h1>             
        <h1>&nbsp;</h1>
            <asp:GridView ID="gvCost" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Height="325px" Width="898px" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="sqldsDaillyCost">
                <Columns>
                    <asp:BoundField DataField="Items" HeaderText="Items" SortExpression="Items" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="Dates" HeaderText="Dates" SortExpression="Dates" />
                    <asp:BoundField DataField="Times" HeaderText="Times" SortExpression="Times" />
                </Columns>
                <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#003399" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="sqldsDaillyCost" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items, Amount, Dates, Times FROM othersCost ORDER BY Serial DESC"></asp:SqlDataSource>
        </div>
      </div>  
	</div>	

    <footer>
	  <a href="Default.aspx">Home</a> | <a href="Info.aspx">Info</a> | <a href="Contact.aspx">Contact</a><br/><br/>
	  &nbsp;<a> @ All Right Reserved | 2014 - 2014</a>
    </footer>
	
  </div>
  
  <!-- javascript at the bottom for fast page loading -->
  <script type="text/javascript" src="js/jquery.min.js"></script>
  <script type="text/javascript" src="js/image_slide.js"></script>
  
    </form>
  
</body>
</html>


