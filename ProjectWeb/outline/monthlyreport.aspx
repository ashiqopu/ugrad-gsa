<%@ Page Language="C#" AutoEventWireup="true" CodeFile="monthlyreport.aspx.cs" Inherits="shamim_monthlyreport" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="Button1" runat="server" Height="35px" Text="Back" Width="77px" OnClick="Button1_Click" />
    
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 107px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
    
        <asp:TextBox ID="dijel" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="petrol" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="octen" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="mobil" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="supervtin" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="supervbalti" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="GTX" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="HD_40" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="GO5L" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="GO4L" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="GO1L" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="breakOil" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="mobil2T" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="visco3000" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="gris1" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="gris2" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="gris3" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="gris4" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="lpg" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="ho" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="bp" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="cw" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="sto" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="df" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="mf" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="lf" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="tf" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="zp" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="dsm" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="fo" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="mbf" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>
        <asp:TextBox ID="bbf" runat="server" Height="16px" Width="16px" Visible="False"></asp:TextBox>

    
    </div>

        <div>

            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="655px" style="margin-left: 218px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="846px">
                <LocalReport ReportPath="Report\monthlyReport.rdlc">
                    <DataSources>
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_dijel" Name="DataSet1" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_dor" Name="DataSet2" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_petrol" Name="DataSet_petrol" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_petrol_dor" Name="DataSet_petrol_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_octen" Name="DataSet_octen" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_octen_dor" Name="DataSet_octen_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mobil" Name="DataSet_mobil" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mobil_dor" Name="DataSet_mobil_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_supervtin" Name="DataSet_supervtin" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_supervtin_dor" Name="DataSet_supervtin_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_supervbalti" Name="DataSet_superv_balti" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_supervbalti_dor" Name="DataSet_supervbalti_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gtx" Name="DataSet_gtx" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gtx_dor" Name="DataSe_gtx_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_hd40" Name="DataSet_hd40" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_hd40_dor" Name="DataSet_hd40_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_5LGO" Name="DataSet_5LGO" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_5LGO_dor" Name="DataSet_5LGO_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_4LGO" Name="DataSet_4LGO" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_4LGO_dor" Name="DataSet_4LGO_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_1LGO" Name="DataSet_1LGO" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_1LGO_dor" Name="DataSet_1LGO_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bo" Name="DataSet_bo" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bo_dor" Name="DataSet_bo_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_2tmobil" Name="DataSet_2tmobil" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_2tmobil_dor" Name="DataSet_2tmobil_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_visco3000" Name="DataSet_visco3000" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_visco3000_dor" Name="DataSet_visco3000_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris1" Name="DataSet_gris1" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris1_dor" Name="DataSet_gris1_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris2" Name="DataSet_gris2" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris2_dor" Name="DataSet_gris2_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris3" Name="DataSet_gris3" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris3_dor" Name="DataSet_gris3_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris4" Name="DataSet_gris4" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_gris4_dor" Name="DataSet_gris4_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_lpg" Name="DataSet_lpg" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_lpg_dor" Name="DataSet_lpg_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_ho" Name="DataSet_ho" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_ho_dor" Name="DataSet_ho_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bp" Name="DataSet_bp" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bp_dor" Name="DataSet_bp_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_cw" Name="DataSet_cw" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_cw_dor" Name="DataSet_cw_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_sto" Name="DataSet_sto" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_sto_dor" Name="DataSet_sto_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_df" Name="DataSet_df" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_df_dor" Name="DataSet_df_dor" />
                         <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mf" Name="DataSet_mf" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mf_dor" Name="DataSet_mf_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_lf" Name="DataSet_lf" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_lf_dor" Name="DataSet_lf_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_tf" Name="DataSet_tf" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_tf_dor" Name="DataSet_tf_dor" />
                         <rsweb:ReportDataSource DataSourceId="ObjectDataSource_zp" Name="DataSet_zp" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_zp_dor" Name="DataSet_zp_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_dsm" Name="DataSet_dsm" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_dsm_dor" Name="DataSet_dsm_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_fo" Name="DataSet_fo" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_fo_dor" Name="DataSet_fo_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mbf" Name="DataSet_mbf" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_mbf_dor" Name="DataSet_mbf_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bbf" Name="DataSet_bbf" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_bbf_dor" Name="DataSet_bbf_dor" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_details" Name="DataSet_details" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource_due" Name="DataSet_due" />
                        <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet_otherscost" />
                    </DataSources>
                </LocalReport>
            </rsweb:ReportViewer>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.othersCostTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_due" runat="server" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.dueTableAdapter">
                <InsertParameters>
                    <asp:Parameter Name="Customer" Type="String" />
                    <asp:Parameter Name="Plate" Type="String" />
                    <asp:Parameter Name="Due" Type="Double" />
                </InsertParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_details" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.detailsTableAdapter"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_month_exp" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.Month_ExpensesTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bbf_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="bbf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bbf" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="bbf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ObjectDataSource_mbf" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mbf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_mbf_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mbf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ObjectDataSource_fo_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="fo" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_fo" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="fo" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
             <asp:ObjectDataSource ID="ObjectDataSource_dsm" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dsm" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_dsm_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dsm" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_zp_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="zp" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_zp" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="zp" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_tf" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_tf_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_lf_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_lf" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            
            <asp:ObjectDataSource  ID="ObjectDataSource_mf" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_mf_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mf" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
             <asp:ObjectDataSource  ID="ObjectDataSource_df" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="df" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_df_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="df" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource  ID="ObjectDataSource_sto" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="sto" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_sto_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="sto" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource  ID="ObjectDataSource_cw" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="cw" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_cw_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="cw" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bp" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="bp" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bp_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="bp" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_ho_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ho" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_ho" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ho" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_lpg_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lpg" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_lpg" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lpg" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris4_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris4" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris4" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris4" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris3_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris3" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris3" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris3" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris2_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris2" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris2" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris1_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris1" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gris1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="gris1" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_visco3000_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="visco3000" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_visco3000" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="visco3000" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_2tmobil_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mobil2T" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_2tmobil" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mobil2T" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bo_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="breakOil" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_bo" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="breakOil" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_1LGO_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO1L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_1LGO" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO1L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_4LGO_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO4L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_4LGO" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO4L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_5LGO_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO5L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_5LGO" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GO5L" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_hd40_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="HD_40" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_hd40" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="HD_40" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gtx_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GTX" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_gtx" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GTX" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_supervbalti_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="supervbalti" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_supervbalti" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="supervbalti" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_supervtin_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="supervtin" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_supervtin" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="supervtin" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_mobil_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mobil" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_mobil" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="mobil" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_octen_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="octen" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_octen" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="octen" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_petrol_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="petrol" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_petrol" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.পেট্রোল_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="petrol" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="0" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_dor" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ক্রয়দর_বিক্রয়দর_TableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dijel" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:ObjectDataSource ID="ObjectDataSource_dijel" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="DataSet_MonthlyTableAdapters.ডিজেলTableAdapter">
                <SelectParameters>
                    <asp:ControlParameter ControlID="dijel" DefaultValue="0" Name="item" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox1" DefaultValue="" Name="date1" PropertyName="Text" Type="String" />
                    <asp:ControlParameter ControlID="TextBox2" DefaultValue="0" Name="date2" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>

        </div>
    </form>
</body>
</html>
