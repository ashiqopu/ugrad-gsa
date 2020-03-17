
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="daily.aspx.cs" Inherits="daily" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>
<%@ Import Namespace="System.Drawing" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Daily Report</title>
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
        
        <h1> &nbsp; Select Date :
            <asp:ToolkitScriptManager ID="ScriptManagerC" runat="server"></asp:ToolkitScriptManager>
              <asp:TextBox ID="TextBox1" runat="server" Height="29px" style="margin-left: 52px" Width="141px" ></asp:TextBox>
              <asp:ImageButton ID="ImageButtonC1" ImageUrl="../images/calendar.png" ImageAlign="Bottom" runat="server" />
              <asp:CalendarExtender ID="CalendarExtenderC1" PopupButtonID="ImageButtonC1" runat="server" TargetControlID="TextBox1" Format="yyyy-MM-dd"></asp:CalendarExtender>
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Height="32px" OnClick="Button1_Click" Text="Show " Width="82px" />
            &nbsp;&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Height="32px" Text="Back" Width="82px" OnClick="Button2_Click" />
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
