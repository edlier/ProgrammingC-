<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="complaintRecord.aspx.cs" Inherits="misSystem.sevice.complaintRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CssFile/complaintRecord.css" rel="stylesheet" />
    <title>Complaint Record</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="centerlizeRecord">
            <div id="wrd_inf">Customer Information</div>
            <br />
            Customer :
            <asp:DropDownList ID="drop_customer" runat="server"></asp:DropDownList><br /><br />
            Device Name :
            <asp:DropDownList ID="drop_machineName" runat="server"></asp:DropDownList><br /><br />
            Serial Number :
            <asp:DropDownList ID="drop_SN" runat="server"></asp:DropDownList><br /><br /><br />
            <div id="wrd_inf">Type of complaint</div>
            <asp:CheckBox name="complaintType" runat="server" Text="Packaging/Shipping" />
            <asp:CheckBox name="complaintType" runat="server" Text="Labeling" />
            <asp:CheckBox name="complaintType" Text="Injury or MDR" runat="server" />
            <asp:CheckBox name="complaintType" Text="Design Issue" runat="server" />
            <asp:CheckBox name="complaintType" Text="Product Failure" runat="server" /><br /><br />
            <asp:CheckBox name="complaintType" Text="Error message" runat="server" />&nbsp;<asp:TextBox ID="tb_errorMessage" runat="server"></asp:TextBox><br />
            <br />
            <asp:CheckBox name="complaintType" Text="Other" runat="server" />&nbsp;<asp:TextBox ID="tb_Other" runat="server"></asp:TextBox><br />
            <br />
            <asp:CheckBox name="complaintType" Text="Module failure" runat="server" />
            &nbsp;&nbsp;&nbsp;Module Name :
            <asp:TextBox ID="tb_moduleName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;Module S/N :
            <asp:TextBox ID="tb_moduleSN" runat="server"></asp:TextBox><br /><br />
            <div id="wrd_inf">Complaint Received by</div>
            <asp:CheckBox name="complaintReceiveBy" Text="FAX" runat="server" />
            <asp:CheckBox name="complaintReceiveBy" Text="E-mail" runat="server" />
            <asp:CheckBox name="complaintReceiveBy" Text="Phone" runat="server" />
            <asp:CheckBox name="complaintReceiveBy" Text="Other" runat="server" />
            &nbsp;<asp:TextBox ID="tb_ComplaintReceivebyOther" runat="server"></asp:TextBox><br /><br />
            <div id="wrd_inf">Describe the complaint&nbsp;<asp:DropDownList ID="drop_describeComplaint" runat="server"></asp:DropDownList></div><br /><br />
            <div id="wrd_inf">
                Is this required initial a Vigilance protocol?
                <asp:RadioButton ID="radio_VigilanceNo" runat="server" GroupName="radioVigilance" Text="No"/>
                <asp:RadioButton ID="radio_VigilanceYes" runat="server" GroupName="radioVigilance" Text="Yes"/>
                &nbsp;<asp:TextBox ID="tb_VigilanceYes" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <div id="wrd_inf">
                RMA?
                <asp:RadioButton ID="radio_noRMA" runat="server" GroupName="radioRma" Text="No"/>
                <asp:RadioButton ID="radio_yesRMA" runat="server" GroupName="radioRma" Text="Yes" />
                &nbsp;<asp:TextBox ID="tb_needRMA" runat="server"></asp:TextBox>
            </div>
            <br /><br />
            <asp:Button ID="btn_submit" runat="server" Text="submit" /><br /><br /><br />
        </div>
    </form>
</body>
</html>
