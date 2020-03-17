<%@ Page Language="C#" AutoEventWireup="true" CodeFile="showbtn2datesreport.aspx.cs" Inherits="showbtn2datesreport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        From:&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; To:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Button ID="Button1" runat="server" Text="Back" Height="32px" OnClick="Button1_Click" Width="71px" />
&nbsp;&nbsp;&nbsp;&nbsp;
    </div>

        <div style="margin-left: 400px">
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="835px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1086px">
                <LocalReport ReportPath="Report\Reportbtn2date.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_btn2dates_income" Name="DataSet_btn2dates_income" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_buy" Name="DataSet_buy" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_joma" Name="DataSet_joma" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_baki" Name="DataSetbaki" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSourcedate2" Name="DataSet2" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSourcedate1" Name="DataSet1" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet3" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.dueTableAdapter"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSourcedate2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.itemUsage2TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSourcedate1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.itemUsage1TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_baki" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.usageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_joma" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.duePayTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_buy" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.daillyCostTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_btn2dates_income" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSetbtn2dateTableAdapters.itemUsageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            </div>
    </form>
</body>
</html>
