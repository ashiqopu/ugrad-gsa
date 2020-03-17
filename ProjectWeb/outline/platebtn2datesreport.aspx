<%@ Page Language="C#" AutoEventWireup="true" CodeFile="platebtn2datesreport.aspx.cs" Inherits="shamim_platebtn2datesreport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;<asp:TextBox ID="TextBox2" runat="server" Height="24px" Width="134px" Visible="False"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Height="37px" Text="Back" Width="76px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="141px" Visible="False"></asp:TextBox>
        &nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <br />
    
    </div>

        <div>

            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="738px" style="margin-left: 209px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="1030px">
                <LocalReport ReportPath="Report\Reportplatebtn2dates.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet_plate_details" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource2" Name="DataSetpay" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource3" Name="DataSet1" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource4" Name="DataSet2" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource5" Name="DataSet3" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource6" Name="DataSet4" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ObjectDataSource6" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.DataTable3TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource5" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.DataTable2TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox3" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource4" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.itemUsage1TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox3" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.usageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.DataTable1TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox3" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="Dataset_platebtn2daysTableAdapters.itemUsageTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="plate" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox3" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </div>
    </form>
</body>
</html>
