<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Stock.aspx.cs" Inherits="Stock" %>

<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Stock</title>
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
            width: 100%;
        }
        .auto-style6 {
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
            <li class="current"><a href="Stock.aspx">Stock</a></li>
            <li><a href="Cost.aspx">Cost</a></li>
            <li><a href="Edit.aspx">Edit</a></li>
            <li><a href="Feedback.aspx">Feedback</a></li>
            <li><a target="_blank" href="outline/report.aspx">Report</a></li>
            <li><a href="Logout.aspx">Logout</a></li>
          </ul>
        </div>
      </nav>
    </header>
    
	<div id="site_content">		
	  
	  <div id="content">
        <div class="content_item">

		<h1># Stock Details : </h1>		 
        <table class="auto-style5">
            <tr>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style6">Select Item   :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style6">Available (Lt.):</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:DropDownList ID="ddlItem" runat="server" AutoPostBack="True" DataSourceID="sqldsItem" DataTextField="Items" DataValueField="Items" Width="162px" Height="23px" OnSelectedIndexChanged="ddlItem_SelectedIndexChanged"></asp:DropDownList>
                    <asp:SqlDataSource ID="sqldsItem" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items FROM details"></asp:SqlDataSource>
                </td>
                <td class="auto-style6">
                        <asp:TextBox ID="tbQuantity" runat="server" Width="108px" Height="21px" Enabled="False" ></asp:TextBox>
                </td>
            </tr>
        </table>

        <h1>&nbsp;</h1>
        <h1># UpLoad Details : </h1>
        <h1>&nbsp;</h1>

            <asp:GridView ID="gvStock" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="sqldsStock" Height="362px" Width="899px">
                <Columns>
                    <asp:BoundField DataField="Items" HeaderText="Items" SortExpression="Items" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="Dates" HeaderText="Dates" SortExpression="Dates" />
                    <asp:BoundField DataField="Times" HeaderText="Times" SortExpression="Times" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="sqldsStock" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items, Quantity, Amount, Dates, Times FROM daillyCost ORDER BY Serial DESC"></asp:SqlDataSource>
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



