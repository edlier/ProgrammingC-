<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cnnSAP_List_inProcess.aspx.cs" Inherits="misSystem.QC.cnnSAP_List_inProcess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../scripts/jquery-1.11.2.min.js"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.0/jquery.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#<%=tb_TotalQty.ClientID%>').on('focusout', function () {
                var regex = /^[0-9]+$/;
                if (!regex.test($('#<%=tb_TotalQty.ClientID%>').val()))
                {
                    $('#tb_totalError').text(" Total  count cannot be String!");
                    $("#<%=tb_TotalQty.ClientID%>").val('');
                }

                else {
                    $('#tb_totalError').text("");
                }
            });
<%--            $('#<%=tb_ProHr.ClientID%>').on('focusout', function () {
                var regex = /^[0-9]+$/;
                if (!regex.test($('#<%=tb_ProHr.ClientID%>').val())) {
                    $('#tb_HrError').text(" The Qty could not be String!");
                    $("#<%=tb_ProHr.ClientID%>").val('');
                }
                else {
                    $('#tb_HrError').text("");
                }
            });
            $('#<%=tb_ProMin.ClientID%>').on('focusout', function () {
                var regex = /^[0-9]+$/;
                if (!regex.test($('#<%=tb_ProMin.ClientID%>').val())) {
                    $('#tb_MinError').text(" The Qty could not be String!");
                    $("#<%=tb_ProMin.ClientID%>").val('');
                }
                else {
                    $('#tb_MinError').text("");
                }
            });--%>

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Lp600_Tm5_gradient40px">IQC - Validation Raw Material</div>
    
    <div class="Lp600-Tm325-georgia18px">
        <asp:Label ID="Label2" runat="server" Text="Doc Num:"></asp:Label>
        <asp:Label ID="lb_docnum" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="Label1" runat="server" Text="Item Code:"></asp:Label>
        <asp:Label ID="lb_ItemCode" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Item Description:"></asp:Label>
        <asp:Label ID="lbl_ltemdsrp" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="Label4" runat="server" Text="Supplier Code:"></asp:Label>
        <asp:Label ID="lbl_supplierCode" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="Label5" runat="server" Text="Supplier Name:"></asp:Label>
        <asp:Label ID="lbl_supplierName" runat="server"></asp:Label>
        <br /><br />
        <asp:Label ID="Label6" runat="server" Text="Doc Date:"></asp:Label>
        <asp:Label ID="lbl_DocDate" runat="server" DataFormatString="{0:yyyy-MM-dd}"></asp:Label>
        <br /><br />
        <asp:Label ID="Label7" runat="server" Text=" Quantity:"></asp:Label>
        <asp:Label ID="lbl_Qty" runat="server" DataFormatString="{0:0.##}"></asp:Label>
        <br /><br />
        <asp:Button ID="btn_StartValidation" runat="server" Text="Start Validation" 
            OnClick="btn_StartValidation_Click" Visible="false" CssClass="W180H30-georgia20px"
            OnClientClick="if (!confirm('Do you want to Start Validation?')) return false;"/>
        


        <%--↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓--%>





        <asp:Panel ID="Panl_FilVaInfo" runat="server" Visible="false">
            <br /><br />
           <hr style="border:0; height:3px; background-color:#b5ca60"/> 
            <br /><br />
            <asp:Label ID="Label8" runat="server" Text="Total Qty : "></asp:Label>
            <asp:TextBox ID="tb_TotalQty" runat="server" CssClass="W50_Georgia18px"></asp:TextBox>
            <label id="tb_totalError" class="RedBold_Georgia18px"></label>
            <br /><br />
            <asp:Label ID="Label9" runat="server" Text="Failed Qty : "></asp:Label>
            <asp:TextBox ID="tb_FailedQty" runat="server" CssClass="W50_Georgia18px" OnTextChanged="tb_FailedQty_TextChanged" AutoPostBack="true"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lbl_failedReason" runat="server" Text="Failed Reason :" ></asp:Label>
            <asp:DropDownList ID="drop_FailedReason" runat="server" Enabled="false" DataValueField="id" DataTextField="idDes" CssClass="Georgia18px"></asp:DropDownList>
            <br /><br />
            <asp:Label ID="Label10" runat="server" Text="Process Time : "></asp:Label>
            <asp:TextBox ID="tb_ProHr" runat="server" CssClass="W50_Georgia18px"></asp:TextBox><%--<label id="tb_HrError" class="RedBold_Georgia18px"></label>--%>
            <asp:Label ID="Label11" runat="server" Text="HR "></asp:Label>
            <asp:TextBox ID="tb_ProMin" runat="server" CssClass="W50_Georgia18px"></asp:TextBox><%--<label id="tb_MinError" class="RedBold_Georgia18px"></label>--%>
            <asp:Label ID="label" runat="server" Text="MIN "></asp:Label>
            <br /><br /><br />
            <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" CssClass="W100H28-georgia18px" />
    </asp:Panel>
    </div>

</asp:Content>
