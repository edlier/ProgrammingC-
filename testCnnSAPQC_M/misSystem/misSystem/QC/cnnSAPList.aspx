<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cnnSAPList.aspx.cs" Inherits="misSystem.QC.cnnSAPList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CssFile/GridviewScroll.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Lp600_Tm5_gradient40px">IQC - Validation List</div>
    <div class="Lp300-Tm350" style="font-size: 16px; font-family: Georgia;">
        <asp:Panel ID="Panel1" runat="server" ScrollBars="Vertical" Height="450px">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Width="100%" >
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <%--<asp:BoundField DataField="DocEntry" HeaderText="內部號碼" />--%>
                <asp:BoundField DataField="DocNum" HeaderText="文件號碼" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" DataFormatString="{0:0.##}" ItemStyle-Width="50px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Dscription" HeaderText="Dscription" ItemStyle-Width="400px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="Processer" HeaderText="Processer" ItemStyle-Width="280px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DocDate2" HeaderText="DocDate" DataFormatString="{0:yyyy-MM-dd}"/>
                <asp:BoundField DataField="status2" HeaderText="status" />

            </Columns>
            <HeaderStyle CssClass="GridviewScrollHeader" />
            <RowStyle CssClass="GridviewScrollItem" />
            <PagerStyle CssClass="GridviewScrollPager" />
            <%--<FooterStyle BackColor="Tan" />--%>
            <%--<HeaderStyle BackColor="Tan" Font-Bold="True" CssClass="GridviewScrollHeader"/>--%>
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>

        </asp:Panel>
    </div>
</asp:Content>
