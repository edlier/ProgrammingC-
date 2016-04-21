<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cnnSAP_List_inProcess.aspx.cs" Inherits="misSystem.QC.cnnSAP_List_inProcess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
    </div>
    <asp:Panel ID="Panl_FilVaInfo" runat="server" Visible="true">
        
    </asp:Panel>
</asp:Content>
