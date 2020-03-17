<%@ Page Language="C#" AutoEventWireup="true" CodeFile="plateDaily.aspx.cs" Inherits="shamim_plateDaily" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="26px" Width="151px" Visible="False"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="158px" Visible="False"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="34px" Text="Back" Width="67px" OnClick="Button1_Click" />
        <br />
    
    </div>

        <div>  
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" style="margin-left: 188px" Width="899px" Font-Names="Verdana" Font-Size="8pt" Height="903px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt">
                <LocalReport ReportPath="Report\Reportplatedaily.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSetplate_details" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSetpay_due" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="DataSet1" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource4" Name="DataSet2" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource5" Name="DataSet_totaldue" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource6" Name="DataSet3" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.DataTable3TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.DataTable2TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.itemUsage1TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.usageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.DataTable1TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetplatereportTableAdapters.itemUsageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>

        <div>   
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
