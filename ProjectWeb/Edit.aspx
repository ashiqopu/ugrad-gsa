<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Edit" %>

<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Edit</title>
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
        .auto-style23 {
            text-align: center;
            height: 23px;
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
            <li><a href="Cost.aspx">Cost</a></li>
            <li class="current"><a href="Edit.aspx">Edit</a></li>
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
                    <asp:DropDownList ID="ddlPrice" runat="server" Width="162px" Height="23px"  OnSelectedIndexChanged="ddlPrice_SelectedIndexChanged" AutoPostBack="True" DataSourceID="sqldsPrice" DataTextField="Items" DataValueField="Items"></asp:DropDownList>
                    <asp:SqlDataSource ID="sqldsPrice" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items FROM details"></asp:SqlDataSource>
                </td>
                <td class="auto-style22">
                        <asp:TextBox ID="TextBoxPrice" runat="server" onkeypress="validate(event)" Width="92px" Height="23px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="TextBoxPrice" ErrorMessage="RegularExpressionValidator" ValidationExpression="([.][0-9]+)|([0-9]+([.][0-9]+)?)" ForeColor="Red" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Large">?</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bUpdatePrice" runat="server" Text="Update" Width="92px" Height="23px" OnClick="bUpdatePrice_Click" />
                </td>
            </tr>
        </table>

		<h1>&nbsp;</h1>

        <h1># Edit Salesman : </h1>
        <table class="auto-style5" align="center">
            <tr>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style23">Username :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style23">Password :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style23">To Update :</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:DropDownList ID="ddlSales" runat="server" Width="162px" Height="23px" DataSourceID="sqldsSales" DataTextField="Username" DataValueField="Username" OnSelectedIndexChanged="ddlSales_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                    <asp:SqlDataSource ID="sqldsSales" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Username FROM login WHERE (Type = 'salesman')"></asp:SqlDataSource>
                 </td>
                <td class="auto-style22">
                        <asp:TextBox ID="TextBoxPass" runat="server" Width="92px" Height="23px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bUpdateSales" runat="server" Text="Update" Width="92px" Height="23px" OnClick="bUpdateSales_Click" />
                </td>
            </tr>
        </table>

        <h1>&nbsp;</h1>

        <h1># Add Salesman : </h1>
        <table class="auto-style5" align="center">
            <tr>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Username :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Password :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">To Add :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style23">To Cancel :</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:TextBox ID="tbAddUser" runat="server" Width="162px" Height="23px"></asp:TextBox>
                 </td>
                <td class="auto-style22">
                    <asp:TextBox ID="tbAddPass" runat="server" Width="92px" Height="23px"></asp:TextBox>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bAddSales" runat="server" Text="Add" Width="92px" Height="23px" OnClick="bAddSales_Click" />
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bCancelSales" runat="server" Text="Cancel" Width="92px" Height="23px" onclientclick="return confirm('Do you really want to cancel your last updated record ?');" OnClick="bCancelSales_Click" />
                </td>
            </tr>
        </table>

        <h1>&nbsp;</h1>

        <h1># Add Items : </h1>	 
        <table class="auto-style5" align="center">
            <tr>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Item :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">Price (Tk.):</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style22">To Add :</td>
                <td style="font-size: large; color: #FFFFFF; " class="auto-style23">To Cancel :</td>
            </tr>
            <tr>
                <td class="auto-style22">
                    <asp:TextBox ID="tbAddItem" runat="server" Width="162px" Height="23px"></asp:TextBox>
                 </td>
                <td class="auto-style22">
                    <asp:TextBox ID="tbAddPrice" runat="server" Width="92px" Height="23px" onkeypress="validate(event)"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="revAddPrice" runat="server" ControlToValidate="tbAddPrice" ErrorMessage="RegularExpressionValidator" ValidationExpression="([.][0-9]+)|([0-9]+([.][0-9]+)?)" ForeColor="Red" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Large">?</asp:RegularExpressionValidator>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bAddItem" runat="server" Text="Add" Width="92px" Height="23px" OnClick="bAddItem_Click" />
                </td>
                <td class="auto-style22">
                    <asp:Button ID="bCancelItem" runat="server" Text="Cancel" Width="92px" Height="23px" onclientclick="return confirm('Do you really want to cancel your last updated record ?');" OnClick="bCancelItem_Click" />
                </td>
            </tr>
        </table>
        
        <h1>&nbsp;</h1>

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


