<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Home</title>
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
            <li class="current"><a href="Default.aspx">Home</a></li>
            <li><a href="Login.aspx">Login</a></li>
            <li><a href="Info.aspx">Info</a></li>
            <li><a href="Contact.aspx">Contact Us</a></li>
          </ul>
        </div>
      </nav>
    </header>
    
	<div id="site_content">		
	  
	  <div class="sidebar_container" style="font-family: 'Segoe UI'">       
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
	   
	  <div id="content" style="font-family: 'Segoe UI'; font-size: 12px">
        <div class="content_item">
          <h1>Welcome To Our Website ...</h1> 
		  <h3 style="font-family: 'Segoe UI'; font-size: 16px;"> 
                A filling station, fuelling station, garage, gasbar (Canada), gas station (United States and Canada), petrol bunk or petrol pump (India), petrol garage, petrol station (Australia, Hong Kong, Ireland, Malaysia, New Zealand, Singapore, South Africa and United Kingdom), service station(Australia, United Kingdom and United States), or servo (Australia), is a facility which sells fuel and usually lubricants for motor vehicles. The most common fuels sold today are gasoline (gasoline or gas in the U.S. and Canada, typically petrol elsewhere), diesel fuel, and electric energy. Filling stations that sell only electric energy are also known as charging stations.
          </h3> 
          <h3 style="font-family: 'Segoe UI'; font-size: 16px;">
                Fuel dispensers are used to pump petrol/gasoline, diesel, CNG, CGH2, HCNG, LPG, LH2, ethanol fuel, biofuels like biodiesel, kerosene, or other types of fuel into vehicles and calculate the financial cost of the fuel transferred to the vehicle. Fuel dispensers are also known as bowsers (in some parts of Australia), petrol pumps (in most Commonwealth countries) or gas pumps (in North America).
          </h3>
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
