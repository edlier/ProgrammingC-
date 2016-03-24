﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="combineForm.aspx.cs" Inherits="ConnectSAP.SAP.combineForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/btn.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btn_saveExcel" runat="server" Text="Download Excel" OnClick="btn_saveExcel_Click" Width="150px" CssClass="Georgia18px" /><br /><br />
        <asp:GridView ID="grid_CbineLst" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode"/>
                <asp:BoundField DataField="TotalNeed" HeaderText="需求總數" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="WH01" HeaderText="WH01" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="WH03" HeaderText="WH03" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="WH04" HeaderText="WH04" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="WH16" HeaderText="WH16" DataFormatString="{0:0.##}"/>                
                <asp:BoundField DataField="QCqty" HeaderText="QC 005" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="QCqty2" HeaderText="QC 006" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="LackMaterial" HeaderText="缺料數量" DataFormatString="{0:0.##}"/>

                <asp:BoundField DataField="MinOrdrQty" HeaderText="最小訂購" DataFormatString="{0:G2}"/>
                <asp:BoundField DataField="LeadTime" HeaderText="前置時間" DataFormatString="{0:G2}"/>
                <asp:BoundField DataField="MinLevel" HeaderText="最低庫存量" DataFormatString="{0:F}"/>
                <asp:BoundField DataField="BdAMult" HeaderText="月用量(B/A)*30" DataFormatString="{0:F}"/>

            </Columns>
        </asp:GridView>
        <asp:GridView ID="Grid_test" runat="server"></asp:GridView>
        <%--<asp:GridView ID="grid_stock" runat="server"></asp:GridView>--%>

    </form>
</body>
</html>
