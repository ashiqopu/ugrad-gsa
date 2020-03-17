<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Info.aspx.cs" Inherits="Info" %>
<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Info</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <meta charset="UTF-8"/>
  <link rel="stylesheet" type="text/css" href="css/style.css" />
  <script type="text/javascript" src="js/modernizr-1.5.min.js"></script>
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
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="Login.aspx">Login</a></li>
            <li class="current"><a href="Info.aspx">Info</a></li>
            <li><a href="Contact.aspx">Contact Us</a></li>
          </ul>
        </div>
      </nav>
    </header>
    
	<div id="site_content">		
	  
	  <div class="sidebar_container">       
		<div class="sidebar">
          <div class="sidebar_item">
            <h2>New Website</h2>
            <p>Welcome to our Website. Please have a look around, any 'Feedback' is much appreciated.</p>
          </div>
        </div>   		
		<div class="sidebar">
          <div class="sidebar_item">
            <h2>Latest Update</h2>
            <h3><strong>March 12, 2014</strong></h3>
            <p>Eicher M/F & Eicher B/F are available now.</p>         
		  </div> 
        </div>
		<div class="sidebar">
          <div class="sidebar_item">
            <h2></h2>
            <h3><strong>January 28, 2014</strong></h3>
            <p>Currently cheque payment method is not available , soon we will add it into our payment method.</p>         
		  </div> 
        </div>  		
        <div class="sidebar">
          <div class="sidebar_item">
             <h2></h2>
            <h2>Contact</h2>
            <p><b>Phone: +88 (0)1234 56789
            Email: </b> <a href="mailto:info@email.fs.bd">info@email.fs.bd</a></p>
          </div>
        </div>
       </div>	

      <div class="slideshow">
	    <ul class="slideshow">
          <li class="show"><img width="680" height="250" src="images/home_1.jpg" alt="Caption : 01" /></li>
          <li><img width="680" height="250" src="images/home_2.jpg" alt="Caption : 02" /></li>
        </ul> 
	  </div>
	   
	  <div id="content">
        <div class="content_item">
		  <h1>&nbsp;</h1> 
		   </br>
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
