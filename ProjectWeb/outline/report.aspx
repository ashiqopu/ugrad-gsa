<%@ Page Language="C#" AutoEventWireup="true" CodeFile="report.aspx.cs" Inherits="report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Report</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <meta charset="UTF-8"/>
  <link rel="stylesheet" type="text/css" href="../css/style.css" />
  <script type="text/javascript" src="js/modernizr-1.5.min.js"></script>
    <style type="text/css">
        #Reset1 {
            text-align: right;
        }
        #ButtonReset {
            width: 45px;
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
            <li><a href="../Usage.aspx">Usage</a></li>
            <li><a href="../Stock.aspx">Stock</a></li>
            <li><a href="../Cost.aspx">Cost</a></li>
            <li><a href="../Edit.aspx">Edit</a></li>
            <li><a href="../Feedback.aspx">Feedback</a></li>
            <li class="current"><a href="report.aspx">Report</a></li>
            <li><a href="Logout.aspx">Logout</a></li>
          </ul>
        </div>
      </nav>
    </header>
   
      	<div id="site_content">		
	  
	  <div id="content">
        <div class="content_item">
		  <h1> &nbsp; </h1>
        
            <h1> &nbsp; Select :&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList_select_catagori" runat="server" Height="31px" Width="227px">
            <asp:ListItem>Catagory...</asp:ListItem>
            <asp:ListItem>Daily</asp:ListItem>
            <asp:ListItem>Between Two Date</asp:ListItem>
            <asp:ListItem>Monthly</asp:ListItem>
            <asp:ListItem>According To Plate No.</asp:ListItem>          
        </asp:DropDownList>
        <asp:Button ID="Button_ok" runat="server" OnClick="Button1_Click" style="margin-left: 122px" Text="Next" Height="33px" Width="93px" />
        <br />
        </h1> 
        </div>
		</div>
      </div>  

    <footer>
	  <a href="../Default.aspx">Home</a> | <a href="../Info.aspx">Info</a> | <a href="../Contact.aspx">Contact</a><br/><br/>
	  &nbsp;<a> @ All Right Reserved | 2014 - 2014</a>
    </footer>
	
  </div>
  
  <!-- javascript at the bottom for fast page loading -->
  <script type="text/javascript" src="js/jquery.min.js"></script>
  <script type="text/javascript" src="js/image_slide.js"></script>
  
    </form>
</body>
</html>
