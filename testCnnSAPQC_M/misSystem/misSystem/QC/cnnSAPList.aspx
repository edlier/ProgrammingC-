<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cnnSAPList.aspx.cs" Inherits="misSystem.QC.cnnSAPList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../CssFile/GridviewScroll.css" rel="stylesheet" />

    <%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.2/jquery.min.js"></script>
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jqueryui/1.9.1/jquery-ui.min.js"></script>--%>

    <script src="../scripts/1.8.2-jquery.min.js"></script>
    <script src="../scripts/1.9.1jquery-ui.min.js"></script>
    <script src="../scripts/gridviewScroll.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            gridviewScroll();
        });

        function gridviewScroll() {
            $('#<%=GridView1.ClientID%>').gridviewScroll({
                    width: 1200,
                    height: 600
                });
            }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="Lp600_Tm5_gradient40px">IQC - Validation List</div>
    <div class="Lp300-Tm350" style="font-size: 16px; font-family: Georgia;">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px"
            CellPadding="2" ForeColor="Black" GridLines="None" Width="100%">

            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="NO" ItemStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                        <%#Container.DataItemIndex + 1%>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:BoundField DataField="DocEntry" HeaderText="內部號碼" />--%>
                <asp:BoundField DataField="DocNum" HeaderText="文件號碼" />
                <asp:BoundField DataField="ItemCode" HeaderText="ItemCode" />
                <asp:BoundField DataField="BaseLine" HeaderText="DNo" />
                <asp:BoundField DataField="Qty" HeaderText="Qty" DataFormatString="{0:0.##}" ItemStyle-Width="50px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:TemplateField HeaderText="Btn">
                    <ItemTemplate>
                        <asp:Button ID="btn_start" runat="server" OnClick="btn_start_Click" CssClass="Georgia18px"  CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="status" runat="server" Text='<%# Eval("status2") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Dscription" HeaderText="Dscription" ItemStyle-Width="400px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="CardCode" HeaderText="CardCode" />
                <asp:BoundField DataField="CardName" HeaderText="CardName" />
                <asp:BoundField DataField="Operator" HeaderText="Operator" ItemStyle-Width="280px">
                    <ItemStyle Width=""></ItemStyle>
                </asp:BoundField>
                <asp:BoundField DataField="DocDate2" HeaderText="DocDate" DataFormatString="{0:yyyy-MM-dd}" />
                <%--<asp:BoundField DataField="status2" HeaderText="status" />--%>
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

    </div>
</asp:Content>
