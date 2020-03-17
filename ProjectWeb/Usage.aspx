<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Usage.aspx.cs" Inherits="Usage" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Import Namespace = " System.Data " %>
<%@ Import Namespace = " System.Data.SqlClient " %>
<%@ Import Namespace="System.Drawing" %> 

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Usage</title>
  <meta name="description" content="website description" />
  <meta name="keywords" content="website keywords, website keywords" />
  <meta http-equiv="content-type" content="text/html; charset=windows-1252" />
  <meta charset="UTF-8"/>
  <link rel="stylesheet" type="text/css" href="css/style.css" />
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
            <li class="current"><a href="Usage.aspx">Usage</a></li>
            <li><a href="Stock.aspx">Stock</a></li>
            <li><a href="Cost.aspx">Cost</a></li>
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
		  <h1> # Usage Details :
              &nbsp;&nbsp;&nbsp;
                  <asp:Button ID="bsAll" runat="server" Text="Show All" OnClick="bsAll_Click" Height="32px" Width="69px" />
            </h1>
            <h1> Items :
              &nbsp;&nbsp;&nbsp;  
              <asp:DropDownList ID="ddlItem" runat="server" Width="162px" Height="23px" DataSourceID="sqldsItem" DataTextField="Items" DataValueField="Items">
                </asp:DropDownList>
              <asp:SqlDataSource ID="sqldsItem" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Items FROM details"></asp:SqlDataSource>
            
                &nbsp;&nbsp;&nbsp;<asp:ToolkitScriptManager ID="ScriptManagerC" runat="server"></asp:ToolkitScriptManager>
              
              <asp:TextBox ID="TextBoxC1" runat="server" Height="23px" Width="84px" ></asp:TextBox>
              <asp:ImageButton ID="ImageButtonC1" ImageUrl="images/calendar.png" ImageAlign="Bottom" runat="server" />
              <asp:CalendarExtender ID="CalendarExtenderC1" PopupButtonID="ImageButtonC1" runat="server" TargetControlID="TextBoxC1" Format="yyyy-MM-dd"></asp:CalendarExtender>
              
              &nbsp;To :&nbsp;      
               
              <asp:TextBox ID="TextBoxC2" runat="server" Height="23px" Width="84px" ></asp:TextBox>
              <asp:ImageButton ID="ImageButtonC2" ImageUrl="images/calendar.png" ImageAlign="Bottom" runat="server" />
              <asp:CalendarExtender ID="CalendarExtenderC2" PopupButtonID="ImageButtonC2" runat="server" TargetControlID="TextBoxC2" Format="yyyy-MM-dd"></asp:CalendarExtender>        
              
              &nbsp;&nbsp;   
                
              <asp:Button ID="bOk" runat="server" Text="Show" OnClick="bOk_Click" Height="32px" Width="69px" />

            </h1>

            <h1>&nbsp;</h1>

            <asp:GridView ID="gvAll" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="sqldsAll" Width="898px" AllowPaging="True" AllowSorting="True" Font-Strikeout="False" Height="471px">
                <Columns>
                    <asp:BoundField DataField="Plate" HeaderText="Plate" SortExpression="Plate" />
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
             <asp:SqlDataSource ID="sqldsAll" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Plate, Items, Quantity, Amount, Dates, Times FROM itemUsage WHERE (Dates BETWEEN @date1 AND @date2) ORDER BY Dates DESC, Times DESC">
                 <SelectParameters>
                     <asp:ControlParameter ControlID="TextBoxC1" DefaultValue="" Name="date1" PropertyName="Text" />
                     <asp:ControlParameter ControlID="TextBoxC2" Name="date2" PropertyName="Text" />
                 </SelectParameters>
            </asp:SqlDataSource>
             <h1>&nbsp;</h1>

            <asp:GridView ID="gvUsage" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="sqldsUsage" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Height="471px" Width="898px" Caption="             " Font-Strikeout="False">
                <Columns>
                    <asp:BoundField DataField="Plate" HeaderText="Plate" SortExpression="Plate" />
                    <asp:BoundField DataField="Items" HeaderText="Items" SortExpression="Items" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="Dates" HeaderText="Dates" SortExpression="Dates" />
                    <asp:BoundField DataField="Times" HeaderText="Times" SortExpression="Times" />
                </Columns>
                <EditRowStyle Wrap="True" />
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" HorizontalAlign="Center" VerticalAlign="Middle" />
                <SelectedRowStyle BackColor="#009999" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <asp:SqlDataSource ID="sqldsUsage" runat="server" ConnectionString="<%$ ConnectionStrings:myConnectionString %>" SelectCommand="SELECT Plate, Items, Quantity, Amount, Dates, Times FROM itemUsage WHERE (Items = @item) AND (Dates BETWEEN @date1 AND @date2) ORDER BY Dates DESC, Times DESC">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlItem" Name="item" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="TextBoxC1" Name="date1" PropertyName="Text" />
                    <asp:ControlParameter ControlID="TextBoxC2" Name="date2" PropertyName="Text" />
                </SelectParameters>
            </asp:SqlDataSource>
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

