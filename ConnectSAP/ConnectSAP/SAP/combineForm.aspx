<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="combineForm.aspx.cs" Inherits="ConnectSAP.SAP.combineForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode"/>
                <asp:BoundField DataField="WH01" HeaderText="WH01" DataFormatString="{0:0.##}"/>
                <asp:BoundField DataField="QCqty" HeaderText="QC QTY" DataFormatString="{0:0.##}"/>

            </Columns>
        </asp:GridView>

        <asp:GridView ID="Grid_test" runat="server"></asp:GridView>
    </form>
</body>
</html>
