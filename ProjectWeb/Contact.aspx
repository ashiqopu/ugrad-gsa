<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Contact</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <meta charset="UTF-8"/>
  <link rel="stylesheet" type="text/css" href="css/style.css" />
  <script type="text/javascript" src="js/modernizr-1.5.min.js"></script>
        <script>
            function validateNum(evt) {
                var theEvent = evt || window.event;
                var key = theEvent.keyCode || theEvent.which;
                key = String.fromCharCode(key);
                var regex = /[0-9]/;
                if (!regex.test(key)) {
                    theEvent.returnValue = false;
                    if (theEvent.preventDefault) theEvent.preventDefault();
                }
            }

            function validateChar(evt) {
                var theEvent = evt || window.event;
                var key = theEvent.keyCode || theEvent.which;
                key = String.fromCharCode(key);
                var regex = /[a-zA-Z .]/;
                if (!regex.test(key)) {
                    theEvent.returnValue = false;
                    if (theEvent.preventDefault) theEvent.preventDefault();
                }
            }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 98%;
            height: 222px;
        }
        .auto-style9 {
            width: 272px;
            text-align: right;
            color: #FFFFFF;
            height: 42px;
        }
        .auto-style10 {
            width: 272px;
            text-align: center;
            height: 42px;
        }
        .auto-style11 {
            width: 272px;
            text-align: right;
            color: #FFFFFF;
            height: 72px;
        }
        .auto-style12 {
            width: 272px;
            text-align: center;
            height: 72px;
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
            <li><a href="Default.aspx">Home</a></li>
            <li><a href="Login.aspx">Login</a></li>
            <li><a href="Info.aspx">Info</a></li>
            <li class="current"><a href="Contact.aspx">Contact Us</a></li>
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
            Email: </b> <a href="mailto:info@email.fs.bd"><em>info@email.fs.bd</em></a></p>
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
		  <div class="form_settings">
            <h1>Contact Us ...</h1>

            <table class="auto-style1" align="left">
                <tr>
                    <td class="auto-style9" style="font-size: large; color: #FFFFFF">Name :</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="240px" name="name" type="Text" onkeypress="validateChar(event)" required="required" value="" placeholder="Enter Your Name..."></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="font-size: large; color: #FFFFFF">Email :</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBoxEmail" runat="server" Width="240px" name="email" type="email" required="required" value="" placeholder="Enter Your Email..."></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="font-size: large; color: #FFFFFF">Age :</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBoxAge" runat="server" Width="240px" name="age" type="number" onkeypress="validateNum(event)" min="0" MaxLength="2" required="required" value="" placeholder="Enter Your Age..."></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="font-size: large; color: #FFFFFF">Gender :</td>
                    <td class="auto-style10">
                        <asp:DropDownList ID="DropDownListGender" runat="server" Width="240px" name="gender">
                            <asp:ListItem value="Male" Selected="True">Male</asp:ListItem>
                            <asp:ListItem Value="Female">Female</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" style="font-size: large; color: #FFFFFF">Feedback :</td>
                    <td class="auto-style12">
                        <asp:TextBox ID="TextBoxFeedback" runat="server" Width="240px" name="feedback" type="Text" required="required" value="" placeholder="Enter Your Feedback..." Height="52px" TextMode="MultiLine"></asp:TextBox>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Button ID="ButtonSubmit" class="submit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
                    </td>
                </tr>
                </table>
          </div>
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
